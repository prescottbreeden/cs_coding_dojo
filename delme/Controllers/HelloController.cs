using Microsoft.AspNetCore.Mvc;
namespace delme.Controllers     //be sure to use your own project's namespace!
{
  public class WolfController : Controller   //remember inheritance??
  {
    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Wolf()
    {
      return View("wolf");
    }

    [HttpGet]       //type of request
    [Route("werewolf")]     //associated route string (exclude the leading /
    public string Hi()
    {
      return "Hello I'm a werewolf!";
    }

    [HttpGet]       //type of request
    [Route("werewolf/{name}")]     //associated route string (exclude the leading /
    public string Yehor(string name)
    {
      return $"Hello I'm {name}, and I'm a werewolf!";
    }
  }
}