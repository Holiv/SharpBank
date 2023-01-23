using System;
using SharpBank.DataLayer.EntityClasses;

namespace SharpBank.DataLayer.RepositoryClients
{
	public class RepositoryClients
	{
		public List<ClientPerson> ClientPersonRepository { get; set; }
		public List<ClientCompany> ClientCompanyRepository { get; set; }

		public RepositoryClients()
		{
			ClientPersonRepository = new();
			ClientCompanyRepository = new();
		}
		
		public void AddClientPerson(ClientPerson clientPerson)
		{
			ClientPersonRepository.Add(clientPerson);
		}

		public void AddClientCompany(ClientCompany clientCompany)
		{
			ClientCompanyRepository.Add(clientCompany);
		}

	}
}

