using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Magazine : Document
    {
        public int publishNo { get; set; }
        public int publishMonth { get; set; }
        public Magazine() { }   
        public Magazine(int idDoc, string publisher, int numPrint, string category, int publishNo, int publishMonth) : base(idDoc, publisher, numPrint, category)
        { 
        this.publishNo = publishNo;
        this.publishMonth = publishMonth;
        }

        public override void Insert(List<Document> d, string category)
        {
            base.Insert(d, category);
            Console.WriteLine("Enter the no of the publication:");
            publishNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the publication month:");
            publishMonth = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print() {
            base.Print();
            Console.WriteLine("The author is: {0} and the number of pages are {1}", publishNo, publishMonth);
        }
    }
}
