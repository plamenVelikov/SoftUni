using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            
        }
        private List<Book> books;


        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        class LibraryIterator : IEnumerator<Book>
        {
            
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                
                this.books = books;
                this.books.Sort(new BookComparator());
                currentIndex = -1;
            }

            public void Dispose(){}
            public bool MoveNext() => ++currentIndex < books.Count;
            public void Reset() { }
            public Book Current => this.books[this.currentIndex];
            object IEnumerator.Current => this.Current;
        }
    }
}
