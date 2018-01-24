using Newtonsoft.Json;
using SalesforceIntegration;
using SalesforceIntegration.Models;
using SalesForceIntegrationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesForceIntegrationWeb.Domain
{
  public class SalesForceDomain
  {
    private SIFInterface _sif;

    public SalesForceDomain(AuthModel auth)
    {
      _sif = new SIFInterface(auth);
    }

    internal void WriteChangesToSF(IEnumerable<JobChange> changes)
    {
      var workObjects = convertToWork(changes);

      _sif.SendWorkToSIF(workObjects);
    }

    private IEnumerable<WorkModel> convertToWork(IEnumerable<JobChange> changes)
    {
      var workList = new List<WorkModel>();
      foreach (var jobChange in changes)
      {
        var sfProspect = ConvertJobChangeToSF(jobChange);
        var work = new WorkModel()
        {
          IntegrationId = "a6C2a0000004E7s",
          Direction = "Incoming",
          Action = "Insert Record",
          TargetObjectType = "Prospect__c",
          Status = "Pending",
          TargetObjectId = "01I2a00000009J0",
          LongTextParameter = JsonConvert.SerializeObject(sfProspect)
        };
        workList.Add(work);
      }
      return workList;
    }

    private SFProspect ConvertJobChangeToSF(JobChange jobChange)
    {
      var prospect = new SFProspect()
      {
        Account = jobChange.ProspectId,
        Email = $"{jobChange.PersonName.Replace(" ", "")}@gmail.com",
        FirstName = jobChange.PersonName.TrimStart().Split(' ')[0],
        LastName = jobChange.PersonName.TrimStart().Substring(jobChange.PersonName.IndexOf(' ') + 1),
        NewRole = "CFO",
        //NewsPublicationDate = DateTime.Parse(jobChange.NewsPublicationDate),
        NewsSource = jobChange.NewsSource,
        NewsSummary = GetNewsSummary(jobChange.NewsSummary),
        NewsTitle = jobChange.NewsTitle,
        ProspectName = jobChange.ProspectName,
        Source = "Google",
        Stage = "Pending"
      };

      return prospect;
    }

    private string GetNewsSummary(string newsSummary)
    {
      return newsSummary != null
          ? (newsSummary.Length > 999 ? newsSummary.Substring(0, 999) : newsSummary)
          : null;
    }
  }
}
