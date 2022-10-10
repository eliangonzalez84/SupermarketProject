using System;
using System.Collections.Generic;
using Transaction = CoreBusiness.Transaction;

namespace UseCases
{
    public interface IGetTransactionsUseCase
    {
        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }
}