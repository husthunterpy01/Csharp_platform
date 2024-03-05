using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Document
    {
        public int idDoc {get;set;}
        public string publisher { get;set;}

        public int numPrint { get;set;}
        public string category { get;set;}
        public Document() { }
        public Document(int idDoc, string publisher, int numPrint, string category)
        {
            this.idDoc = idDoc;
            this.publisher = publisher;
            this.numPrint = numPrint;
            this.category = category;
        }

        public virtual void Insert(List<Document> d, string category) {
            Console.WriteLine("Insert the Id of the document");
            int a;
            bool idExists;
            // Check unique value id
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                idExists = d.Any(doc => doc.idDoc == a);
                if (idExists)
                {
                    Console.WriteLine("The id has been taken, please type another id");
                }
            } while (idExists);

            idDoc = a;

            Console.WriteLine("Insert the publisher of the document");
            publisher = Console.ReadLine();
            Console.WriteLine("Insert the number of prints");
            numPrint = Convert.ToInt32(Console.ReadLine());
            this.category = category;
        }

        public virtual void Print() {
            Console.WriteLine("The information of the document you're looking is: Id:{0} Publisher:{1} NoPrint:{2} Category: {3}", idDoc, publisher, numPrint, category);
        }
    }
}
