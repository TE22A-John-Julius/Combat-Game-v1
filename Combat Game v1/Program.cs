

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

Console.WriteLine("To determine who goes first we will do a coinflip, you may chose 1 or 2 (1=heads and 2=tails)");
int choice = int.Parse(Console.ReadLine());

Random generator = new Random();

int randonumber = 6 + generator.Next(11);

if (choice == coinflip)
{
  YouGoFirst(name);
  Console.ReadLine();
  ApplyDamageToEnemy(randonumber);

}
else 
{
    EnemyGoFirst(name);
    Console.ReadLine();
    ApplyDamageToSelf(randonumber);
}


Console.ReadLine();


//methods


static void ApplyDamageToSelf(int damage)
{
    int urhp = 100;
    urhp -= damage;
    Console.WriteLine($"Your enemy has done {damage} damage to you!");
}

static void ApplyDamageToEnemy(int damage)
{
    int enemyhp = 100;
    enemyhp -= damage;
    Console.WriteLine($"You have done {damage} damage to your enemy!");
}

static void YouGoFirst(string name)
{
    Console.WriteLine($"Congrats {name} you get to go first! press enter to continue");
}

static void EnemyGoFirst(string name)
{
    Console.WriteLine($"Unfortunately {name} you were incorrect, your enemy goes first! press enter to continue");
}
