using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstProjectWebApi.Models;
//this two line


namespace firstProjectWebApi.Controllers
{
    [Route("api/cat")]
    [ApiController]
    public class CatController : Controller
    {
        //cats List
         public static List <Cat> cats = new List<Cat>();

        // GET api/cat/
        //your code is here un comment this method and write the required code to handle get request
        [HttpGet]
            public IEnumerable<Cat> GetAll()
         {
            //your code is here
            //here how to add new cat
            // cats.Add(new Cat("b2"));
            return cats;
         }
        // 

        // POST api/cat
        [HttpPost]
        public Cat Insert([FromBody]Cat cat)
        {
            cats.Add(cat);
            // cats.Add(cat);
            //your code is here
            return cat;
        }

        // PUT api/cat/name
        [HttpPut("{name}")]
        public Cat Put(string name, [FromBody] Cat cat)
        {
            //your code is here
            for (int i = 0; i < cats.Count; i++)
            {
                if (cats[i].name==name)
                    cats[i] = cat;
            };
            return cat;
        }
        // DELETE api/cat/1

        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            //your code is here

        }


    }
}