internal class Program
{
    private static void Main(string[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("ankara");
        sehirler.Add("samsun");
        sehirler.Add("istanbul");
        sehirler.Add("izmir");
        Console.WriteLine(sehirler.Count);  // Count burada property'dir.


        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("ankara");
        sehirler2.Add("manisa");
        sehirler2.Add("aydın");
        sehirler2.Add("muğla");
        sehirler2.Add("trabzon");
        Console.WriteLine(sehirler2.Count); // buradaki Count aşağıda bizim kendi ürettiğimiz property'dir

        MyList<int> rakamlar = new MyList<int>();
        rakamlar.Add(1965);
    }
}


class MyList<T> // Generic Class
{
    T[] _array;
    T[] _tempArray;

    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1]; 
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }

        _array[_array.Length - 1] = item; // burası index gösterir.
    }

    public int Count
    {
        get { return _array.Length; }
    }
}