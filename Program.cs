using System.Reflection;
using static System.Console;

namespace ApplyingAttributes
{
    class Program
    {
        static void Main()
        {
            HorseAndBuggy mule = new HorseAndBuggy();
            mule.GetType();

            Motorcycle motorcycle = new Motorcycle() 
            { 
                weightOfCurrentPassengers = 150.5F,

            };

            FieldInfo[] motorcycleInfo = motorcycle.GetType().GetFields();

            foreach (FieldInfo f in motorcycleInfo)
                WriteLine(f.Name + ": " + f.GetValue(motorcycle));
        }
    }
}
