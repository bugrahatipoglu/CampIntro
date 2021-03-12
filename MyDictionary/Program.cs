using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> NameAge = new MyDictionary<string, int>();
            NameAge.Add("Ali", 49);
            NameAge.Add("Emriye",51);
            NameAge.Add("Burak", 27);
            NameAge.Add("Deniz", 6);
            NameAge.goruntule();

        }

        class MyDictionary<Name,Age>
        {
            Name[] valueArray;
            Age[] keyArray;
            Name[] tempValueArray;
            Age[] tempKeyArray;
            

        public MyDictionary()
            {
                valueArray = new Name[0];
                keyArray = new Age[0];
            }
        public void Add(Name Namee,Age Agee)
            {
                tempValueArray = valueArray;
                valueArray = new Name[valueArray.Length + 1];
                for (int i = 0; i < tempValueArray.Length; i++)
                {
                    valueArray[i] = tempValueArray[i];
                }

                valueArray[valueArray.Length - 1] = Namee;

                tempKeyArray = keyArray;
                keyArray = new Age[keyArray.Length + 1];
                for (int i = 0; i < tempKeyArray.Length; i++)
                {
                    keyArray[i] = tempKeyArray[i];
                }

                keyArray[keyArray.Length - 1] = Agee;
            }

            public void goruntule()
            {
                for (int i = 0; i < valueArray.Length; i++)
                {
                    Console.WriteLine("Name : " + valueArray[i] + " " + "Age : " + keyArray[i]);
                }
            }
        }
    }
}
