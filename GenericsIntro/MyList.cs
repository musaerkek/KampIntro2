using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList() //------> Bir class new'lendiğinde çalışan bloğa constructor deniliyor.
        {
            items = new T[0];//------->Böylece elimde 0 elemanlı bir dizim oldu.
        }
        public void Add(T item)//------>Burada da diziye eleman ekleyeceğim.
        {
            T[] tempArray = items;//------>Elemanların referansları değiştiği için kayboluyordu.
                                         //Burada kaybolmasın diye tempArray'e emanet ettik.                                            
            items = new T[items.Length+1];//------>items.Length dizinin eleman sayısı demek.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items;}
        }

    }
}
