﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Core.Services.Models
{
    public class ResultModel<T> : BaseResult
    {
        public T Data { get; set; }
    }
}
