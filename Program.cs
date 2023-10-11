namespace NumberAnalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool want2Continue = true;
            int usrNumber = 0;
            Console.Write("What is your name? ");
            string yourNameIs = Console.ReadLine();
            if (string.IsNullOrEmpty(yourNameIs))
            {
                yourNameIs = "Unknown";
                Console.WriteLine("Your name has been set to: Unknown.");
            }
            while (want2Continue == true)
            {
                bool validNumber = false;
                while (!validNumber)
                {
                    Console.Write($"{yourNameIs}, please enter a number between 1 and 100: ");
                    string inputNumber = Console.ReadLine();
                    if (int.TryParse(inputNumber, out usrNumber) && usrNumber >= 1 && usrNumber <= 100)
                    {
                        validNumber = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{yourNameIs}, you entered an invalid number, please try again!!");
                    }
                }

                if (usrNumber % 2 == 0)
                {
                    if (usrNumber >= 2 && usrNumber <= 24) 
                    {
                        Console.WriteLine($"{yourNameIs} you chose {usrNumber}, which is Even and less than 25.");
                    }
                    else if (usrNumber >= 26 && usrNumber <= 60)
                    {
                        Console.WriteLine($"{yourNameIs} you chose {usrNumber}, which is Even and between 26 and 60 inclusive.");
                    }
                    else 
                    {
                        Console.WriteLine($"{yourNameIs} you chose {usrNumber}, which is Even and greater than 60.");
                    }
                }
                else
                {
                    if (usrNumber < 60)
                    {
                        Console.WriteLine($"{yourNameIs} you chose {usrNumber}, which is Odd and less than 60.");
                    }
                    else 
                    {
                        Console.WriteLine($"{yourNameIs} you chose {usrNumber}, which is Odd and greater than 60.");
                    }
                }

                bool validAnswer = false;
                string usrAnswer = "";
                while (!validAnswer)
                {
                    Console.Write($"{yourNameIs}. Do you want to continue? Y/N: ");
                    usrAnswer = Console.ReadLine();
                    if (string.IsNullOrEmpty(usrAnswer) || (usrAnswer.ToUpper() != "Y" && usrAnswer.ToUpper() != "N"))
                    {
                        Console.WriteLine($"{yourNameIs}, please enter Y or N as answer.");
                    }
                    else
                    {
                        validAnswer = true;
                        break;
                    }
                }
                want2Continue = (usrAnswer.ToUpper() == "Y");
            }
        }
    }
}