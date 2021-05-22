using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Script.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace testWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TestDataController : ControllerBase
    {

        [HttpGet]
        public async Task<string> GetData()
        {
            ResponseData res = new ResponseData();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                res.barsData.Add(rnd.Next(1, 50));
                res.lineData.Add(rnd.Next(1, 50));
                res.bubbleData.Add(new Point(rnd.Next(1, 50), rnd.Next(1, 50), rnd.Next(1, 10)));
            }
            string jsonString = JsonSerializer.Serialize(res);
            return jsonString;
        }

    }

}
