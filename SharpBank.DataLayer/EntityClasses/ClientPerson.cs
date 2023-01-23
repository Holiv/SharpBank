using System;
using System.Text;
using SharpBank.DataLayer.DataRecords;

namespace SharpBank.DataLayer.EntityClasses
{
	public class ClientPerson : Client
	{
        protected ClientPFDataRecord ClientPFDataRecord { get; set; }

        public ClientPerson(ClientPFDataRecord clientData, decimal depositoInicial, int senha)
		{
            ClientPFDataRecord = clientData;
            Saldo = depositoInicial;
            Senha = senha;
		}

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(ClientPFDataRecord.FirstName);
            str.Append(ClientPFDataRecord.LastName);
            str.Append(Agencia);
            str.Append(Conta);
            return str.ToString();
        }

    }
}

