namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The player", Cash = 100 };

            Console.WriteLine("Welcome to the casino. The odds are " + odds);
            while (player.Cash>0)
            {
                player.WriteMyInfo();
                Console.WriteLine("How much do you want to bet?: ");
                if (int.TryParse(Console.ReadLine(),out int bet))
                {
                    int pot = player.GiveCash(bet);
                    pot *= 2;
                    int chance = random.Next(1);
                    if (chance>odds)
                    {
                        player.ReceiveCash(pot);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you lose");
                    }
                }
            }

        }
    }
}