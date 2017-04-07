using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NJsonSchema;
using NJsonSchema.Annotations;

namespace NSwagCustomSchema.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
       

        // GET api/values/5
        [HttpGet("{id}")]
        public Foo Get(int id)
        {
            return new Foo();
        }

       
    }

    public class Foo
    {
        [JsonSchema(JsonObjectType.String)]
        public Bar Bar { get; set; }
    }

    public class Bar
    {
        //TODO: Override Newtonsoft json serialization
        public string Test { get; set; }
    }
}
