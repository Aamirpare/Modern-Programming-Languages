using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayManipulations.Events.VideoApp
{
    public class VideoEventArgs : EventArgs
    {
        public string Message { get; set; }
        public int VideoLength { get; set; }
    }
    public class Video
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
    }

    //publisher
    public class VideoEncoder
    {
        //public delegate void VideoEncodeHandler(string args);
        //public event VideoEncodeHandler OnVideoEncoded;
        public EventHandler OnVideoEncoded;
        //public EventHandler<VideoEventArgs> OnVideoEncoded;
        public string Title { get; set; } = "Fast Video Encoder";
        public virtual void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(4000);
            //if(OnVideoEncoded != null)
            var args = new VideoEventArgs()
            {
                Message = $"{video.Title} is encoded",
                VideoLength = 60
            };
            OnVideoEncoded?.Invoke(this, args );
        }
    }
    public class User
    {
        public static void Main(string[] args)
        {
            var v = new Video() { Title = "Times of Romans"};

            var encode = new VideoEncoder();

            //register the event
            encode.OnVideoEncoded += OnVideoEncoded;

            //Encode raises the event
            encode.Encode(v);

            Console.ReadKey();
        }
        private static void OnVideoEncoded(object sender, EventArgs args)
        {
            var encoder = sender as VideoEncoder;
            
            Console.WriteLine(encoder.Title);

            var e = args as VideoEventArgs;

            Console.WriteLine(e.Message);

            Console.WriteLine(e.VideoLength);
        }
    }
}

