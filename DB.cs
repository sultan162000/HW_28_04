using System;
using System.Collections.Generic;

namespace HW_28_04_2020
{
    public class DB
    {

        public List<Client> clients = new List<Client>();
        public DB(Client client)
        {
            clients.Add(client);
        }

        public void Insert(decimal balance)
        {
            if (balance > 0)
            {
                clients[0].balance = balance;
            }
            else System.Console.WriteLine("Неверное сумма.");

        }

        public void Update(decimal balance)
        {
            System.Console.WriteLine("1.Добавить\n2.Взять");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:

                    clients[0].balance += balance;
                    break;
                case 2:

                    clients[0].balance -= balance;
                    break;

            }

        }

        public void Select()
        {
            Console.WriteLine("Полное имя = {0}, Сумма = {1}", clients[0].FullName, clients[0].balance);
        }

        public void Delete(Client c)
        {
            clients.Remove(c);
        }



    }
}