using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            keys = new TKey[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                tempKeys[i] = keys[i];
            }
            keys[keys.Length-1] = key;

            TValue[] tempValues = values; 
            values = new TValue[keys.Length + 1];
            for (int i = 0; i < tempValues.Length; i++)
            {
                tempValues[i] = values[i];
            }
            values[values.Length - 1] = value;
        }


        public int Count
        {
            get { return keys.Length; }

        }

    }
}
