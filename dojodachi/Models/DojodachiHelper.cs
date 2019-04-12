using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace dojodachi.Models
{
  public static class DojodachiHelper
  {
    private static Dojodachi dojo;

    public static Dojodachi Get(HttpContext _)
    {
      string session = _.Session.GetString("dachi");
      if (session is null)
      {
        dojo = new Dojodachi();
        _.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
      }
      else
        dojo = JsonConvert.DeserializeObject<Dojodachi>(session);

      return dojo;
    }

    public static void Save(HttpContext _, Dojodachi dojo)
    {
      _.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
    }

  }
}