

//characters
using System.Security.Cryptography;

int urhp = 100;
int enemyhp = 100;

Console.WriteLine("Please State your name player:");
string name = Console.ReadLine().ToLower();
Console.WriteLine($"Welcome to HyperBattles {name} press enter to commence the fight!");
Console.ReadLine();
Console.WriteLine("You have entered the battle");
Console.ReadLine();


//coinflip and loop
while (urhp > 0 && enemyhp > 0)
{
Code(name, ref urhp, ref enemyhp);
}

Console.ReadLine();













//methods


static void Code(string name, ref int urhp, ref int enemyhp)
{
    Random coinflips = new Random();
int coinflip = coinflips.Next(1,3);
 
Random generator = new Random();

int randonumber = 6 + generator.Next(11);


Console.WriteLine("To determine who goes first we will do a coinflip, you may chose 1 or 2 (1=heads and 2=tails)");
int choice = int.Parse(Console.ReadLine());

if (choice == coinflip)
{
  YouFirst(name, randonumber, ref enemyhp);
}
else if (choice != coinflip) 
{
    EnemyFirst(name, randonumber, ref urhp);
}
else 
{
    while (true)
    {
        Console.WriteLine("Sorry but you havent put in a viable answer, please  try again");
    }
}
}

static void YouFirst(string name, int randonumber, ref int enemyhp)
{
    YouGoFirst(name);
  Console.ReadLine();
  ApplyDamageToEnemy(randonumber, ref enemyhp);
}

static void EnemyFirst(string name, int randonumber, ref int urhp)
{
    EnemyGoFirst(name);
    Console.ReadLine();
    ApplyDamageToSelf(randonumber, ref urhp);
}

static void ApplyDamageToSelf(int damage, ref int urhp)
{
    urhp -= damage;
    Console.WriteLine($"Your enemy has done {damage} damage to you! You currently have {urhp} left!");
    Console.ReadLine();
}

static void ApplyDamageToEnemy(int damage, ref int enemyhp)
{
    enemyhp -= damage;
    Console.WriteLine($"You have done {damage} damage to your enemy! Your enemy currently has {enemyhp} left!");
    Console.ReadLine();
}

static void YouGoFirst(string name)
{
    Console.WriteLine($"Congrats {name} you get to go first! press enter to continue");
}

static void EnemyGoFirst(string name)
{
    Console.WriteLine($"Unfortunately {name} you were incorrect, your enemy goes first! press enter to continue");
}
