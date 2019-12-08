﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDTO
    {
        public int AccountFrom { get; set; }
        public int AccountTo { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
