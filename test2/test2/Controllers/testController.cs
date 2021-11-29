using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using a3ERPActiveXNET;
using Newtonsoft.Json;
using System.Text;

namespace test2.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class testController : ControllerBase
    {
        Enlace a3ERPEnlace = null;

        public static Enlace InitA3()
        {
            Enlace enlace = new Enlace();
            enlace.VerBarraDeProgreso = false;
            enlace.LoginUsuario("ship", "1234566");
            return enlace;
        }

        // GET: api/test
        [HttpGet]
        public Enlace Get()
        {
            return InitA3();
        }

        // GET: api/test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/test/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
