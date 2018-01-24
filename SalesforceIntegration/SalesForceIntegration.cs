using SalesforceIntegration.Client;
using SalesforceIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesforceIntegration
{
  public class SIFInterface
  {
    private AuthModel _auth;
    private SalesForceClient _client;
    public SIFInterface(AuthModel auth)
    {
      _auth = auth;
      _client = new SalesForceClient(auth);
    }

    public void SendWorkToSIF(IEnumerable<WorkModel> work)
    {
      foreach (var workObj in work)
      {
        var resp = _client.PostWork(workObj).Result;
      }
    }
  }
}
