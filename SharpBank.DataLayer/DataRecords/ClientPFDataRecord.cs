using System;
namespace SharpBank.DataLayer.DataRecords
{
	public record ClientPFDataRecord(
		string FirstName,
		string LastName,
		double Cpf
		);
}

