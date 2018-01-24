using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesforceIntegration.Models
{
  public class WorkModel
  {
    [JsonProperty(PropertyName = "Integration__c", NullValueHandling = NullValueHandling.Ignore)]
    public string IntegrationId { get; set; }

    [JsonProperty(PropertyName = "Direction__c", NullValueHandling = NullValueHandling.Ignore)]
    public string Direction { get; set; }

    [JsonProperty("Action__c", NullValueHandling = NullValueHandling.Ignore)]
    public string Action { get; set; }

    [JsonProperty(PropertyName = "Target_Object_Type__c", NullValueHandling = NullValueHandling.Ignore)]
    public string TargetObjectType { get; set; }

    [JsonProperty(PropertyName = "Status__c", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }

    [JsonProperty(PropertyName = "Target_Object_Id__c", NullValueHandling = NullValueHandling.Ignore)]
    public string TargetObjectId { get; set; }

    [JsonProperty(PropertyName = "Long_Text_Parameter__c", NullValueHandling = NullValueHandling.Ignore)]
    public string LongTextParameter { get; set; }

  }
}
