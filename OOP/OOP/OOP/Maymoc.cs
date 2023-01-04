using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOP
{
    internal class May
    {
        public string id;
        public string name;
        public string color;
        public string brand;
        public DateTime NSX;
        

       /* public May()
        {
            id = "000";
            name = "May 000";
            color = "default";
            brand = "???";
            NSX = new DateTime(2000, 1, 1);
        }*/
        public void xuatdl()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Color : " + color);
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("NSX" + NSX);
        }

        public static void xuatdl2 (May maytinh)
        {
            Console.WriteLine("ID : " + maytinh.id);
            Console.WriteLine("Name : " + maytinh.name);
            Console.WriteLine("Color : " + maytinh.color);
            Console.WriteLine("Brand : " + maytinh.brand);
            Console.WriteLine("NSX" + maytinh.NSX);
        }


        public May (string id ="string" , string name ="string", string brand = "string", string color = "string"/*, DateTime NSX*/)
        {
            this.id = id;
            this.name = name;
            this.brand = brand;
            this.color = color;
            /*
            this.NSX = NSX;*/
        }
        

        
    }
}
