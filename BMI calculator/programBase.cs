namespace BMI_calculator
{
    internal class programBase
    {
        static void Main(string[] args)
        {

            //deklararer de varibler behövs
            string namn, input;
            int alder;
            float langd, vikt;

            //om namn
            Console.WriteLine("Hej! Vad heter du?");
            namn = Console.ReadLine();
            Console.WriteLine("Hej! " + namn + ".");

            //om ålder
            Console.WriteLine("Hej!, Hur gammal är du?");
            input = Console.ReadLine();
            Int32.TryParse(input, out alder);
            Console.WriteLine("din alder är " + alder + ".");

            //om längd
            Console.WriteLine("Hur lång är du i cm?");
            langd = float.Parse(Console.ReadLine());
            Console.WriteLine("Din langd är " + langd + ".");

            //om vikt
            Console.WriteLine("skriva din vikt i kg");
            vikt = float.Parse(Console.ReadLine());
            Console.WriteLine("Ok din väger " + vikt + ".");
    }
}