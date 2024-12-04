# YAPILAN DEĞİŞİKLİKLER

## 1- Klasörleme
- İlerleyen süreçlerde eklenecek yeni dosyalar arasında kaybolmamak, istenilen dosyayı hızlıca bulabilmek ve düzenli görünmesini sağlamak amacıyla klasörlemeye oldukça dikkat ettin.

## 2- Dessign Patternler'den MonoSingleton ve Command Pattern
- Dessign patternleri kullanarak kod karmaşıklığını olabildiğince azaltıp modüler bir yapı kurmaya çalıştım

## 3- Event kullanımı
- Unity action kullanarak farklı class'lar arasında çalışan fonksiyonlar'da herhangi bir sorun (örneğin null) olması durumunda hata almayıp bağımlılıkları önledim.

# Ekstra Eklemelerim 
Kodları yazarken modüler şekilde ilerlemeye gayret ettim. Her class'ı, fonksiyonu amacı dahilinde kullanmaya çalıştım. İzlediğim yol ise şu şekildedir.

- Manager'larda işlem yapılmaz adı üstünde yöneticidir. Görevi sadece görev dağılımı yapmaktır. Burada ise devreye Controller'lar veya duruma göre Command'ler (Benim tanımım ile çalışan, işçiler) girmektedir.
- İşçiler, yöneticiden ne yapacakları konusunda emir alır. Bunun koddaki karşılığı ise SubscribeEvents'dir. Manager'lar burada işçilere gereken görev dağılımını yapar. Ardından işçiler
- bu görevi yapmak için araç,gereçlere ihtiyaç duyar. Burada ise devreye Signals(Sinyaller) girer. Manager gereken Signal'ı gerekli işçiye bağlar işçi ise bunu kullanarak o işi yapar.
- Günün sonunda ise bu araç, gereçleri teslim edip (UnsubscriveEvents) bir sonraki gün için hazırlanırlar.

- Birazcık hikaye gibi oldu ancak biraz karışık bir yapı gibi görünüyor. Kullanım mantığını bu şekilde açıklamak istedim.

Kodların tamamını elden geçiremedim zamanım kalmadı ne yazık ki.
  
