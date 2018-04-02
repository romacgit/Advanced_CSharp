using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstelle die Objekte
            Wort _word = new Wort();
            Benachrichtiger _benachrichtiger = new Benachrichtiger();

            // Abonniere das Event
            _word.WordChanged += _benachrichtiger.WordChanged;

            // Ändere das Wort
            _word.ChangeWord("Robert");
            _word.ChangeWord("DeNiro");

            // Halte das Programm an
            Console.ReadKey();
        }

        public class Benachrichtiger
        {
            // Methoden
            public void WordChanged(object sender, WordChangedEventArgs e)
            {
                string newWord = e.Word;
                Console.WriteLine("Das neue Wort ist: " + newWord);
            }
        }

        public class WordChangedEventArgs : EventArgs
        {
            public string Word { get; set; }
        }

        public delegate void WordChangedEventHandler(object sender, WordChangedEventArgs e);

        public class Wort
        {
            //Variable
            private string MyWord;

            // Methoden
            public void ChangeWord(string txt)
            {
                MyWord = txt;
                Console.WriteLine(MyWord);
                OnWordChanged();
            }

            // Events
            public event WordChangedEventHandler WordChanged;

            protected virtual void OnWordChanged()
            {
                if (WordChanged != null)
                {
                    WordChangedEventArgs args = new WordChangedEventArgs();
                    args.Word = MyWord;

                    WordChanged(this, args);
                }
            }
        }
    }
}
