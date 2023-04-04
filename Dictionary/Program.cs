namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionaryler anahatar ve keyler olarak tutarlar verileri keyler uniq olmak zorunda 
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10,"hakkı tapan");
            kullanıcılar.Add(12,"ahmet tayin");
            kullanıcılar.Add(23,"ferhat sayar");
            kullanıcılar.Add(34,"özcan özan");
            
            // dizinin elemanlarına erişim
            
            Console.WriteLine("******** elemanlara erişme *********");
            Console.WriteLine(kullanıcılar[23]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            //count;
            Console.WriteLine("************* count ************");
            Console.WriteLine(kullanıcılar.Count);
            
            //contains 
            Console.WriteLine("*************** contains ****************");
            Console.WriteLine(kullanıcılar.ContainsKey(23));
            Console.WriteLine(kullanıcılar.ContainsValue("hakkı"));
            
            //Remove eleman çıkarma
            Console.WriteLine("********* remove ***********");
            kullanıcılar.Remove(23);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
            }
            //keys  sadece kaçıncı olduğunu yazarız 
            Console.WriteLine("*************** keys****************");
            foreach (var item in kullanıcılar.Keys)
            {
             Console.WriteLine(item);   
            }
            //value eğer bunu eklersek yukardaki gibi sadece isimlerini alırız 
            
            Console.WriteLine("*************** values ****************");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            } 
            
        }
    }
    
}

