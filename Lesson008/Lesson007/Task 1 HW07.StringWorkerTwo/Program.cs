using System;

namespace Task1HW07.StringWorkerTwo
{
    internal class Programarre
    {
        static void ShowArreyResize(string[] arreyWords)
        {
            Console.WriteLine(String.Join(" ", arreyWords) + "\n");

        }
        static void ArreyResize(string[] arrayAfterDeletion)
        {
            Array.Resize(ref arrayAfterDeletion, arrayAfterDeletion.Length - 1);
        }
        static string[] DeletingLongWord(string[] arreyWords, string longWord)
        {
            int index = Array.IndexOf(arreyWords, longWord);

            for (int i = index; i < arreyWords.Length - 1; i++)
            {
                arreyWords[i] = arreyWords[i + 1];
            }
            return arreyWords;
        }
        static void ReplacingIndexes(string[] arreyWords)
        {
            string temp = arreyWords[10];
            arreyWords[10] = arreyWords[6];
            arreyWords[6] = temp;
        }
        static void ShowIndexMinWord(int indexMinWord)
        {
            Console.WriteLine(" Max index: " + indexMinWord + "\n"); //6
        }
        static int GetIndexShortestWord(string[] arreyWords, string shortestWord)
        {
            int indexMinWord = Array.IndexOf(arreyWords, shortestWord);
            return indexMinWord;
        }
        static void ShowIndexMaxWord(int indexMaxWord)
        {
            Console.WriteLine(" Min index: " + indexMaxWord); //10
        }
        static int GetIndexLongWord(string[] arreyWords, string longWord)
        {
            int indexMaxWord = Array.IndexOf(arreyWords, longWord);
            return indexMaxWord;
        }
        static string[] SplitWords(string userWords)
        {
            string[] arreyWords = userWords.Split(new[] { " ", ",", "." }, StringSplitOptions.None);
            return arreyWords;
        }
        static void ShowShortestWord(string shortestWord)
        {
            Console.WriteLine("Shortest word: " + shortestWord + "\n");
        }
        static string GetShortestWord(string[] arreyWords)
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
            return shortestWord;
        }
        static void ShowNumberOfLetters(string letters)
        {
            Console.WriteLine("The number of letters is: {0}", letters + "\n");
        }
        static void ShowNumberOfPunctuation(string punctuationCount)
        {
            Console.WriteLine("Number of punctuation marks: " + punctuationCount + "\n");
        }
        static void ShowSortArrey(string[] arrey)
        {
            Console.WriteLine(String.Join(" ", arrey) + "\n");
        }
        static string[] SortArrey(string[] arrey)
        {

            foreach (var sub in arrey)
            {
                Console.WriteLine(sub);
            }

            Array.Sort(arrey, (x, y) => x.Length.CompareTo(y.Length));
            Array.Reverse(arrey);
            return arrey;
        }
        static string[] SplitUserWord(string userWords)
        {
            string[] arreySort = userWords.Split(' ', ',', '.');
            return arreySort;
        }
        static string GetNumberOfLetters(string userWords)
        {
            int letters = 0;
            for (int i = 0; i < userWords.Length; i++)
            {
                if (char.IsLetter(userWords[i]))
                    letters++;
            }
            return letters.ToString();
        }
        static string GetNumberOfPunctuation(string userWords)
        {
            int punctuationCount = 0;
            for (int i = 0; i < userWords.Length; i++)
            {
                if (Char.IsPunctuation(userWords[i]))
                    punctuationCount++;
            }
            return punctuationCount.ToString();
        }
        static void ShowLongestWord(string word)
        {
            Console.WriteLine("Longest word: " + word + "\n");
        }
        static string GetLongestWord(string[] arreyWords, string word)
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
            return word;
        }
        static void Main(string[] args)
        {
            string userWords = "Всегда пишите код так, будто сопровождать его будет склонный к насилию психопат, который знает, где вы живете.";
            string word = "";
            string[] arreyWords = SplitWords(userWords);

            string longWord = GetLongestWord(arreyWords, word);
            ShowLongestWord(longWord);

            string shortestWord = GetShortestWord(arreyWords);
            ShowShortestWord(shortestWord);

            int indexMaxWord = GetIndexLongWord(arreyWords, longWord);
            ShowIndexMaxWord(indexMaxWord);
            int indexMinWord = GetIndexShortestWord(arreyWords, shortestWord);
            ShowIndexMinWord(indexMinWord);

            ReplacingIndexes(arreyWords);
            string[] arrayAfterDeletion = DeletingLongWord(arreyWords, longWord);
            ArreyResize(arrayAfterDeletion);
            ShowArreyResize(arreyWords);

            string punctuation = GetNumberOfPunctuation(userWords);
            ShowNumberOfPunctuation(punctuation);

            string letters = GetNumberOfLetters(userWords);
            ShowNumberOfLetters(letters);

            string[] arrey = SplitUserWord(userWords);
            string[] sortArrey = SortArrey(arrey);
            ShowSortArrey(arrey);
        }
    }
}
