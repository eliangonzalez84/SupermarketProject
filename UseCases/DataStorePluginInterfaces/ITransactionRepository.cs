using System;
using System.Collections.Generic;
using Transaction = CoreBusiness.Transaction;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> GetByDay(DateTime date);
        public void Save(string cashierName, int productId, double price, int qty);
    }
}
