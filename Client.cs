using System;
using System.Collections.Generic;

namespace HW_28_04_2020
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal balance{get;set;}
        public Client(int id, string FullName, decimal balance)
        {
            this.Id = id;
            this.FullName = FullName;
            this.balance = balance;
        }
    }
}