using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesForceIntegrationWeb.Models
{
  public class JobChange
  {
    [JsonProperty(PropertyName = "prospect_id")]
    public string ProspectId { get; set; }
    [JsonProperty(PropertyName = "prospect_name")]
    public string ProspectName { get; set; }
    [JsonProperty(PropertyName = "person_name")]
    public string PersonName { get; set; }
    [JsonProperty(PropertyName = "news_title")]
    public string NewsTitle { get; set; }
    [JsonProperty(PropertyName = "news_summary")]
    public string NewsSummary { get; set; }
    [JsonProperty(PropertyName = "news_source")]
    public string NewsSource { get; set; }
    [JsonProperty(PropertyName = "news_publication_date")]
    public string NewsPublicationDate { get; set; }
  }
}
