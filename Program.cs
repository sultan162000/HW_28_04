using System;
using System.Threading;

namespace HW_28_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Full name: ");
            string name = Console.ReadLine();
            System.Console.Write("Сколько сумму вы хотите перенести в кошелек?: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Client newClient = new Client(1, name, balance);
            opWithClient te = new opWithClient(newClient);
            

            
            bool checkUser = true;
            while (checkUser)
            {
                Thread.Sleep(1000);
                System.Console.Write("1.Операция с деньгами\n2.Посмотреть счет\n3.Удалить профиль\n4.Выход\n::");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                    System.Console.Write("Введите сумму: ");
                    te.client.Update(decimal.Parse(Console.ReadLine()));
                    break;
                    case 2:
                    te.client.Select();
                    break;
                    case 3:
                    te.client.Delete(newClient);
                    System.Console.WriteLine("Профиль удален!");
                    checkUser = false;
                    break;
                    case 4:
                    checkUser = false;
                    break;
                }
            }

        }
        public static void Run(opWithClient te)
        {
            decimal a = te.client.clients[0].balance;

            while(true){
                while(true){
                    if(te.client.clients[0].balance<a){
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("---ID: "+te.client.clients[0].Id+" До: "+a+" После: "+te.client.clients[0].balance);
                        a=te.client.clients[0].balance;
                        break;
                    }else if(te.client.clients[0].balance>a){
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("+++ID: "+te.client.clients[0].Id+" До: "+a+" После: "+te.client.clients[0].balance);
                        a=te.client.clients[0].balance;
                        break;
                    }
                }
            }



        }
    }

    public class opWithClient
    {
        public DB client = null;
        public opWithClient(Client client)
        {
            this.client = new DB(client);
        }
    }
}
