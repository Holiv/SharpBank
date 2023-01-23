using System;
using System.Linq;
using SharpBank.DataLayer.DataRecords;

namespace SharpBank
{
	public class Model
	{
        //public Model()
        //{
        //}
        Management Management = new Management();
        int userSelection;

        public void Init()
        {
            try
            {
                do
                {
                    Console.WriteLine("Selecione a opção desejada");
                    Console.WriteLine("1 - Login");
                    Console.WriteLine("2 - Criar Conta Pessoa Fisica");
                    Console.WriteLine("3 - Criar Conta Pessoa Juridica");
                    Console.WriteLine("0 - Fechar Aplicação");
                    userSelection = int.Parse(Console.ReadLine());

                    var userOptions = new[] { 1, 2, 3, 0 };

                    if(!userOptions.Contains(userSelection))
                    {
                        //Console.WriteLine("Opção Inválida");
                        throw new Exception();
                    };

                    switch (userSelection)
                    {
                        case 1:
                            Management.Login();
                            break;
                        case 2:
                            Management.CreatePFClient();
                            break;
                        case 3:
                            Management.CreatePJClient();
                            break;
                        case 0: break;
                    }
                }
                while (userSelection != 0);


            }
            catch
            {
                Console.WriteLine("Opção Invalida");
                this.Init();
            }

        }
        //public void FillData(Tuple<string, string, int> clientData)
        //{
        //    ClientPFDataRecord client = new ClientPFDataRecord(clientData.Item1, clientData.Item2, clientData.Item3);
        //}

        //public void FillData(Tuple<string, int> clientData)
        //{
        //    ClientPJDataRecord client = new ClientPJDataRecord(clientData.Item1, clientData.Item2);
        //}
    }
}

