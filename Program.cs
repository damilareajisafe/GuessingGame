Console.WriteLine("Guess The Secret Number!");
int secretNumber = 42;

Console.WriteLine("Your guess:");
int guess;
while(!int.TryParse(Console.ReadLine(), out guess))
{
    Console.WriteLine("Enter a valid response");
}
//Console.WriteLine($"Your guess: {guess}");
if (guess == secretNumber)
{
    Console.WriteLine("You guessed right");
}
else
{
    Console.WriteLine("Wrong guess");
}
