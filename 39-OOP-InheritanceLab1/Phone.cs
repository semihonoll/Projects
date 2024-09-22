using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_InheritanceLab1
{
    public class Phone
    {
		//Fields
		private string brand;
		protected string phoneType;
		protected string connectionType;

		//Constructors
		public Phone()
		{
			phoneType = "Ahizeli Telefon";
		}

		public Phone(string brand, string connectionType)
        {
			this.brand = brand;
			this.connectionType = connectionType;
			phoneType = "Ahizeli Telefon";
        }

		//Properties
        public string ConnectionType 
		{
			get { return connectionType; }
			set { connectionType = value; }
		}

        public string PhoneType
		{
			get { return phoneType; }
			//set { phoneType = value; }
		}

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		//Methods
		public virtual string Call() 
		{
			return "Telefon Çalıyor...";
		}

		public virtual string ConnectionStatus()
		{
			return "Kablolo bağlantısı mevcut...";
		}

	}
}
