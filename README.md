## **Yapılan Değişiklikler**

### **1. Klasörleme**
Projede düzenli bir yapı oluşturmak ve ilerleyen süreçlerde eklenecek yeni dosyalar arasında kaybolmamak için klasörleme yapısına büyük önem verdim. Bu sayede:
- Gerekli dosyalar hızlıca bulunabilir.
- Kod düzeni ve okunabilirlik artırıldı.

---

### **2. Design Patterns (Tasarım Kalıpları)**
Projede aşağıdaki tasarım kalıpları kullanılmıştır:
- **MonoSingleton**
- **Command Pattern**

Bu kalıplar sayesinde:
- Kod karmaşıklığı azaltılmıştır.
- Modüler ve genişletilebilir bir yapı oluşturulmuştur.

---

### **3. Event Kullanımı**
Unity’nin **Action** yapısı kullanılarak farklı sınıflar arasında haberleşme sağlanmıştır. Bu yaklaşım:
- Bağımlılıkları önler.
- Null referans hatalarını engeller.
- Daha esnek bir yapı sunar.

---

## **Proje Yapısı ve Çalışma Prensibi**

Projede her sınıf ve fonksiyon, yalnızca kendi sorumluluğunu yerine getirecek şekilde tasarlanmıştır. Yapı şu şekilde çalışır:

1. **Manager (Yöneticiler):**
   - **Görevi:** Sadece görev dağılımını yapmak.
   - Manager'lar herhangi bir işlem yapmaz. Sorumluluğu, görevleri ilgili sınıflara iletmektir.

2. **Controller ve Command (İşçiler):**
   - **Görevi:** Manager tarafından verilen görevleri yerine getirmek.
   - İşçiler, görevlerini gerçekleştirmek için gerekli araç ve sinyalleri kullanır.

3. **Signals (Sinyaller):**
   - **Görevi:** İşçiler ve Manager arasında bağlantı kurmak.
   - Manager, uygun sinyali işçilere bağlar. İşçiler ise bu sinyali kullanarak görevlerini tamamlar.

4. **Event Yönetimi:**
   - Manager, görev dağıtımı sonrası **SubscribeEvents** yöntemi ile olayları dinler.
   - Görev tamamlandığında **UnsubscribeEvents** ile sistem temizlenir ve bir sonraki göreve hazırlanır.

---

## **Hikaye ile Anlatım**

Manager'lar, işçilere görev verir. İşçiler, bu görevleri gerçekleştirmek için gerekli sinyalleri kullanır. Görev tamamlandığında işçiler araçlarını teslim eder ve bir sonraki görev için hazır hale gelirler. Bu döngü şu şekilde işler:
- **Manager**: Görev dağıtımı yapar.
- **Command**: Görevi yerine getirir.
- **Signal**: İletişimi sağlar.
- **Event Yönetimi**: Sistem hazırlığını yapar.

---

Hepsini düzenlemeye zamanım olmadı ne yazık ki.
