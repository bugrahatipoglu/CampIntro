using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> studentNoName = new MyDictionary<int, string>();
            studentNoName.Add(707, "Ali");
            studentNoName.Add(321,"Emriye");
            studentNoName.Add(185, "Burak");
            studentNoName.Add(784, "Buğra");
            studentNoName.goruntule();

        }

        class MyDictionary<StudentNo,Name> //key-value
        {
            Name[] valueArray;
            StudentNo[] keyArray;
            Name[] tempValueArray;
            StudentNo[] tempKeyArray;
            

        public MyDictionary()
            {
                valueArray = new Name[0];
                keyArray = new StudentNo[0];
            }
        public void Add(StudentNo studentNo,Name name)
            {
                tempKeyArray = keyArray;
                keyArray = new StudentNo[keyArray.Length + 1];
                for (int i = 0; i < tempKeyArray.Length; i++)
                {
                    keyArray[i] = tempKeyArray[i];
                }

                keyArray[keyArray.Length - 1] = studentNo;

                tempValueArray = valueArray;
                valueArray = new Name[valueArray.Length + 1];
                for (int i = 0; i < tempValueArray.Length; i++)
                {
                    valueArray[i] = tempValueArray[i];
                }

                valueArray[valueArray.Length - 1] = name;
            }

            public void goruntule()
            {
                for (int i = 0; i < valueArray.Length; i++)
                {
                    Console.WriteLine("Student No : " + keyArray[i] + " " + "Name : " + valueArray[i]);
                }
            }
        }
    }
}
