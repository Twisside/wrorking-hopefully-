//if this doesn't work (and it probably won't) the original file is .../Cs stuffff/Carrrr.cs

namespace Cs_stuffff
{
public class Carrrr
{
    private static string colour = "red";
    private static string state = "stationary"
    private static float speed = 0;

    public void Details()
    {
        Console.WriteLine(Carrrr.colour, Carrrr.state, Carrrr.speed);
    }

    public void Motion(float speed);
    {
        Carrrr.speed = Convert.ToSingle(Console.ReadLine());
        if(Carrrr.speed > 0)
        {
            Carrrr.state = "moving";
        }
        if(Carrrr.speed == 0)
        {
            Carrrr.state = "stationary";
        }
        if(Carrrr.speed < 0)
        {
            Console.WriteLine("That's not how reverse works...");
        }
    }
}
}

