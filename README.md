İlk olarak, kullanıcıdan bilgi girmesini istemek için metin yazdırıyoruz console.writeline yapısı kullanarak. 
Ardından Kullanıcıdan TC kimlik numarasını alıyoruz. Bu verinin string olarak saklanmasının sebebi, sayısal bir hesaplama gerektirmemesidir.
Kullanıcıdan adı, soyadı, telefon numarasını ve yaşını almak için benzer şekilde Console.ReadLine() kullanılır. 
Telefon ve TC kimlik numarası için string kullanımı uygundur.
İlk ve ikinci ürünün fiyatları için double türü kullanılır çünkü fiyatları matematiksel işlemlerde kullanıyoruz  
ınt yapısı da kullanılırdı fakat fiyatlar 60,69 tl girildiğinde tam sayı olmazdı o yuzden double kullanıldı.
Convert.ToDouble() metodu ile kullanıcının girdiği string değeri double türüne dönüştürüldü. Çünkü readline methodu string döndürür.

