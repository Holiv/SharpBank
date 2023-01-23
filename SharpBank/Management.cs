using System;
using SharpBank.DataLayer.DataRecords;
using SharpBank.DataLayer.EntityClasses;
using SharpBank.DataLayer.RepositoryClients;

namespace SharpBank
{
	public class Management
	{
		public Management()
		{
		}

        RepositoryClients repositoryClients = new();

        public void Login()
        {

        }

        //public void CriarConta()
        //{
        //    try
        //    {
        //        int userSelection;
        //        do
        //        {
        //            Console.WriteLine("Selecione o tipo de conta:");
        //            Console.WriteLine("1 - Pessoa Física");
        //            Console.WriteLine("2 - Pessoa Jurídica");
        //            Console.WriteLine("0 - Cancelar");

               
        //            userSelection = int.Parse(Console.ReadLine());

        //            var userOptions = new[] { 1, 2, 0 };
        //            userOptions.Contains(userSelection);
                  
               
        //            switch (userSelection)
        //            {
        //                case 1:
        //                    CreatePFClient();
        //                    break;
        //                case 2:
        //                    CreatePJClient();
        //                    break;
        //                case 0:
        //                    break;
        //                default:
        //                    Console.WriteLine("Opção Invalida");
        //                    break;
        //            }

        //        }
        //        while (userSelection is > 0 and < 3);
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Opção Invalida");
        //    }
            

        //}

        public void CreatePFClient()
        {
            string firstName;
            string lastName;
            double cpf;
            int senha;
            decimal depositoInicial;

            Console.WriteLine("Nome: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Sobrenome: ");
            lastName = Console.ReadLine();
            Console.WriteLine("CPF: ");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Crie uma Senha (6 digitos): ");
            senha = int.Parse(Console.ReadLine());
            Console.WriteLine("Deposito Inicial");
            depositoInicial = decimal.Parse(Console.ReadLine());


            ClientPFDataRecord clientRecord = new(firstName, lastName, cpf);
            ClientPerson client = new(clientRecord, depositoInicial, senha);
            repositoryClients.ClientPersonRepository.Add(client);
            Console.WriteLine(client);
        }

        public void CreatePJClient()
        {

        }
    }
}

