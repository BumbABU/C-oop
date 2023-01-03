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
        may1.xuatdl();
    }
}