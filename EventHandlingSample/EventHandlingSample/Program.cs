using EventHandlingSample;
using System.Security.Cryptography.X509Certificates;
// Build an event handler for subsciber A and B 
/*  
1. Subscriber A (Mail) and B(Zalo) do the same event
2. Customize the Eventhandler for MP4 with fields title 
 */
class Program {
    static void Main(String[] args) {
     MP4 m = new MP4(){title = "Jazz" };
     Publisher p = new Publisher();
     SubscriberA a = new SubscriberA();
     SubscriberB b = new SubscriberB();
     p.mp4Encoded += a.subscribeMethodA;
     p.mp4Encoded += b.subscribeMethodB;
     p.mp4Publish(m);
     Console.ReadKey();
    }    
}