using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------- Lists ---------

            // Erstelle die Liste
            List<int> zahlenListe = new List<int>();

            // Füge Werte zur Liste hinzu
            zahlenListe.Add(1);
            zahlenListe.Add(2);
            zahlenListe.Add(3);
            zahlenListe.Add(4);
            zahlenListe.Add(5);

            // Gebe die Liste mit For-Schleife aus
            for(int i = 0; i < zahlenListe.Count(); i++)
            {
                Console.WriteLine(zahlenListe[i]);
            }

            Console.WriteLine("----------");

            // Entferne Werte aus der Liste
            zahlenListe.Remove(1);
            zahlenListe.RemoveAt(0);

            Console.WriteLine("----------");

            // Gebe die Liste mit Foreach-Schleife aus
            foreach (int zahl in zahlenListe)
            {
                Console.WriteLine(zahl);
            }

            Console.WriteLine("----------");

            // --------- Stacks ---------

            // Erstelle einen Stack
            Stack<int> zahlenStack = new Stack<int>();

            // Lege neue Werte oben auf den Stack und Lösche sie dann
            zahlenStack.Push(1);
            zahlenStack.Push(2);
            zahlenStack.Push(3);
            zahlenStack.Push(4);
            zahlenStack.Push(5);
            zahlenStack.Pop();

            Console.WriteLine(zahlenStack.Peek());

            Console.WriteLine("----------");

            // --------- Queues ---------

            // Erstelle Queue und Fülle sie mit Werten
            Queue<string> stringQueue = new Queue<string>();

            stringQueue.Enqueue("Peter");
            stringQueue.Enqueue("Vanessa");
            stringQueue.Enqueue("Melvin");
            stringQueue.Enqueue("Sam");
            stringQueue.Dequeue();
            stringQueue.Dequeue();

            foreach (string name in stringQueue)
                Console.WriteLine(name);

            Console.WriteLine(stringQueue.Peek());

            Console.WriteLine("----------");

            // -------- Dictionarys ---------

            // Erstelle und befülle das Dictionary
            Dictionary<string, int> wochentage = new Dictionary<string, int>();

            wochentage.Add("Montag", 1);
            wochentage.Add("Dienstag", 2);
            wochentage.Add("Mittwoch", 3);
            wochentage.Add("Donnerstag", 4);
            wochentage.Add("Freitag", 5);

            // Lese die Werte aus
            Console.WriteLine(wochentage["Donnerstag"]);

            Console.ReadKey();
        }
    }
}
