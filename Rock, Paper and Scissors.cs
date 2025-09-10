
Console.WriteLine("You have 5 attempts");
int point = 0;
for (int i=1; i <= 5; i = i + 1)
{
    Random random = new Random();
    int comp_guise = random.Next(1,4);
    
    string choise = "error";

    if (comp_guise == 1) 
    {
        choise = "Rock";
    }
    else if (comp_guise == 2) 
    {
        choise = "Paper";
    }
    else
    {
        choise = "Scisors";
    }
    
    Console.WriteLine("Enter your choise from Rock Paper Scisors");
    string decision = Console.ReadLine();

    if (choise == decision)
    {
        Console.WriteLine("Draw");
    }
    else if (choise == "Scisors" && decision == "Rock" || choise == "Paper" && decision == "Scisors" || choise == "Rock" && decision == "Paper")
    {
        Console.WriteLine("You Win");
        point = point + 1;
    }
    else
    {
        Console.WriteLine("You lost");
    }
}
Console.WriteLine("You won " + point + " times");