using System;
using System.Collections.Generic;

namespace SOLID.Models.SingleResponsibility
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
}