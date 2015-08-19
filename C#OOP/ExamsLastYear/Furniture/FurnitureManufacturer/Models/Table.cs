﻿using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {
        private decimal area;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height )
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length {get; protected set;}
        
        public decimal Width {get; protected set;}

        public decimal Area
        {
            get { return this.Length * this.Width; }
            protected set { this.area = value;}
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);
        }
        
    }
}
