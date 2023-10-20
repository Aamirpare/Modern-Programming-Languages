using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
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
        //public EventHandler OnVideoEncoded;
        public EventHandler<VideoEventArgs> OnVideoEncoded;
        public string Title { get; set; } = "Fast Video Encoder";
        public virtual void Encode(Video video)
        {
            //Thread.Sleep(5000);
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
        private static void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            var encoder = sender as VideoEncoder;
            
            Console.WriteLine(encoder.Title);

            Console.WriteLine(args.Message);
            Console.WriteLine(args.VideoLength);
        }
    }
}

