using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;
using Transaction = CoreBusiness.Transaction;

namespace Plugins.DataStore.InMemory
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {
        private List<Transaction> transactions;
        public TransactionInMemoryRepository()
        {
            transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> GetByDay(DateTime date)
        {
            return transactions.Where(x => x.TimeStamp == date);
        }

        public void Save(string cashierName, int productId, double price, int qty)
        {
            int transactionId = 0;
            if(transactions != null && transactions.Count > 0)
            {
                int maxId = transactions.Max(x => x.TransactionId);
                transactionId = maxId + 1;
            }
            else
            {
                transactionId = 1;
            }

            transactions.Add(new Transaction
            {
                ProductId = productId,
                Price = price,
                Qty = qty,
                TimeStamp = DateTime.UtcNow,
                TransactionId = transactionId,
                CashierName = cashierName
            });
        }
    }
}
