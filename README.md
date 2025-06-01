##  🎯 AR Dart Oyunu
Bu proje, Unity ve AR Foundation kullanılarak geliştirilen artırılmış gerçeklik (AR) tabanlı bir dart oyunudur. Oyuncular, sanal dartları gerçek dünyadaki bir dart tahtasına fırlatarak eğlenceli ve etkileşimli bir deneyim yaşar. Başarılı isabetler anlık olarak puana yansır ve gerçek zamanlı geri bildirim sağlar.

Oyun, hem düzlem algılama (plane detection) hem de görsel hedef (image tracking) teknolojilerini kullanır. Böylece oyun farklı ortamlarda esnek şekilde oynanabilir. Dart tahtası, masa veya zemin gibi yüzeylere yerleştirilebilir ya da belirli bir görsel hedef ile otomatik olarak çağrılabilir.

## 🎯 Amaç
- Artırılmış gerçeklik ile oyun mekaniği geliştirme  
- Düzlem algılama ve hedefleme sistemlerinin etkileşimli şekilde kullanılması  
- Mobil ortamlarda kullanıcıya keyifli ve gerçekçi bir deneyim sunma  

## 🔧 Özellikler
- **Düzlem Algılama**: Gerçek yüzeyleri algılayarak dart tahtasını konumlandırma.
- **Görsel Hedef Tanıma**: Belirli bir görsel hedefi tarayarak oyun öğelerini başlatma.
- **Etkileşimli Oynanış**: Oyuncu sanal dart fırlatır, başarılı atışlar puan getirir.
- **3D Modeller**: Dart ve dart tahtası için özel hazırlanmış gerçekçi 3B modeller.
- **Puanlama Sistemi**: Her başarılı atışla artan dinamik puanlama sistemi.
- **Mesafe Göstergesi**: Oyuncunun cihaz ile dart tahtası arasındaki mesafe gösterilir.

### 🧰 Gereksinimler
- Unity (2020.3 veya üzeri önerilir)
- AR Foundation
- ARKit (iOS için) veya ARCore (Android için)
- C# desteği

## ⚙️ Kurulum ve Çalıştırma
1. Bu projeyi GitHub’dan klonlayın veya ZIP olarak indirin.
2. Unity ile projeyi açın.
3. AR Foundation ve platforma özel (ARKit veya ARCore) paketleri yükleyin.
4. `Scenes` klasöründeki örnek sahneyi açın.
5. `iOS` veya `Android` platformuna build alın.
6. Xcode veya Android Studio üzerinden cihaza deploy edin.

## 📱 iOS Build Alma
1. `File > Build Settings` üzerinden sahneyi seçin ve **Add Open Scenes** ile ekleyin.  
2. Ardından **Build** tuşuna basın ve örneğin `ARDartBuild` adında bir klasöre export edin.  
3. Oluşan `.xcodeproj` dosyasını **Xcode** ile açın.  
4. `Signing & Capabilities` sekmesinden Apple hesabınızı seçin.  
5. iPhone’unuzu bağlayın ve `Cmd + R` tuşlarıyla uygulamayı çalıştırın.

## 📁 Klasör Yapısı
- `Assets/` → Oyun içeriği ve sahneler  
- `Packages/` → Unity paket yönetimi  
- `ProjectSettings/` → Proje ayarları  
- `docs/` → Geliştirici belgeleri (isteğe bağlı)


## 📄 Teslim Belgeleri (örnek amaçlı)
- ARDart_GereksinimAnalizi.docx  
- ARDart_SistemMimarisi.docx  
- ARDart_KurulumKılavuzu.docx  
- ARDart_TestRaporu.docx  
- ARDart_ProgramcıKılavuzu.docx  
- ARDart_ProjeSunumu.pptx  
- UseCaseDiagram.pdf  
- ClassDiagram.pdf  
- SequenceDiagram.pdf  

---

**Not:** Proje, iOS cihazlarda ARKit desteğiyle sorunsuz çalışır. Xcode ile iPhone’a yüklenebilir.

📋 **Proje sürecini takip etmek için Trello panosu:**  
🔗 [AR Dart Oyunu - Trello Proje Takibi](https://trello.com/b/7gjRe2zo/ar-mini-sef-proje-takibi)

## Video Demonstration
• https://www.youtube.com/shorts/esa0YSy-xG8

## 👨‍🎓 Geliştirici
**Adı Soyadı:** Halit Mustafa Karagöz  
**Öğrenci No:** 200541043  
**Proje Dersi:** Yazılım Mühendisliğinde Güncel Konular  
**Teslim Dönemi:** Bahar 2025
