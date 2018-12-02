using Microsoft.AspNetCore.Http;
using dojodachi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace dojodachi.Models
{
  public static class DojodachiHelper
  {
    public static Dojodachi dojo ;
    static DojodachiHelper()
    {
      NewDojodachi();
    }
    public static Dojodachi NewDojodachi()
    {
      dojo = new Dojodachi(); 
      return dojo;
    }
    public void SaveDojodachi(object dojo)
    {
      context.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
    }
    public void Feed()
    {
      dojo.Feed();
      SaveDojodachi(dojo);
    }
    public void Play()
    {
      dojo.Play();
      SaveDojodachi(dojo);
    }
    public void Work()
    {
      dojo.Work();
      SaveDojodachi(dojo);
    }
    public void Sleep()
    {
      dojo.Sleep();
      SaveDojodachi(dojo);
    }
  }
}