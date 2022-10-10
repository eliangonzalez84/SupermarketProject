using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;
using Transaction = CoreBusiness.Transaction;

namespace Plugins.DataStore.InMemory
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<Transaction> transactions;
        public TransactionRepository()
        {
            transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return transactions;
            else
                return transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase)
                                            && x.TimeStamp.Date == date.Date);
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty)
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
                ProductName = productName,
                Price = price,
                BeforeQty = beforeQty,
                SoldQty = soldQty,
                TimeStamp = DateTime.Now,
                TransactionId = transactionId,
                CashierName = cashierName
            });
        }
    }
}
