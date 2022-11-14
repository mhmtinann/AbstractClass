using System;
using System.Collections.Generic;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var heap = new Heap(); şeklinde türetme yapamayız çünkü abstract ifadelerde türetme olmaz.Onun yerine abstract classları başka bir class üzerinden devralıp onu türetmemiz gerekir 

            var MinHeap = new MinHeap(); //yeni bir liste oluştu   
            var MaxHeap = new MaxHeap(); //minheaptan farklı bir yeni liste oluştu
            
             
            var arr = new int[] {3,2,1,4,5};
            foreach (var item in arr)
            {
                MinHeap.Insert(item); //2 kere insterliyoruz çünkü newlediğimizde 2 adet _list adlı liste oluştu
                MaxHeap.Insert(item);
                
            }

            Console.WriteLine(MinHeap.Extract());
            Console.WriteLine(MaxHeap.Extract());

            
        }
    }
}
