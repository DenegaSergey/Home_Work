 using System;

namespace Task1HW07.StringWorkerTwo
{
    internal class Program
    {
        static void WordReplacement(string[] arreyWords, string longWord, string shortestWord)
        {
            int indexMaxWord = Array.IndexOf(arreyWords, longWord);
            int indexMinWord = Array.IndexOf(arreyWords, shortestWord);

            Console.WriteLine(" Min index: " + indexMaxWord); //10
            Console.WriteLine(" Max index: " + indexMinWord + "\n"); //6

            string temp = arreyWords[10];
            arreyWords[10] = arreyWords[6];
            arreyWords[6] = temp;

            {
                int index = Array.IndexOf(arreyWords, longWord);

                for (int i = index; i < arreyWords.Length - 1; i++)
                {
                    arreyWords[i] = arreyWords[i + 1];
                }
                Array.Resize(ref arreyWords, arreyWords.Length - 1);
                Console.WriteLine(String.Join(" ", arreyWords) + "\n");
            }
        }
        static string ShortestWord(string[] arreyWords)
        {
            string shortestWord = arreyWords[0];
            int smallestLength = arreyWords[0].Length;
            for (int i = 0; i < arreyWords.Length; i++)
            {
                if (arreyWords[i] != "" && arreyWords[i].Length < smallestLength)
                {
                    smallestLength = arreyWords[i].Length;
                    shortestWord = arreyWords[i];
                }
            }
            Console.WriteLine("Shortest word: " + shortestWord + "\n");
            return shortestWord;
        }
        static string ArraySort(string userWords)
        {
            string[] arrey = userWords.Split(' ', ',', '.');

            foreach (var sub in arrey)
            {
                Console.WriteLine(sub);
            }

            Array.Sort(arrey, (x, y) => x.Length.CompareTo(y.Length));
            Array.Reverse(arrey);
            Console.WriteLine(String.Join(" ", arrey) + "\n");
            return userWords;
        }
        static string NumberOfLetters(string userWords)
        {
            int letters = 0;
            for (int i = 0; i < userWords.Length; i++)
            {
                if (char.IsLetter(userWords[i]))
                    letters++;
            }
            Console.WriteLine("The number of letters is: {0}", letters + "\n");
            return letters.ToString();
        }
        static string NumberOfPunctuation(string userWords)
        {
            int punctuationCount = 0;
            for (int i = 0; i < userWords.Length; i++)
            {
                if (Char.IsPunctuation(userWords[i]))
                    punctuationCount++;
            }
            Console.WriteLine("Number of punctuation marks: " + punctuationCount + "\n");

            return punctuationCount.ToString();
        }
        static string LongestWord(string[] arreyWords, string word)
        {
            int longestWord = 0;
            foreach (String s in arreyWords)
            {
                if (s.Length > longestWord)
                {
                    word = s;
                    longestWord = s.Length;
                }
            }
            Console.WriteLine("Longest word: " + word + "\n");
            return word;
        }

        static void Main(string[] args)
        {
            string userWords = "Всегда пишите код так, будто сопровождать его будет склонный к насилию психопат, который знает, где вы живете.";
            string[] arreyWords = userWords.Split(new[] { " ", ",", "." }, StringSplitOptions.None);
            string word = "";

            string longWord = LongestWord(arreyWords, word);
            string shortestWord = ShortestWord(arreyWords);

            WordReplacement( arreyWords,longWord,shortestWord);

            string punctuation = NumberOfPunctuation(userWords);
            string letters = NumberOfLetters(userWords);
            string sort = ArraySort(userWords);

            Console.ReadKey();

        }
    }
}
