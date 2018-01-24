using Salesforce.Common;
using Salesforce.Common.Models;
using Salesforce.Force;
using SalesforceIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace SalesforceIntegration.Client
{
  public class SalesForceClient
  {
    private IForceClient _client;

    public SalesForceClient(AuthModel auth)
    {
      var authenticator = new AuthenticationClient();
      authenticator.UsernamePasswordAsync(
        auth.ConsumerKey
        , auth.ConsumerSecret
        , auth.Username
        , String.Concat(auth.Password, auth.SecurityToken)
        , auth.TokenRequestPointUrl).Wait();

      var instanceUrl = authenticator.InstanceUrl;
      var accessToken = authenticator.AccessToken;
      var apiVersion = authenticator.ApiVersion;

      _client = new ForceClient(instanceUrl, accessToken, apiVersion, new HttpClient());
    }

    public async Task<SuccessResponse> PostWork(WorkModel workObj)
    {
      return await _client.CreateAsync("Integration_Work__c", workObj);
    }

    //public async Task<SuccessResponse> FetchWork()
    //{
    //  return await _client.QueryAsync("Integration_Work__c");
    //}
  }
}
