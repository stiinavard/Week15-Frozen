using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string wish;

            public SecretSanta(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            public string Name
            {
                get { return name; }
            }

            public string Wish
            {
                get { return wish; }
            }

        }
        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newSecretSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSanta.Add(newSecretSanta);

            }

            foreach (SecretSanta wishesFromList in mySecretSanta)
            {
                Console.WriteLine($"{wishesFromList.Name} wants {wishesFromList.Wish} for christmas.");
            }

        }

        public static void DisplayELementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Stiina\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
