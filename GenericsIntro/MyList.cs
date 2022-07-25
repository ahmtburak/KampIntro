using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor class newlendiği an çalışan blok
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // diziyi veri kaybetmemek için geçici referans tutturduk.
            items= new T[items.Length+1]; // dizinin genişliğini artırıp alan oluşturduk.
            for (int i = 0; i < tempArray.Length; i++) // tempArray'deki verilerimizi tekrardan items'a aktardık.
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item; // Eklenecek olan item'ı items dizisine ekledik.
        }
    }
}
