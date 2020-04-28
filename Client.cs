using System;
using System.Collections.Generic;

namespace HW_28_04_2020
{
    public class Client
    {
        public int Id{get;set;}
        public string FullName{get;set;}
        public Dictionary<int,decimal> schet = new Dictionary<int, decimal>();
        public Client(int id, string FullName)
        {
            this.Id = id;
            this.FullName=FullName;
        }
    }
}