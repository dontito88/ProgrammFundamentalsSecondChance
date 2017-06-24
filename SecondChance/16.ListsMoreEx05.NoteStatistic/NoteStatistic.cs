using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ListsMoreEx05.NoteStatistic
{
    class NoteStatistic
    {
        static void Main(string[] args)
        {
            List<double> inputFrequences = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<string> noteList = new List<string>();
            List<string> naturalNoteList = new List<string>();
            List<string> sharpNoteList = new List<string>();
            double naturalFrequencesSum = 0;
            double sharpFrequencesSum = 0;

            for (int i = 0; i < inputFrequences.Count; i++)
            {
                if (inputFrequences[i] == 261.63)
                {
                    noteList.Add("C");
                    naturalNoteList.Add("C");
                    naturalFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 277.18)
                {
                    noteList.Add("C#");
                    sharpNoteList.Add("C#");
                    sharpFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 293.66)
                {
                    noteList.Add("D");
                    naturalNoteList.Add("D");
                    naturalFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 311.13)
                {
                    noteList.Add("D#");
                    sharpNoteList.Add("D#");
                    sharpFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 329.63)
                {
                    noteList.Add("E");
                    naturalNoteList.Add("E");
                    naturalFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 349.23)
                {
                    noteList.Add("F");
                    naturalNoteList.Add("F");
                    naturalFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 369.99)
                {
                    noteList.Add("F#");
                    sharpNoteList.Add("F#");
                    sharpFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 392.00)
                {
                    noteList.Add("G");
                    naturalNoteList.Add("G");
                    naturalFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 415.30)
                {
                    noteList.Add("G#");
                    sharpNoteList.Add("G#");
                    sharpFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 440.00)
                {
                    noteList.Add("A");
                    naturalNoteList.Add("A");
                    naturalFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 466.16)
                {
                    noteList.Add("A#");
                    sharpNoteList.Add("A#");
                    sharpFrequencesSum += inputFrequences[i];
                }
                else if (inputFrequences[i] == 493.88)
                {
                    noteList.Add("B");
                    naturalNoteList.Add("B");
                    naturalFrequencesSum += inputFrequences[i];
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ", noteList)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturalNoteList)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharpNoteList)}");
            Console.WriteLine($"Naturals sum: {naturalFrequencesSum.ToString("0.##")}");
            Console.WriteLine($"Sharps sum: {sharpFrequencesSum.ToString("0.##")}");

        }
    }
}
