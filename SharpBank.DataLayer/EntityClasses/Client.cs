using System;
using System.Text;
using SharpBank.DataLayer.DataRecords;

namespace SharpBank.DataLayer.EntityClasses
{
	public class Client
	{
		protected decimal Saldo { get; set; }
		protected decimal Credito { get; set; }
		protected int Agencia { get; set; }
		protected int Conta { get; set; }
		protected int Senha { get; set; }		

		public Client()
		{

		}

		public decimal Deposit(decimal deposit)
		{
			 return Saldo += deposit;
		}

		public decimal Saque(decimal saque)
		{
			return Saldo -= saque;
		}

		public virtual decimal Transferencia(decimal transferencia)
		{
			return Saldo -= transferencia;
		}

		public virtual decimal Emprestimo(decimal emprestimo)
		{
			return Saldo += emprestimo;
		}
    }
}

