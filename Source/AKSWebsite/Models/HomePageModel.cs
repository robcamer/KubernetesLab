﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKSWebsite.Models
{
    public class HomePageModel
    {
        public IConfiguration Configuration { get; set; }
        public APIResponse APIResponse { get; set; }
        public string APILocation { get; set; }
        public string APIName { get; set; }
    }
}
