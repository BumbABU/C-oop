using OOP.OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        May may1 = new May();
        may1.id = "001";
        may1.name = "may cua hoang";
        may1.brand = "acer";
        may1.color = "black";

        DateTime nsxmay1 = new DateTime(2022, 1, 5);
        may1.NSX = nsxmay1;
        // may1.xuatdl();
        May.xuatdl2(may1);

        May may2 = new May();
        may2.xuatdl();

        May may3 = new May("EE", "ww", "QQ", "QWeqwe");
        may3.xuatdl();

         Sliptick Son1= new Sliptick("001","Son1 of Hoang","YSL", "red", new DateTime(2008,5,9));
          Son1.XuatSliptick();
        
        //Son 2 

        Sliptick Son2 = new Sliptick();
        Son2.setID("0009");
        Son2.XuatSliptick();

        // Son 3

        Sliptick Son3 = new Sliptick("00112", "Son moi cao cap", "YSL", "Black", new DateTime(2009, 4, 5));
        Console.WriteLine(Son3);
        
    }
}