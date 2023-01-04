using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOP
{
    internal class Sliptick 
    {
        public string ID;
        public string name;
        public string brand;
        public string color;
        public DateTime NSX;

        public Sliptick() {
            this.ID = "000";
            this.name = "name";
            this.brand = "noBrand";
            this.color= "Nocolor";
            this.NSX = new DateTime(2000, 1, 1);
        }

        public void XuatSliptick ()
        {
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : "+ name);
            Console.WriteLine("brand : " + brand);
            Console.WriteLine("Color : "+color);
            Console.WriteLine("NXS : " + NSX);
        }

        public Sliptick(string ID, string name, string brand, string color, DateTime NSX)
        {
            this.ID = ID;
            this.name = name;
            this.brand = brand;
            this.color = color;
            this.NSX = NSX;
        }

        // sử dùng hàm set get để tạo 1 đối tượng ( học cho biết th )

        public void setID (string ID) // hàm set
        {
            this.ID = ID;
        }

        public string getID() // hàm get
        {
            return this.ID;
        }

        public string NAME // thuộc tính NAME mới có set get
        {
            get { return this.name; }
            set { name = value; }
        } // đây là thuộc tính NAME để lấy name vì name là private ta dùng thuộc tính này bên hàm program tương tự

        public override string? ToString()
        {
            string s = "ID:" + ID + "\nName:" + name + "\nHieu:" + brand + "\nColor" + color + "\nNgaySX:" + NSX;
            return s;
        }


    }
}
