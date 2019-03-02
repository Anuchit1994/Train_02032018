using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public static List<string> allMember = new List<string>
         { "Mickey", "Dorarmon" };

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
        [HttpPost("{name}")]
        public void Post(string name)
        {
            allMember.Add(name);
        }

        // PUT api/values/5
        [HttpPut("{index}/{name}")]
        public void Put(int index, string name)
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
