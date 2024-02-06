using System;
using System.Collections.Generic;

#region RamyaCollections Namespace
namespace RamyaCollections
{

    #region Node Class
    /// <summary>
    /// Class for Storing Structure of Node for Single Linked List
    /// </summary>
    /// <typeparam name="T">Indicates that Node is generic</typeparam>
    public class Node<T>
    {
        #region Properties
        /// <summary>
        /// Instance variable which stores data of type T
        /// </summary>
        public T Data;

        /// <summary>
        /// Instance variable which stores reference to next Node of Type T
        /// </summary>
        public Node<T> Next;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor to initialize Node
        /// </summary>
        /// <param name="data">Data of type T</param>
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
        #endregion
    }
    #endregion

    #region RamyaList Class
    /// <summary>
    /// Collection RamyaList which internally implements Single Linked List
    /// </summary>
    /// <typeparam name="T">Indicates that RamyaList is a generic collection</typeparam>
    public class RamyaList<T>
    {

        #region Properties
        /// <summary>
        /// The Node of Type T referencing to the head of the RamyaList
        /// </summary>
        private Node<T> head;
        /// <summary>
        /// count of type int stores the number of Nodes in the RamyaList
        /// </summary>
        private int count;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes head to null and count to zero
        /// </summary>
        public RamyaList()
        {
            head = null;
            count = 0;
        }
        #endregion

        #region Indexing RamyaList
        /// <summary>
        /// Used for setting and getting values at given index 
        /// </summary>
        /// <param name="index">The index at which the element need to be accessed or modified</param>
        /// <returns>Returns value at given index while accessing</returns>
        public T this[int index]
        {
            get
            {
                return AccessAt(index);
            }
            set
            {
                UpdateAt(index, value);
            }
        }
        #endregion

        #region Insertion Methods
        /// <summary>
        /// Inserts given data at given position
        /// </summary>
        /// <param name="position">The position at which data need to be inserted</param>
        /// <param name="data">The data of Type T</param>
        /// <exception cref="IndexOutOfRangeException">Throws IndexOutOfRangeException when position id below 0 or above size of List</exception>
        public void InsertAt(int position, T data)
        {
            if (position < 0 || position > count)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and size of List");
            }

            Node<T> newNode = new Node<T>(data);
            if (position == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }

            count++;
        }

        /// <summary>
        /// Inserts given data at the end of the List
        /// </summary>
        /// <param name="data">The data of Type T</param>
        public void Add(T data)
        {
            InsertAt(count, data);
        }

        /// <summary>
        /// Creates a List from Array
        /// </summary>
        /// <param name="array">Array of Type T</param>
        public void FromArray(T[] array)
        {
            head = null;
            foreach (T item in array)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Inserts given collection at given Index
        /// </summary>
        /// <param name="index">The index at which the collection needs to be inserted</param>
        /// <param name="collection">IEnumerable of Type T</param>
        public void InsertRange(int index, IEnumerable<T> collection)
        {
            Node<T> current = head;
            int currentIndex = 0;

            while (current != null && currentIndex < index)
            {
                current = current.Next;
                currentIndex++;
            }

            foreach (var item in collection)
            {
                InsertAt(currentIndex++, item);
            }
        }

        /// <summary>
        /// Appends given collection at the end of the List
        /// </summary>
        /// <param name="collection">Collection of type IEnumerable which needs to be appended to the List</param>
        public void AddCollection(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        #endregion

        #region Deletion Methods
        /// <summary>
        /// Deletes at the end
        /// </summary>
        public void Pop()
        {
            DeleteAt(count - 1);
        }

        /// <summary>
        /// Deletes the element at given position
        /// </summary>
        /// <param name="position">The position at which data needs to be deleted</param>
        /// <exception cref="IndexOutOfRangeException">Throws IndexOutOfRangeException when position Is below 0 or above size of List</exception>
        public void DeleteAt(int position)
        {
            if (position < 0 || position >= count)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and size of List");
            }

            if (position == 0)
            {
                head = head.Next;
            }
            else
            {
                Node<T> current = head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = current.Next.Next;
            }

            count--;
        }

        /// <summary>
        /// Clears all the data and sets the head to Null
        /// </summary>
        public void Clear()
        {
            head = null;
            count = 0;
        }

        /// <summary>
        /// Removes the Node with given value of type T
        /// </summary>
        /// <param name="value">Data which needs to be deleted</param>
        public void Remove(T value)
        {
            Node<T> current = head;
            Node<T> prev = null;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, value))
                {
                    if (prev == null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    count--;
                    return;
                }

                prev = current;
                current = current.Next;
            }
        }

        /// <summary>
        /// Removes range of elements from the List
        /// </summary>
        /// <param name="index">The index at which the range starts</param>
        /// <param name="count">Number of elements to be removed from Index count</param>
        public void RemoveRange(int index, int count)
        {
            for (int i = 0; i < count; i++)
            {
                DeleteAt(index);
            }
        }
        #endregion

        #region Updation methods
        /// <summary>
        /// Updates the value at given Position
        /// </summary>
        /// <param name="position">The position at which data needs to be updated</param>
        /// <param name="value">New value of Data</param>
        /// <exception cref="IndexOutOfRangeException">Throws IndexOutOfRangeException when position Is below 0 or above size of List</exception>
        public void UpdateAt(int position, T value)
        {
            if (position < 0 || position >= count)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and size of List");
            }

            Node<T> current = head;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }

            current.Data = value;
        }
        #endregion

        #region Traversal and Access Methods
        /// <summary>
        /// Access the Data at given position
        /// </summary>
        /// <param name="position">The position at which data needs to be accessed</param>
        /// <returns>The value of Type T at given position</returns>
        /// <exception cref="IndexOutOfRangeException">Throws IndexOutOfRangeException when position Is below 0 or above size of List</exception>
        public T AccessAt(int position)
        {
            if (position < 0 || position >= count)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and size of List");
            }

            Node<T> current = head;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        /// <summary>
        /// Traverses through the List and prints the values
        /// </summary>
        public void Traverse()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Creating forEach loop to traverse through the List
        /// </summary>
        /// <param name="action"></param>
        public void ForEach(Action<T> action)
        {
            Node<T> current = head;

            while (current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }

        /// <summary>
        /// Generates an ENumerator for the List
        /// </summary>
        /// <returns>Returns IEnumerator of Type T for List</returns>
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /// <summary>
        /// Fetches data in given range as IEnumerable Object of Type T
        /// </summary>
        /// <param name="index">The start index at which the data access should start</param>
        /// <param name="count">The number of elements to be accessed from given index</param>
        /// <returns>IEnumerable object of Type T of data in given range</returns>
        public IEnumerable<T> GetRange(int index, int count)
        {
            Node<T> current = head;
            int currentIndex = 0;

            while (current != null && currentIndex < index)
            {
                current = current.Next;
                currentIndex++;
            }

            for (int i = 0; i < count && current != null; i++)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        #endregion

        #region Conversion Methods
        /// <summary>
        /// Converts List to Array of Type T
        /// </summary>
        /// <returns>Returns Array of Type T</returns>
        public T[] ToArray()
        {
            T[] array = new T[count];
            Node<T> current = head;

            for (int i = 0; i < count; i++)
            {
                array[i] = current.Data;
                current = current.Next;
            }

            return array;
        }
        #endregion

        #region Count Method
        /// <summary>
        /// Returns the count or size of the List
        /// </summary>
        public int Count
        {
            get { return count; }
        }
        #endregion

        #region Searching Methods

        /// <summary>
        /// Searches if given value is present in the List or not
        /// </summary>
        /// <param name="value">The value of Type T which needs to be searched</param>
        /// <returns>True if given value exists; false otherwise</returns>
        public bool Exists(T value)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, value))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Searches for given value and returns index of first Occurrence
        /// </summary>
        /// <param name="value">The value of Type T which needs to be searched</param>
        /// <returns>Returns Index of first occurrence if present; -1 otherwise</returns>
        public int IndexOf(T value)
        {
            Node<T> current = head;
            int index = 0;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, value))
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        /// <summary>
        /// Searches for given value and returns index of last Occurrence
        /// </summary>
        /// <param name="value">The value of Type T which needs to be searched</param>
        /// <returns>Returns Index of last occurrence if present; -1 otherwise</returns>
        public int LastIndexOf(T value)
        {
            Node<T> current = head;
            int lastIndex = -1;
            int index = 0;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, value))
                {
                    lastIndex = index;
                }

                current = current.Next;
                index++;
            }

            return lastIndex;
        }
        #endregion

        #region ReversingList Method
        public void Reverse()
        {
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }
        #endregion 

    }
    #endregion
}
#endregion
