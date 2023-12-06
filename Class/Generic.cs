using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Class
{
    // How to create a list that contains items of any type
    internal class Generic
    {
        
    }

    internal class Book
    {
        private string title;
        private string author;
    }

    // Method#1 One Class One Type
    // ===========================
    // In this way, we need to create a different list based
    // on different types which is not efficient.
    internal class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // Method#2 Object Type
    // ====================
    // We fulfill the requirement until we meet a performance issue.
    // Everytime we store an item, it has to be stored as an object.
    // Everytime we try to fetch an item from the list, we have to change
    // it back to its original type.
    internal class ObjectList
    {
        public void Add(object book)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // Method#3 Generic
    // ================
    // We can avoid creating abundant amount of class while also
    // not having performance issue by using Generic.
    //
    // Generic make it possible to use any data type that
    // the user (of the code) specify.
    // Ex:
    //  - GenericList<string> means that the user will create a list of string.
    //  - GenericList<int> means that the user will create a list of int.
    //
    // T is a shorthand of Template
    internal class GenericList<T>
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }


    // Another example of generic
    internal class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
        }
    }

    internal class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) where T : IComparable    
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

}
