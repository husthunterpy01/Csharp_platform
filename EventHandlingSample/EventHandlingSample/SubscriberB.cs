using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingSample
{
    internal class SubscriberB
    {
        public void subscribeMethodB(object sender, MP4EventArgs e)
        {
            Console.WriteLine("Zalo is: {0}", e.mp4.title);
        }
    }
}
