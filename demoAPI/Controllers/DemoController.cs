using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public static List<string> allMember = new List<string>
         { "Name :Mickey", "Name :Dorarmon" };

        [HttpGet]
        public List<string> Get()
        {
            return allMember;
        }

        [HttpGet("{GetByIndex}")]
        public string GetById(int GetByIndex)
        {
            if (allMember[GetByIndex] != null)
            {
                return allMember[GetByIndex];
            }
            return string.Empty;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string name)
        {
            allMember.Add(name);
        }

        // PUT api/values/5
        [HttpPut("{index}")]
        public void Put(int index, [FromBody] string name)
        {
            if (allMember[index] != null)
            {
                allMember[index] = name;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            var deleteName = allMember[index];
            allMember.Remove(deleteName);
        }
    }
}
