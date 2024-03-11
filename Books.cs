using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5_books
{
    public class Book : IComparable<Book>
    {
        public int id {  get; set; }
        public string title { get; set; }
        public int numpages { get; set; }

        public Book(int id, string title, int numpages) 
        {
            this.id = id;
            this.title = title;
            this.numpages = numpages;
        }

        public override string ToString()
        {
            return $"id: {this.id}, titol: {this.title}, numero de pagines: {this.numpages}";
        }

        public int CompareTo(Book other)
        {
            if (other == null) return 1;
            return numpages.CompareTo(other.numpages);
        }
    }
}
