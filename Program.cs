using System;

namespace HW_28_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Full name: ");
            Client newClient = new Client(1,Console.ReadLine());
            DB testDb = new DB(newClient);
            testDb.Insert(200000);
            testDb.Select();
        }
    }
}
