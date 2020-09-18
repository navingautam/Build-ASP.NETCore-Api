﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandonApi.Infrastructure;

namespace LandonApi.Models
{
    public class Room : Resource
    {
        [Sortable]
        public string Name { get; set; }

        [Sortable]
        public decimal Rate { get; set; }
    }
}
