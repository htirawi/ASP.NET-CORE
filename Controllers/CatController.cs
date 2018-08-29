using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstProjectWebApi.Models;
//this two line
using System.Net;
using System.IO;

namespace firstProjectWebApi.Controllers
{
	[Route("api/cat")]
    [ApiController]
	public class CatController : Controller
	{	
		//cats List
		// public static List <Cat> cats = new List<Cat>();

        // GET api/cat/
        //your code is here uncomment this method and write the required code to handle get request
         [HttpGet]
        //  public IEnumerable<Cat> GetAll()
        // {
        // 	//your code is here

        // }
// 

        // POST api/cat
        [HttpPost]
		public Cat Insert([FromBody]Cat cat)
		{
            //your code is here
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["thing1"] = "hello";
                values["thing2"] = "world";

                var response = client.UploadValues("http://localhost/api/cat", values);
				
            }
			return cat;
		}

        // PUT api/cat/name
		[HttpPut("{name}")]
		public void Put(string name, [FromBody] Cat cat)
		{
			//your code is here
		}

        // DELETE api/cat/1

		[HttpDelete("{name}")]
		public void Delete(string name)
		{
			//your code is here
		}


	}
}