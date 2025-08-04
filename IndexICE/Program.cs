namespace IndexICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create on eobject of class Dog 225/65/18

            Fish snoek = new Fish(2, 5, "winter", "Tiger");
            new Fish(1, 2, "summer", "marlin");
            //output all values using int index and string index
            Console.WriteLine(snoek[0]);
            Console.WriteLine(snoek[1]);

            Console.WriteLine("Length: " + snoek["lenghth"] + "m");
            Console.WriteLine("Weight: " + snoek["fishWheight"] + "kg");
            Console.WriteLine("Season: " + snoek["season"]);
            Console.WriteLine("Species: " + snoek["fishSpecies"]);
        }
    }
}
