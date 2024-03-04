using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingSample
{
    internal class Publisher
    {
        public event EventHandler<MP4EventArgs> mp4Encoded;
        public void mp4Publish(MP4 video) {
            Console.WriteLine("Encoding MP4");
            Thread.Sleep(3000);
            OnvideoEncoded(video);
        }
        protected void OnvideoEncoded(MP4 video)
        {
            mp4Encoded?.Invoke(this,new MP4EventArgs() { mp4 = video});
        }
    }


    public class MP4 { 
        public string title { get; set; }
    }
    public class MP4EventArgs : EventArgs
    {
        public MP4 mp4 { get; set; }
    }
}
