Console.WriteLine("Guess The Secret Number!");
int secretNumber = 42;

int guess;
int tries = 4;

//Console.WriteLine($"Your guess: {guess}");
bool success = false;
while (tries > 0 && success == false)
{
    Console.WriteLine("Your guess:");

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
    tries -= 1;
}

