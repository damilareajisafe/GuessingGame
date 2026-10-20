Console.WriteLine("Guess The Secret Number!");
Random random = new Random();
int secretNumber = random.Next(1, 101);

int guess;
int triesAllowed = 4;
int currentTries = 0;
string message = "";
//Console.WriteLine($"Your guess: {guess}");
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

