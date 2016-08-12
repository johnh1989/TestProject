using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class ExampleResponse
    {
        [JsonProperty("insert-key-here")]
        public String insertkeyhere { get; set; }

        [JsonProperty("key")]
        public String value { get; set; }

    }
}
