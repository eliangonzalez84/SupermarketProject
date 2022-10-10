using System;
using System.Collections.Generic;
using Transaction = CoreBusiness.Transaction;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> Get(string cashierName);
        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date);
        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime date);
        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty);
    }
}
