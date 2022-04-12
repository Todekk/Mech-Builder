namespace Creational_Pattern
{
    class Program
    {
        static void Main()
        {
            MechBuilder builder;
            Director director = new Director();

            Console.WriteLine("Pick a Mech");
            Console.WriteLine("Defensive, Offensive or Balanced ");

            string userResponse = Console.ReadLine();

            switch(userResponse.ToLower())
            {
                case "offensive":
                    builder = new OffensiveMechBuilder();
                    director.Construct(builder);
                    builder.Mech.Present();
                    break;
                case "defensive":
                    builder = new DefensiveMechBuilder();
                    director.Construct(builder);
                    builder.Mech.Present();
                    break;
                case "balanced":
                    builder = new BalancedMechBuilder();
                    director.Construct(builder);
                    builder.Mech.Present();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            
        }
    }
}
