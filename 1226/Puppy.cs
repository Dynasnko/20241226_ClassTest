using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _1226
{
    internal class Puppy
    {
        public int Id { get; set; }  //puppy的ID,車牌
        public string Owner { get; set; }  //puppy主人的名字
        public string Description { get; set; } //關於這台puppy描述
        public double Price { get; set; } //這台puppy價格
        public string Brand { get; set; } //品種
        public double KG { get; set; }  //體重

        private bool _GG; //結奓
        public bool GG
        {
            get { return this._GG; }
            set { this._GG = value; }
        }

        //建構子函式1
        public Puppy() { }

        //建構子函式2 
        public Puppy(int id, string inOwner, string description, double price, string brand, double KKG, bool inGG)
        {
            Id = id;
            Owner = inOwner;
            Description = description;
            Price = price;
            Brand = brand;
            KG = KKG;
            GG = inGG;

        }

        public void CallMyPuppyName()
        {
            Console.WriteLine("ID is:　" + this.Id.ToString());
            Console.WriteLine("Owener is :　" + this.Owner.ToString());
            Console.WriteLine("Description is：　"+this.Description.ToString());
            Console.WriteLine("Price is：　"+this.Price.ToString());
            Console.WriteLine("Brand is：　"+this.Brand.ToString());
            Console.WriteLine("KG is：　"+this.KG.ToString());
            Console.WriteLine("GG yet?　"+this._GG.ToString());
            //類推..把所有屬性印出來.
        }
    }
}
