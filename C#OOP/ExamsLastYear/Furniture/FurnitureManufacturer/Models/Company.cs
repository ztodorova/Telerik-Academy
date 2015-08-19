using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                //if (string.IsNullOrEmpty(value) || value.Length <= 5)
                   // throw new ArgumentException("Name cannot be empty, null or with less than 5 symbols!");

                this.name = value;
            }

        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber;}
            protected set
            {
                //if (value.Length != 10 || !OnlyDigits(value))
              //  {
               //     throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits");
               // }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get;
            protected set;
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} - {1} - {2} {3}",
            this.Name,
            this.RegistrationNumber,
            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
            this.Furnitures.Count != 1 ? "furnitures" : "furniture");
            builder.AppendLine();
            var sortedFurniture = this.Furnitures.OrderBy(x=>x.Price).ThenBy(x=>x.Model);
            foreach (var item in sortedFurniture)
	{
		 builder.AppendLine(item.ToString());
	}
            return builder.ToString().Trim();

        }

        private bool OnlyDigits(string text)
        {
            foreach (var symbol in text)
            {
                if(!char.IsDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
