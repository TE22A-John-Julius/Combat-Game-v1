int Health1 = 100;
int Health2 = 100;

//randomizer

Random generator = new Random();

int randonumber = 6 + generator.Next(11);
//characters
Console.WriteLine("Please State your name player:");
string name = Console.ReadLine().ToLower();
Console.WriteLine($"Welcome to HyperBattles {name} press enter to commence the fight!");
Console.ReadLine();
Console.WriteLine("You have entered the battle");
Console.ReadLine();

//coinflip
Random coinflips = new Random();
int coinflip = coinflips.Next(1,3);

Console.WriteLine("To determine who goes first we will do a coinflip, you may chose H or T");
string flip =Console.ReadLine().ToLower();
int H = 1;
int T = 2;
int right;
right == coinflip;
//while loop

Console.ReadLine();