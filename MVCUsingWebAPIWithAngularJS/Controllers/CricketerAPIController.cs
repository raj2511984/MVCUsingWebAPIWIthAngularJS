using System.Collections.Generic;
using System.Web.Http;
using MVCUsingWebAPIWithAngularJS.DataLayer;
using MVCUsingWebAPIWithAngularJS.DataLayer.Models;
//[Authorize]
[RoutePrefix("api/cricketer")]
public class CricketerAPIController : ApiController
{
    // GET api/CricketerAPI/
    [HttpGet]
    [Route("getcricketers/")]
    public List<CricketerViewModel> GetCricketers()
    {
        Cricketer cricketerDataLayer = new Cricketer();
        return cricketerDataLayer.GetCricketers();
    }
    // GET api/CricketerAPI/Detail/1111
    [HttpGet()]
    [Route("cricketerdetail/{cricketerId}")]
    public CricketerDetailViewModel GetDetail(int cricketerId)
    {        
        Cricketer cricketerDataLayer = new Cricketer();
        return cricketerDataLayer.Detail(cricketerId);
    }
    [HttpPost()]
    [Route("updatecricketer")]
    public int UpdateCricketer([FromBody()] CricketerViewModel cricketer)
    {
        Cricketer cricketerDataLayer = new Cricketer();
        return cricketerDataLayer.UpdateCricketer(cricketer);
    }
    [HttpGet()]
    [Route("deletecricketer/{cricketerId}")]
    public void DeleteCricketer(int cricketerId)
    {
        Cricketer cricketerDataLayer = new Cricketer();
        cricketerDataLayer.DeleteCricketer(cricketerId);
    }
    // GET api/CricketerAPI/Detail/1111
    [HttpGet()]
    [Route("cricketerdetail/ODIStats/{cricketerId}")]
    public CricketerODIStatsViewModel GetODIStats(int cricketerId)
    {
        Cricketer cricketerDataLayer = new Cricketer();
        return cricketerDataLayer.ODIStats(cricketerId);
    }
    // GET api/CricketerAPI/Detail/1111
    [HttpGet()]
    [Route("cricketerdetail/TestStats/{cricketerId}")]
    public CricketerTestStatsViewModel GetTestStats(int cricketerId)
    {
        Cricketer cricketerDataLayer = new Cricketer();
        return cricketerDataLayer.TestStats(cricketerId);
    }
}

