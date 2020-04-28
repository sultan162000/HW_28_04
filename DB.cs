using System;
using System.Collections.Generic;

namespace HW_28_04_2020
{
    public class DB
    {
        private static int keys = 1;

        List<Client> clients = new List<Client>();
        public DB(Client client)
        {
            clients.Add(client);
        }

        public void Insert(decimal balance)
        {
            if (balance > 0)
            {
                clients[0].schet.Add(keys,balance);
                keys++;
            }
            else System.Console.WriteLine("Неверное сумма.");

        }

        public void Select()
        {
            foreach (KeyValuePair<int, decimal> kvp in clients[0].schet)
            {
                Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);
            }
        }

        public void Delete(int id){
            if(clients[0].schet.ContainsKey(id)){
                clients[0].schet.Remove(id);
            }else System.Console.WriteLine("Несуществующий счет.");
        }

    }
}