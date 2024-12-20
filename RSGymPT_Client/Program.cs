using System;
using AppUtility;
using RSGymPT.Classes;
using RSGymPT_Client.Repository;

namespace RSGymPT_Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            try
            {
                // Dados iniciais:
                // É suposto ser executado apenas uma vez

                #region Starting Data
                UserRepository.StartingUsers();
                LocationRepository.StartingLocations();
                PersonalTrainerRepository.StartingPersonalTrainers();
                ClientRepository.StartingClients();
                RequestRepository.StartingRequests();
                #endregion Starting Data

                LoginMenu.FirstMenu();
            }
            catch (Exception)
            {
            }

            Utility.TerminateConsole();
        }
    }
}