using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    interface MyApi
    {
        [Get("/insert-key-here/insert-value-here/key/value")]
        Task<ExampleResponse> GetResponse();
    }
}
