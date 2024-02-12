namespace Arithmetic_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int noOfQuestions = random.Next(5, 16);
            int score = 0;

            Console.WriteLine("Arithmetic Quiz\n");

            for(int i = 1; i <= noOfQuestions; i++)
            {
                char[] operators = {'+','-','*','/'};
                char op = operators[random.Next(operators.Length)];
                int operand1 = random.Next(11);
                int operand2;
                if (op == '/')
                {
                    operand2 = random.Next(1, 11);
                }
                else
                {
                    operand2 = random.Next(11);
                }

                Console.Write($"Question {i}: What is {operand1} {op} {operand2}?\nYour answer: ");

                Boolean isValid;
                int userAnswer;
                int answer = 0;

                do
                { 
                    isValid = int.TryParse(Console.ReadLine(), out userAnswer);

                    if (!isValid)
                    {
                        Console.Write($"\nInvalid Input. Your answer must be a valid integer.\n\nQuestion {i}: What is {operand1} {op} {operand2}?\nYour answer: ");
                    }

                } while (!isValid);

                switch (op)
                {
                    case '+':
                        answer = operand1 + operand2;
                        break;
                    case '-':
                        answer = operand1 - operand2;
                        break;
                    case '*':
                        answer = operand1 * operand2;
                        break;
                    case '/':
                        answer = operand1 / operand2;
                        break;
                }

                if (answer == userAnswer)
                {
                    Console.WriteLine($"Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is {answer}.\n");
                }
            }

            Console.WriteLine($"Results:\nTotal Correct Answers: {score}");
            int percentage = (int)(((float)score / noOfQuestions) * 100);
            Console.WriteLine($"Percentage of Correct Answers: {percentage}%");
        }
    }
}
