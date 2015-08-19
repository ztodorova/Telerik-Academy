using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
   
    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string model, string material, decimal price, decimal height )
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;

        }

        public string Model
        {
            get { return this.model; }
            protected set
            {
              //  if(string.IsNullOrEmpty(value) || value.Length < 3)
                //{
                    //throw new ArgumentException("Model cannot be null, empty or less than three symbols!");
               // }
              this.model = value;
            }
        }

        public string Material
        {
            get;
           protected set;
        }

        public decimal Price
        {
            get { return this.price; }
            set {
               // if(value <= 0.0m)
               // throw new ArgumentException("Price cannot be less or equal to $0.00");

                this.price = value;
            }
            
        }

        public decimal Height
        {
            get { return this.height;}
            protected set
            {// if (value <= 0.0m)
           // {// throw new ArgumentException("Height cannot be less or equal to 0.00 m!"); }
            this.height = value; 
            }
        }
    }
}
