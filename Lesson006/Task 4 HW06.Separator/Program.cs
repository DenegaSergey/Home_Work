using System;

namespace Task4HW06.Separator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "Не жалею, не зову, не плачу,;Все пройдет, как с белых яблонь дым.;Увяданья золотом охваченный,;Я не буду больше молодым.;";
            {
                string[] splitedArray = userInput.Split(';');
                string poemLine = "";
                for (int i = 0; i < splitedArray.Length; i++)
                {
                    poemLine += (splitedArray[i] + "\n").Trim(' ').Replace('о', 'а');
                }
                Console.WriteLine(poemLine);
            }
            {
                string[] splitedArray = userInput.Split(' ', ';');
                string poemColumn = "";
                for (int i = 0; i < splitedArray.Length; i++)
                {
                    poemColumn += (splitedArray[i] + "\n").Trim(' ').Replace('о', 'а');
                }
                Console.WriteLine(poemColumn);
            }
            Console.ReadKey();
        }
    }
}
