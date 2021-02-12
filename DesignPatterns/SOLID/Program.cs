using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SOLID
{
    public class Journal
    {
        private readonly List<string> Entries = new List<string>();
        private static int Count = 0;

        public int AddEntry(string text)
        {
            Entries.Add($"{++Count}: {text}");
            return Count;
        }

        public void RemoveEntry(int index)
        {
            Entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Entries);
        }
    }

    public class Persistence
    {

        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== SOLID Testing ==========");

            var journal = new Journal();
            journal.AddEntry("This is the first message.");
            journal.AddEntry("My name is Kyu");
            Console.WriteLine(journal.ToString());

            var persistence = new Persistence();
            var filename = @"/Users/albert/_ref/sw-engineering/ref-sweng-design-patterns/DesignPatterns/SOLID/temp/journal.txt";
            persistence.SaveToFile(journal, filename, true);
            // Process.Start(filename);
        }
    }
}