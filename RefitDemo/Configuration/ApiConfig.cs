using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitDemo.Configuration
{
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set; }
    }
}
