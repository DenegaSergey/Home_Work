using System;

namespace Task4HW06.Separator
{
    internal class Program
    {
        static void ShowPoemColumn(string poemColumn)
        {
            Console.WriteLine(poemColumn);
        }
        static string SubstitutionLetterColumn(string[] splitedArrayColumn)
        {
            string poemColumn = "";
            for (int i = 0; i < splitedArrayColumn.Length; i++)
            {
                poemColumn += (splitedArrayColumn[i] + "\n").Trim(' ').Replace('о', 'а');
            }
            return poemColumn;
        }
        static string[] SplitArreyByPunctuationColumn(string userInput)
        {
            string[] splitedArrayColumn = userInput.Split(' ', ';');
            return splitedArrayColumn;
        }
        static void ShowPoemLine(string poemLine)
        {
            Console.WriteLine(poemLine);
        }
        static string SubstitutionLetterLines(string[] splitedArrayLine)
        {
            string poemLine = "";
            for (int i = 0; i < splitedArrayLine.Length; i++)
            {
                poemLine += (splitedArrayLine[i] + "\n").Trim(' ').Replace('о', 'а');
            }
            return poemLine;
        }
        static string[] SplitByPunctuationLines(string userInput)
        {
            string[] splitedArrayLine = userInput.Split(';');
            return splitedArrayLine;
        }
        static void SplittingByWordsAndReplacingLetters(string userInput)
        {
            string[] splitedArray = userInput.Split(' ', ';');
            string poemColumn = "";
            for (int i = 0; i < splitedArray.Length; i++)
            {
                poemColumn += (splitedArray[i] + "\n").Trim(' ').Replace('о', 'а');
            }
            Console.WriteLine(poemColumn);
        }

        static void Main(string[] args)
        {
            string userInput = "Не жалею, не зову, не плачу,;Все пройдет, как с белых яблонь дым.;Увяданья золотом охваченный,;Я не буду больше молодым.;";

            string[] splitedArrayLine = SplitByPunctuationLines(userInput);
            string poemLine = SubstitutionLetterLines(splitedArrayLine);
            ShowPoemLine(poemLine);

            string[] splitedArrayColumn = SplitArreyByPunctuationColumn(userInput);
            string poemColumn = SubstitutionLetterColumn(splitedArrayColumn);
            ShowPoemColumn(poemColumn);

            Console.ReadKey();
        }
    }
}
