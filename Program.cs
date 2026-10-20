Console.WriteLine("Guess The Secret Number!");
int secretNumber = 42;

int guess;
int triesAllowed = 4;
int currentTries = 0;

//Console.WriteLine($"Your guess: {guess}");
bool success = false;
while (currentTries < triesAllowed && success == false)
{
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
        Console.WriteLine("Wrong guess. Try again");
    }
    currentTries += 1;
}

