
//randomizer

Random generator = new Random();

int randonumber = 6 + generator.Next(10);

Console.WriteLine(randonumber);

//while loop

while (randonumber > 0)
{
    Console.WriteLine(randonumber);
    randonumber += randonumber;
}

Console.ReadLine();
