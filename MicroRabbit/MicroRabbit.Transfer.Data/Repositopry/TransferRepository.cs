using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicrorRabbit.Transfer.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrorRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
        public void Add(TransferLog transfer)
        {
            _ctx.Add(transfer);
            _ctx.SaveChanges();
        }

    }
}
