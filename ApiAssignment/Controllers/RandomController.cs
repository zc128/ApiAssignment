using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAssignment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class random: ControllerBase
    {
        [HttpGet]
        public int Get() {
            Random rando = new Random();
            var ran = rando.Next(1,10000);
            return ran;
        }
        [HttpPost]
        public double Post() {
            Random rando = new Random();
            var dou = rando.NextDouble();
            return dou;
        }

        [HttpPut]
        public string Put() {
            return "Thank you for the new number!";
        }

        [HttpDelete]
        public char Delete() {
            Random random = new Random();
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            char letter = Convert.ToChar(shift + 65);
            return letter;
        }

        [HttpPatch]
        public string Patch() {
            DateTime time = DateTime.Now;
            return time.ToString();
        }

        [HttpOptions]
        public dynamic Options()
        {
            Response.ContentType = "application/json";

            var json = new
            {
                HttpGet = "Return a random integer",
                HttpPost = "Return a random double",
                HttpPut = "Return message: Thank you for the new number!",
                HttpDelete = "Return a random character",
                HttpPatch = "Return a string that gives the current date",
        };
            return json;
        }

    }
}
