using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ClientManager
    {
        public void AddClient(Client clients) {
            Console.WriteLine("EKLENEN MÜVEKKİL");
            Console.WriteLine("Müvekkil İsmi :" + clients.ClientNameSurname + " " + "(Eklendi)" );
            Console.WriteLine("---------------------------");
        }

        public void RemoveClient(Client clients) {
            Console.WriteLine("SİLİNEN MÜVEKKİL");
            Console.WriteLine("Müvekkil İsmi :" + clients.ClientNameSurname + " " + "(Silindi)");
            Console.WriteLine("----------------------------");
        }

        public void TrialDate (Client clients) {
            Console.WriteLine("DURUŞMA GÜNÜ");
            Console.WriteLine("Müvekkil İsmi :" + clients.ClientNameSurname);
            Console.WriteLine("Duruşma Günü :" + clients.TrialDate);
            Console.WriteLine("----------------------------");
        }
        public void ListClients (Client client) {
          //  Console.WriteLine("MÜVEKKİL LİSTESİ");
            Console.WriteLine("Müvekkil Adı : " + client.ClientNameSurname);
            Console.WriteLine("İletişim Numarası : " + client.ClientPhoneNumber);
            Console.WriteLine("Duruşma Günü : " + client.TrialDate);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        
    }
   }
