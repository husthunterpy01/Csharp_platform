using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/*
1. Add document
2. Delete document by id
3. Show document information
4. Search document by category
5. Exit the program 
 */

namespace Ex2
{
    internal class DocManager
    {
        List<Document> d = new List<Document>();
        public DocManager() { }
        public void programMenu() {
            int m;
            do
            {
                Console.WriteLine("Welcome to our program, choose a number to continue");
                Console.WriteLine("1. Add new document");
                Console.WriteLine("2. Delete document");
                Console.WriteLine("3. Show document information");
                Console.WriteLine("4. Search document by category");
                Console.WriteLine("5. Exit");
                m = Convert.ToInt32(Console.ReadLine());
                switch(m){
                    case 1:
                        Console.WriteLine("You have chosen to add new document");
                        Addlist();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to delete document");
                        Delete();
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to show document");
                        showDocInfo();
                        break;
                    case 4:
                        Console.WriteLine("You have chosen to search document by category");
                        searchDocument();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Wrong number, please try again!");
                        break;
                }
            } while (m != 5);
        }

        // Adding function
        public void Addlist() {
            int num;
            string categ;
            do
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Choose the category you want to add");
                Console.WriteLine("1. Newspaper");
                Console.WriteLine("2. Magazine");
                Console.WriteLine("3. Book");
                Console.WriteLine("4. Exit");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num) {
                    case 1: 
                        Newspaper n = new Newspaper();
                        categ = "Newspaper";
                        n.Insert(d,categ);
                        d.Add(n);
                        break;
                    case 2:
                        Magazine m = new Magazine();
                        categ = "Magazine";
                        m.Insert(d,categ); 
                        d.Add(m);
                        break;
                    case 3:
                        Book b = new Book();
                        categ = "Book";
                        b.Insert(d, categ);
                        d.Add(b);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Wrong number, try again!");
                        break;
                }
            } while (num != 4);
        }

        // Delete function
        public void Delete(){
            Console.WriteLine("Enter the document id for delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < d.Count; i++) {
                if (d[i].idDoc == id)
                {
                    d.Remove(d[i]);
                    Console.WriteLine("The document has been removed from the list");
                }
                else
                    Console.WriteLine("No id found, please try again !");
            }
        }

        // Show document information
        public void showDocInfo(){
            if (d.Count == 0) {
                Console.WriteLine("No document in the list, please add documents");
            }
            else
            {
                for (int i = 0; i < d.Count; i++) {
                    d[i].Print();
                }
            }

        }


        // Search document by category
        public void searchDocument(){
            int num;
            do
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Choose the category you want to search:");
                Console.WriteLine("1. Newspaper");
                Console.WriteLine("2. Magazine");
                Console.WriteLine("3. Book");
                Console.WriteLine("4. Exit");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        printDocByCategory("Newspaper");
                        break;
                    case 2:
                        printDocByCategory("Magazine");
                        break;
       
                    case 3:
                        printDocByCategory("Book");
                        break;
                        
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Wrong number, try again!");
                        break;
                }
            } while (num != 4);
        }

        private void printDocByCategory(string category) {
            bool isCategory = false;
            foreach (var doc in d) {
                if (doc.category == category) {
                    doc.Print();
                    isCategory = true;
                }
                if (!isCategory) {
                    Console.WriteLine("No doc found");
                }
            }
        }


    }
}
