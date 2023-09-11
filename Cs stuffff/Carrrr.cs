namespace Cs_stuffff
{
public class Carrrr
{
    private static string brand = "mazda";
    private static string model = "mx-5";
    private static int year = 1993;
    private static string colour = "red";

    private string licence_plate = "mzdfl";
    private int hp = 180;
    private int milliadge = 15000;
    private int transmission = 0; // 0 - mechanical, 1 - automatic
    private static float speed = 0;

    public void Details()
    {
        Console.WriteLine(Carrrr.brand, Carrrr.model, Carrrr.year, Carrrr.colour);
    }

    public void Motion(float speed)
    {
        Carrrr.speed += Convert.ToSingle(Console.ReadLine());
    }
}
}