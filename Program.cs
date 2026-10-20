Console.WriteLine("Guess The Secret Number!");

Random random = new Random();
int secretNumber = random.Next(1, 101);

int guess;
int triesAllowed;
int currentTries = 0;
string message = "";

Console.WriteLine(@"Choose a Difficulty Level:
1. Easy
2. Medium
3. Hard");
string difficulty;

while (true)
{
    difficulty = Console.ReadLine();
    if (difficulty == "1")
    {
        triesAllowed = 8;
        break;
    }
    else if (difficulty == "2")
    {
        triesAllowed = 6;
        break;
    }
    else if (difficulty == "3")
    {
        triesAllowed = 4;
        break;
    }
    else
    {
        Console.WriteLine("Enter a valid option");
    }
}

bool success = false;
while (currentTries < triesAllowed && success == false)
{
    Console.WriteLine($"You have {triesAllowed - currentTries} guess(es) left");
    Console.WriteLine($"Your guess{(currentTries > 0 ? $"({currentTries + 1})>" : ">")}");
    
    while (!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.WriteLine("Enter a valid response");
    }

    if (guess == secretNumber)
    {
        Console.WriteLine("You guessed right");
        success = true;
    }
    else
    {
        if (guess > secretNumber && (guess - secretNumber) >= 10)
        {
            message = "Your guess was too high";
        }
        else if (guess < secretNumber && (secretNumber - guess) >= 10)
        {
            message = "Your guess was too low";
        }
        else if (guess > secretNumber)
        {
            message = "Your guess was high";
        }
        else if (guess < secretNumber)
        {
            message = "Your guess was low";
        }
        Console.WriteLine(@$"Wrong guess.{message}");
    }
    currentTries += 1;
}

Console.WriteLine((success ? "" : $"The secret number is {secretNumber}, better luck next time!"));

