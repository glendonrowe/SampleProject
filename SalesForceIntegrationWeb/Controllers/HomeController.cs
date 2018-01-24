using SalesforceIntegration.Models;
using SalesForceIntegrationWeb.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesForceIntegrationWeb.Controllers
{
  public class HomeController : Controller
  {
    private SalesForceDomain _salesforce;

    public ActionResult Index()
    {
      var sfAuth = new AuthModel()
      {
        IntegrationId = "a6C2a0000004E7s",
        ConsumerKey = "3MVG9dKFWsESbpkFgUzqLczaiM1zD2djiz2fQNCVM0bdG1GFNYx5R_aAzTDnfiF7npNYJ5m8KgWc..sWsMQZf",
        ConsumerSecret = "1009989016979642666",
        Username = "wegotthemoves@ultimatesoftware.com.wildwest",
        Password = "ultimate1234",
        SecurityToken = "V6FNKl7RiJeqtvA3l4Li8khLB",
        TokenRequestPointUrl = "https://test.salesforce.com/services/oauth2/token"
      };

      _salesforce = new SalesForceDomain(sfAuth);
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    internal class Auth
    {
      public string IntegrationId { get; set; }
      public string ConsumerKey { get; set; }
      public string ConsumerSecret { get; set; }
      public string UserName { get; set; }
      public string Password { get; set; }
      public string SecurityToken { get; set; }
      public string TokenRequestPointUrl { get; set; }
    }

  }
}
