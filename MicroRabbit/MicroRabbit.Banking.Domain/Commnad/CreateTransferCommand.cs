﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commnad
{
    public class CreateTransferCommand:TransferCommand
    {
        public CreateTransferCommand(int from,int to,decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
