// the list of words
string[,] word = {
{ "h", "a", "t", "e" },
{ "l", "i", "k", "e" },
{ "c", "o", "d", "e" },
{ "w", "o", "r", "d" },
{ "b", "o", "o", "k" },
{ "t", "i", "m", "e" },
{ "l", "o", "v", "e" },
{ "g", "a", "m", "e" },
{ "h", "o", "p", "e" },
{ "p", "l", "a", "y" },
{ "r", "e", "a", "d" },
{ "w", "i", "n", "d" },
{ "f", "i", "r", "e" },
{ "c", "a", "r", "d" },
{ "s", "t", "a", "r" },
{ "m", "o", "o", "n" },
{ "s", "n", "o", "w" },
{ "r", "a", "i", "n" },
{ "s", "u", "n", "s" },
{ "s", "a", "n", "d" },
{ "g", "o", "l", "d" },
{ "r", "i", "n", "g" },
{ "h", "a", "n", "d" },
{ "f", "o", "o", "d" },
{ "c", "a", "k", "e" },
{ "m", "i", "l", "k" },
{ "t", "e", "a", "m" },
{ "w", "o", "r", "k" },
{ "p", "a", "r", "k" },
{ "t", "r", "e", "e" },
{ "l", "e", "a", "f" },
{ "r", "o", "a", "d" },
{ "c", "i", "t", "y" },
{ "t", "o", "w", "n" },
{ "f", "a", "c", "e" },
{ "n", "a", "m", "e" },
{ "d", "a", "t", "e" },
{ "y", "e", "a", "r" },
{ "h", "o", "m", "e" },
{ "r", "o", "o", "m" },
{ "d", "o", "o", "r" },
{ "w", "a", "l", "l" },
{ "d", "e", "s", "k" },
{ "c", "h", "a", "i" },
{ "s", "e", "a", "t" },
{ "l", "a", "m", "p" },
{ "b", "e", "l", "l" },
{ "c", "o", "r", "e" },
{ "p", "a", "g", "e" },
{ "t", "e", "x", "t" },
{ "s", "o", "n", "g" },
{ "b", "a", "n", "d" },
{ "v", "o", "i", "c" },
{ "m", "u", "s", "e" },
{ "n", "o", "t", "e" },
{ "b", "e", "a", "t" },
{ "c", "o", "l", "d" },
{ "h", "e", "a", "t" },
{ "w", "a", "v", "e" },
{ "f", "r", "e", "e" },
{ "k", "i", "n", "g" },
{ "q", "u", "e", "e" },
{ "l", "o", "r", "d" },
{ "l", "a", "d", "y" },
{ "m", "a", "n", "y" },
{ "s", "o", "m", "e" },
{ "m", "o", "r", "e" },
{ "l", "e", "s", "s" },
{ "m", "a", "k", "e" },
{ "t", "a", "k", "e" },
{ "g", "i", "v", "e" },
{ "s", "a", "v", "e" },
{ "s", "e", "n", "d" },
{ "c", "a", "l", "l" },
{ "t", "a", "l", "k" },
{ "w", "a", "l", "k" },
{ "r", "u", "n", "s" },
{ "j", "u", "m", "p" },
{ "s", "i", "t", "s" },
{ "s", "t", "o", "p" },
{ "g", "o", "e", "s" },
{ "p", "l", "a", "n" },
{ "i", "d", "e", "a" },
{ "t", "e", "s", "t" },
{ "q", "u", "i", "z" },
{ "s", "h", "o", "w" },
{ "p", "r", "o", "j" },
{ "c", "a", "s", "e" },
{ "m", "a", "p", "s" },
{ "d", "a", "t", "a" },
{ "l", "i", "n", "k" },
{ "l", "i", "s", "t" },
{ "f", "i", "l", "e" },
};

// game loop
while (true)
{
    // importing random class
    Random random = new Random();
    int choice = random.Next(1, 100);

    // variables
    bool win = false;
    string a = "_";
    string b = "_";
    string c = "_";
    string d = "_";
    int chance = 6;

    // letters
    string a_a = word[choice, 0];
    string b_b = word[choice, 1];
    string c_c = word[choice, 2];
    string d_d = word[choice, 3];

    // welcome message
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Welcome to Wordle!");
    Console.WriteLine("You have 6 chances to guess the 4 letter word.");
    Console.WriteLine("Good luck!");

    
    while (chance > 0)
    {
        
        chance = chance - 1;
        Console.WriteLine();
        Console.WriteLine(" " + a + " " + b + " " + c + " " + d + " ");
        Console.WriteLine("Enter your guess: ");
        string decision = Console.ReadLine();

        if (decision == a_a)
        {
            a = a_a;
        }
        else if (decision == b_b)
        {
            b = b_b;
        }
        else if (decision == c_c)
        {
            c = c_c;
        }
        else if (decision == d_d)
        {
            d = d_d;
        }
        else
        {
            Console.WriteLine("Wrong guess!");
        }


        if (a == a_a && b == b_b && c == c_c && d == d_d)
        {
            Console.WriteLine("Congratulations! You guessed the word! The word was " + a_a + b_b + c_c + d_d);
            win = true;
            break;
        }
        else
        {
            Console.WriteLine("You have " + chance + " chances left.");
            win = false;
        }
        if (chance == 0)
        {
            break;
        }


    }

    if (win == false)
    {
        Console.WriteLine("Sorry, you ran out of chances. The word was " + a_a + b_b + c_c + d_d);
    }
    else
    {
        Console.WriteLine("You won with " + (chance) + " chances left.");
    }
    win = false;
}
