using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTutorial.Event
{
    public class Video
    {
    }

    // 1. Define delegate
    // 2. Define an Event based on that delegate
    // 3. Raise the event
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                var args = new EventArgs(); // Use EventArgs.Empty if no args needed
                VideoEncoded(this, args);
            }

        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object sender, EventArgs args)
        {
            Console.WriteLine("Sending mail...");
        }
    }
    internal class Event
    {
        public static void Run()
        {
            var publisher = new VideoEncoder();
            var subscriber = new MailService();

            publisher.VideoEncoded += subscriber.OnVideoEncoded;

            publisher.Encode(new Video());
        }
    }
}
