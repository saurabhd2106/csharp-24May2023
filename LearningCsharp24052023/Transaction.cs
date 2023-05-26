﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    public class Transaction
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public Transaction(decimal amount, DateTime date, string comment)
        {
            Amount = amount;

            Date = date;

            Comments = comment;

        }
    }
}
