using System;
namespace secondproject
{
    class Program
    {
        static void Main(string[] args)
        {
            // ilk olarak console.writeline kullanarak metni yazdırdım.
            Console.WriteLine("lütfen aşağıdaki bilgileri giriniz:");
            // İkinci adım, metni konsola Console.WriteLine kullanarak yazdırdım ve bu
            // adımdan sonra 'TC kimlik numarası'nı Console.ReadLine ile çağırdım.
            // Burada rakamsal ifadeler olmasına rağmen herhangi bir matemetiksel işlevi olmadığından dolayı "string" yapısını kullandım.
            // Ve istenen çıktı için bu kodu tekrarladım
            Console.WriteLine("T.C. Kimlik Numarası:");
            string strAge = Console.ReadLine();
            Console.WriteLine("Adı:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            // telefon numarası sabit kalcak ve hiçbir matematiksel hesaplamaya girmeyeceğinden dolayı "string" yapısı kullandım.
            Console.WriteLine("Telefon Numarası:");
            string phone = Console.ReadLine();
            Console.WriteLine("Yaş:");
            string Age = Console.ReadLine();


            // "Double" yapısını kullandım çünkü yüzde alma, toplama gibi matematiksel işlemlerde kullanılacak.
            // Bu durumda, sayısal verileri uygun veri tiplerine dönüştürmek için convert methodunu kullandım.
            // ınt de kullanabilirdim ama kesirli de olabilir ücretler o yüzden double yapısını kullanmayı tercih ettim.
            Console.WriteLine("ilk aldığı ürünün fiyatı:");
            double Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci aldığı ürünün fiyatı:");
            double PriceSecond = Convert.ToDouble(Console.ReadLine());
            double TotalPrice = Price + PriceSecond;
            double Puan = (TotalPrice * 10) / 100;


            Console.WriteLine($"{strAge} tc numaralı {name} {surname} isimli kişi için kayıt oluşturulmuştur. {phone} telefon numarasına bildirim mesajı gönderilmiştir.{TotalPrice} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {Puan} TL'dir. ");
        }

    }
}