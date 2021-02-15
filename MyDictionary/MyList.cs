using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<T>
    {
        T[] myList;
        public MyList()
        {
            //Ilklendirme
            myList = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = myList;
            myList = new T[myList.Length + 1 ];

            for (int i = 0; i < tempArray.Length; i++)
            {
                myList[i] = tempArray[i];
            }

            myList[myList.Length - 1] = item;
        }
    }
}
