namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            NPC Pupa = new NPC("Pupa")
            {
                Hitpoints = 50,
                Weight = 60,
                //cut Healpoints
                Damagepoints = 1

            };

            Item Backpack = new Item("Backpack")
            {
                Hitpoints = 5,
                Weight = 2,
                //cut Healpoints
                Damagepoints = 0
            };

            Weapon Knife = new Weapon("Knife")
            {
                Hitpoints = 3,
                Weight = 1,
                //cut Healpoints
                Damagepoints = 15
            };

            HealItem FirstAidKit = new HealItem("FirstAidKit")
            {
                Hitpoints = 10,
                Weight = 2,
                Healpoints = 15,
            };

            Console.WriteLine(Pupa.Name) ;

            Console.WriteLine(Pupa.Hitpoints);

            Pupa.GetDamage(Knife.Damagepoints);

            Console.WriteLine(Pupa.Hitpoints);

            Pupa.GetHeal(FirstAidKit.Healpoints);

            Console.WriteLine(Pupa.Hitpoints);

            Console.ReadKey();


















        }
    }
}
