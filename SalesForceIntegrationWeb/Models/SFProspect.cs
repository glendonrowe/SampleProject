using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesForceIntegrationWeb.Models
{
  public class SFProspect
  {
    [JsonProperty(PropertyName = "AccountName__c", NullValueHandling = NullValueHandling.Ignore)]
    public string Account { get; set; }
    [JsonProperty(PropertyName = "Email__c", NullValueHandling = NullValueHandling.Ignore)]
    public string Email { get; set; }
    [JsonProperty(PropertyName = "First_Name__c", NullValueHandling = NullValueHandling.Ignore)]
    public string FirstName { get; set; }
    [JsonProperty(PropertyName = "Last_Name__c", NullValueHandling = NullValueHandling.Ignore)]
    public string LastName { get; set; }
    [JsonProperty(PropertyName = "NewRole__c", NullValueHandling = NullValueHandling.Ignore)]
    public string NewRole { get; set; }
    [JsonProperty(PropertyName = "News_Publication_Date__c", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime NewsPublicationDate { get; set; }
    [JsonProperty(PropertyName = "News_source__c", NullValueHandling = NullValueHandling.Ignore)]
    public string NewsSource { get; set; }
    [JsonProperty(PropertyName = "News_Summary__c", NullValueHandling = NullValueHandling.Ignore)]
    public string NewsSummary { get; set; }
    [JsonProperty(PropertyName = "News_title__c", NullValueHandling = NullValueHandling.Ignore)]
    public string NewsTitle { get; set; }
    [JsonProperty(PropertyName = "Source__c", NullValueHandling = NullValueHandling.Ignore)]
    public string Source { get; set; }
    [JsonProperty(PropertyName = "Stage__c", NullValueHandling = NullValueHandling.Ignore)]
    public string Stage { get; set; }
    [JsonProperty(PropertyName = "Name", NullValueHandling = NullValueHandling.Ignore)]
    public string ProspectName { get; set; }
  }
}
