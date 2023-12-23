# Javascript Kod Yapısına Dair Birkaç Söz
* Komutları oluşturabilmek için yazdığımız kod cümlelerine ifade(statement) denir.
* İfadeler birbirinden (;) işareti ile ayrılır.
* JS ifadelerin sonuna (;) konulmasını zorunlu kılmaz, kendisi otomatik olarak koyabilir.
* Ancak bu özelliğe güvenmemeliyiz. Kendimiz (;) koymaya alışmalıyız.
* Nedenlerini ilerledikçe öğreneceksiniz.
* Yine de detaylı bilgi almak isteyenler  [ECMAScript Automatic Semicolon Insertion](https://tc39.es/ecma262/#sec-automatic-semicolon-insertion) linkinden inceleyebilirler.
* Tanımlayıcı(Değişken, Fonksiyon vb.) adlandırma kuralları:
    * Tanımlayıcı adları harf, (_), ($) işareti ile başlayabilir; diğer özel karakterler ya da rakamlarla başlayamaz.
    * İlk karakterden sonra (_), ($), harf ya da rakam dışında herhanbi bir karakter bulunamaz.
    * Tanımlayıcı adları küçük/BÜYÜK harf duyarlıdır.
* İSİMLENDİRMEDE TÜRKÇE KARAKTER KULLANMAMAYA ALIŞMALIYIZ!
* İsimlendirme Yöntemleri(Her programlama dilinde geçerli)
    * Camel Case:
        En çok kullanılan isimlendirme yöntemlerinden biridir. Sözcüklerin ilk harfi büyük geri kalan harfleri küçük yazılır. İki kullanım şekli vardır:
        * Upper Camel Case: Buna Pascal Case de denir. Her sözcüğün ilk harfi büyük, geri kalan harfleri küçük yazılır. Ör: AdSoyad, DogumTarihi, KdvOrani
        * Lower Camel Case: İlk sözcük tamamen küçük, geri kalanların ise ilk harfi büyük geri kalanları küçük yazılır. Ör: adSoyad, dogumTarihi, kdvOrani
    * Snake Case:
        Sözcükler birbirinden (_) ile ayrılır. Upper, Lower ve Screaming versiyonları vardır. Ör: Ad_Soyad, ad_soyad, dogum_tarihi, Dogum_Tarihi, AD_SOYAD, DOGUM_TARIHI
    * Diğer

* Java Script Name Conventions
    * Değişkenler: 
        * Büyük küçük harf duyarlı.
        * camelCase kullanılır, harfler başlanır.
        * İçindeki değeri açıklayıcı nitelikte.
        * Mantıksal(Boolean) değişkenler genellikle is ya da has ifadesiyle başlatılır.
        * İngilizce kavramlar kullanın.
    * Fonksiyon ve Sınıf Metotları
        * Büyük küçük harf duyarlı.
        * camelCase kullanılır, harfler başlanır.
        * Genelde get, make, apply gibi emir kipi ile başlamalı.
    * Sabitler:
        * Büyük küçük harf duyarlı.
        * Screaming Snake Case kullanılır.
        * Genelde en üstte olur.
    * Sınıflar: 
        * Büyük küçük harf duyarlı.
        * PascalCase kullanılır, harfle başlanır.
        * Sınıfın işlevselliğini açıklayıcı nitelikte.
    * Private:
        * _ ile başlar.


* Resmi Dökümantasyon: [ECMAScript Official Documentation](https://tc39.es/ecma262)

* MDN Javascript Tutorial: [MDN JavaScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)