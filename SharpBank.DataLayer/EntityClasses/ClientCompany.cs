using System;
using SharpBank.DataLayer.DataRecords;

namespace SharpBank.DataLayer.EntityClasses
{
	public class ClientCompany : Client
	{
        protected ClientPJDataRecord ClientPJDataRecord { get; set; }

        public ClientCompany()
		{
		}

        
    }
}

