using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void VideoUploadedEventHandler();

    class Program
    {
        static void Main(string[] args)
        {
            Uploader uploader = new Uploader();
            Nachrichten benachrichtiger = new Nachrichten();

            uploader.VideoUploaded += benachrichtiger.VideoUploaded;

            uploader.VideoUpload();

            Console.ReadKey();
        }
    }

    public class Uploader
    {
        // Events
        public event VideoUploadedEventHandler VideoUploaded;

        // Methoden
        public void VideoUpload()
        {
            Console.WriteLine("Das Video wird gerade hochgeladen...");
            VideoUploaded();
        }
    }

    public class Nachrichten
    {
        // Methoden
        public void VideoUploaded()
        {
            Console.WriteLine("Das Video wurde fertig hochgeladen!");
        }
    }
}
