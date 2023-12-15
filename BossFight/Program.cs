namespace BossFight
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Hero = new GameCharacter("hero", 100, 20, 40);
            var Boss = new GameCharacter("boss", 400, RandomNumber(0, 31), 10);

            while(!Hero.isDead(Hero, Boss) && !Boss.isDead(Boss, Hero))
            {
                Hero.Fight(Hero, Boss);
                Boss.Fight(Boss, Hero);
                Console.WriteLine();
            }
        }

        public static int RandomNumber(int minimum, int maximum)
        {
            var random = new Random();
            return random.Next(minimum, maximum);
        }
    }
}
