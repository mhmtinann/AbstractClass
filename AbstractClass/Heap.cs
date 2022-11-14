using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AbstractClass
{
    public abstract class Heap //eğer abstract bir method varsa class da abstract olmak zorundadır.
    {
        //field
        protected SortedSet<int> _list; //Rastgele bir şekilde sayıları eklesek bile sortedlist olduğu için sıralı bir şekilde önümüze çıkacak.İstesek private List<int> _list şeklinde de tanımlayabilirdik ancak o zaman kendimiz sıralamak zorunda kalırdık.
        //protected yapmamızın sebebi kalıtımla erişilebilir olması.
        public Heap()
        {
            _list = new SortedSet<int>();
        }

        public void Insert(int item) //ekleme işlemi
        {
            _list.Add(item);
        }

        //abstract method
        //body yok

        public abstract int Extract(); //Çıkarma işlemi için //abstract ifadeler override edilmek zorundadır.
    }
}
