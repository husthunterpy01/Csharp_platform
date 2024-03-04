using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingSample
{
    internal class SubscriberA
    {
        public void subscribeMethodA(object sender, MP4EventArgs e) {
            Console.WriteLine("Mail is: {0}", e.mp4.title);
        }
    }
}
