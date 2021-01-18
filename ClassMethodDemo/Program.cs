using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.ClientNameSurname = "Mert Özdemir";
            client1.ClientPhoneNumber = "9322525252";
            client1.TrialDate = "18.01.2021";
            client1.ClientId = 55555;

            Client client2 = new Client();
            client2.ClientNameSurname = "Tarık Toprak";
            client2.ClientPhoneNumber = "9322525253";
            client2.TrialDate = "14.02.2021";
            client2.ClientId = 66666;

            Client client3 = new Client();
            client3.ClientNameSurname = "Akif Bulut";
            client3.ClientPhoneNumber = "9322525254";
            client3.TrialDate = "03.03.2021";
            client3.ClientId = 77777;

            Client[] clients = new Client[] {client1, client2, client3 };

            foreach (var client in clients)
            {
                //Console.WriteLine(client.ClientNameSurname);
            }

            ClientManager clientManager = new ClientManager();
            clientManager.AddClient(client1);
            clientManager.RemoveClient(client2);
            clientManager.TrialDate(client3);

            
            
        }
    }
}
