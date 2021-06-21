using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitDemo.Configuration
{
    public interface IApiConfig
    {
        string BaseUrl { get; set; }
    }
}
