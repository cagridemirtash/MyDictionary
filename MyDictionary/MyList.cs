using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<TKey,TValue>
    {
        TKey[] Keys;
        TValue[] Values;
        public MyList()
        {
            //Ilklendirme
            Keys = new TKey[0];
            Values = new TValue[0];
        }
        public void Add(TKey Key, TValue Value)
        {
            TKey[] tempArrayKey = Keys;
            TValue[] tempArrayValue = Values;

            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i <tempArrayKey.Length ; i++)
            {
                Keys[i] = tempArrayKey[i];
                Values[i] = tempArrayValue[i];
            }
            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;

            Console.WriteLine(Key + " " + Value + " Eklendi");
        }
    }
}
