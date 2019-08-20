﻿using ProAspNetCoreMvcModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcModelBinding.Repository
{
    public class IRepository
    {
        IEnumerable<Pessoa> Pessoa { get; }
        Pessoa this[int id] { get; set; }
    }
}
