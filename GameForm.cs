using GameForm;
using System;
using System.Windows.Forms;


namespace Myspace
{
    enum Attack
    {
        Physical,
        Magical
    };

    class Program
    {
        public static double mage1Health = 720;
        public static double warrior1Health = 1150;
        public static double archer1Health = 1000;

        public static double mage1Attack = 281;
        public static double warrior1Attack = 202;
        public static double archer1Attack = 225;

        public static double mage2Health = 720;
        public static double warrior2Health = 1150;
        public static double archer2Health = 1000;

        public static double mage2Attack = 291;
        public static double warrior2Attack = 202;
        public static double archer2Attack = 225;

        public static double player1Damage = 0;
        public static double player2Damage = 0;

        public static int choose = 1;
        public static int choose2 = 1;
        public static string countinue = "";
        public static int strategy = 1;


        public static int location = 4;

        public static string start = "y";
        public static int round = 1;

        public static Warrior warrior1 = new Warrior("Warrior", warrior1Health, warrior1Attack, 37, 30);
        public static Mage mage1 = new Mage("Mage", mage1Health, mage1Attack, 20, 25);
        public static Archer archer1 = new Archer("Archer", archer1Health, archer1Attack, 23, 25);

        public static Warrior warrior2 = new Warrior("Warrior", warrior2Health, warrior2Attack, 37, 30);
        public static Mage mage2 = new Mage("Mage", mage2Health, mage2Attack, 20, 25);
        public static Archer archer2 = new Archer("Archer", archer2Health, archer2Attack, 23, 25);

        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());

        }

        public static void chooseLocation()
        {
            if (location == 1)
            {
                archer1Attack += 30;
                mage1Attack += 25;
                warrior1Attack -= 20;

                archer2Attack += 30;
                mage2Attack += 25;
                warrior2Attack -= 20;
            }
            else if (location == 2)
            {
                warrior1Attack += 20;
                mage1Attack -= 15;
                archer1Attack -= 18;

                warrior2Attack += 20;
                mage2Attack -= 15;
                archer2Attack -= 18;
            }
            else if (location == 3)
            {
                warrior1Attack -= 28;
                mage1Attack += 25;
                archer1Attack += 20;

                warrior2Attack -= 28;
                mage2Attack += 25;
                archer2Attack += 20;
            }



        }

        public static string chooseHero()
        {
            string choosedHero = "";

            if (choose == 1)
            {

                choosedHero += "Mage attacks ";

            }
            else if (choose == 2)
            {
                choosedHero += "Warrior attacks ";

            }
            else if (choose == 3)
            {
                choosedHero += "Archer attacks ";

            }


            if (choose2 == 1)
            {
                choosedHero += "mage";

            }
            else if (choose2 == 2)
            {
                choosedHero += "warrior";

            }
            else if (choose2 == 3)
            {
                choosedHero += "archer";

            }
            return choosedHero;

        }

        public static double printHealth(double health, double damage)
        {
            health -= damage;

            if (health <= 0)
            {
                return 0;
            }
            return health;
        }

        public static bool lose(double health)
        {
            if (health == 0)
            {
                return true;

            }
            return false;
        }


        public static void reset()
        {
            mage1Health = 720;
            warrior1Health = 1150;
            archer1Health = 1000;

            mage1Attack = 281;
            warrior1Attack = 202;
            archer1Attack = 225;

            mage2Health = 720;
            warrior2Health = 1150;
            archer2Health = 1000;

            mage2Attack = 281;
            warrior2Attack = 202;
            archer2Attack = 225;

            player1Damage = 0;
            player2Damage = 0;
        }

    }
}
