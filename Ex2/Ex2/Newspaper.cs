using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Newspaper : Document
    {
        public int publishDay { get; set; }
        public Newspaper() { }
        public Newspaper(int idDoc, string publisher, string category, int numPrint, int pubDay) : base(idDoc, publisher, numPrint, category) {
        this.publishDay = pubDay;
        }


        public override void Insert(List<Document> d, string category)
        {
            base.Insert(d,category);
            Console.WriteLine("Enter day of publication");
            publishDay = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("The publication day is: {0}", publishDay);
        }
    }
}
