namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your favorite subject?");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "math":
                    Console.WriteLine("Math rocks!!!");
                    break;
                case "history":
                    Console.WriteLine("Nice! History is very interesting.");
                    break;
                case "science":
                    Console.WriteLine("Great! Science is great for research.");
                    break;
                case "english":
                    Console.WriteLine("Perfect! English will help you communicate effectively.");
                    break;
                case "dance":
                    Console.WriteLine("Fantastic! Dance is the best form of exercise.");
                    break;
                default:
                    Console.WriteLine($"You entered {answer}.");
                    break;
            }
        }
    }
}