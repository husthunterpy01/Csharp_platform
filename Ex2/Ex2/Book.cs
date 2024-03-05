using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Book : Document
    {
        public string authorName { get; set; }
        public int noPage { get; set; }
        public Book() { }   
        public Book(int idDoc, string publisher, int numPrint, string category,string authorName, int noPage) : base(idDoc,publisher,numPrint, category) 
        {
        this.authorName = authorName;
        this.noPage = noPage;
        }

        public override void Insert(List<Document> d, string category)
        {
            base.Insert(d, category);
            Console.WriteLine("Enter the author name:");
            authorName = Console.ReadLine();
            Console.WriteLine("Enter the number of pages of the book:");
            noPage = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print() {
            base.Print();
            Console.WriteLine("The author is: {0} and the number of pages are {1}", authorName, noPage);
        }
    }
}
