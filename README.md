# 📦 AR Kutu Patlatma Oyunu

**ARKit teknolojisiyle Swift dili kullanılarak geliştirilen eğlenceli ve interaktif bir artırılmış gerçeklik (AR) oyunudur.** Gerçek dünyayı dijital dünya ile buluşturan bu projede, oyuncular sanal kutuları hedef alarak top fırlatır ve eğlenceli bir “kutu patlatma” deneyimi yaşar.  

**Gerçek zamanlı fizik, puanlama ve sade kullanıcı arayüzü** sayesinde oyun, özellikle küçük yaştaki kullanıcılar için öğrenmesi kolay, oynaması keyifli bir eğlence sunar.

---

## 🎯 Proje Amacı

- ARKit ile oyun geliştirme becerisi kazanmak  
- Çocuklara yönelik hedef odaklı ve fizik temelli mini oyun sunmak  
- iOS cihazlar için sezgisel, sade ve etkileşimli bir deneyim oluşturmak  
- Gerçek dünya yüzeylerinde sanal nesnelerle oynamanın keyfini yaşatmak  

---

## 🚀 Oyunun Özellikleri

- **🔍 Düzlem Algılama (Plane Detection)**: Kamera ile masa, zemin gibi yüzeyler otomatik algılanır.
- **📦 Kutuların Akıllı Yerleşimi**: Algılanan yüzeye dengeli bir şekilde sanal kutular yerleştirilir.
- **🎯 Hedefleme ve Atış**: Oyuncu ekranına dokunarak hedefe top fırlatır.
- **⚙️ Gerçekçi Fizik ve Etkileşim**: Kutular top ile çarpışınca devrilir, fizik motoruyla dinamik tepki verir.
- **🏆 Puanlama Sistemi**: Hedefleri başarıyla vurdukça puan artar.
- **🎮 Sade Arayüz**: Küçük çocuklar için sade, kolay anlaşılır ve dokunmatik kontrollü yapı.

---

## 🧰 Gereksinimler

- Xcode 12 veya üzeri  
- Swift 5.0  
- iOS 14.0 veya üzeri  
- ARKit destekli iPhone cihazı (iPhone 7 veya üzeri)

---

## ⚙️ Kurulum ve Çalıştırma

1. Bu repoyu klonla veya ZIP olarak indir:
   ```bash
   git clone https://github.com/mustafa-krgoz/AR-Kutu-Patlatma-Oyunu.git
   ```
2. `KutulariYikAR.xcodeproj` dosyasını Xcode ile aç.
3. `Signing & Capabilities` kısmında kendi Apple Developer hesabını seç.
4. iPhone cihazını USB ile bağla.
5. Xcode’da sol üstten cihazını seçip `Cmd + R` ile projeyi çalıştır.

---

## 📱 Oynanış

- Uygulama açıldığında ARKit ortamı devreye girer.
- Düz yüzey algılandığında kutular otomatik olarak sahneye yerleştirilir.
- Ekrana dokunarak top atılır.
- Amaç: Tüm kutuları devirmek ve en yüksek skoru elde etmektir.

---

## 📁 Dosya Yapısı

- `Sources/` → Oyun mantığı ve ARKit bileşenleri  
- `Assets.xcassets/` → 3D modeller, ikonlar, materyaller  
- `Info.plist` → Uygulama izinleri (kamera vs)  
- `ARkitGame.xcodeproj/` → Xcode proje yapılandırması

---

## 📄 Teslim Belgeleri

| Belge Adı | Açıklama |
|-----------|----------|
| ARKutuPatlatma-Gereksinim-Analizi.docx | Fonksiyonel ve fonksiyonel olmayan gereksinimler |
| ARKutuPatlatma-Sistem-Mimarisi.docx | Katmanlı yapı, sınıf ilişkileri ve bileşenler |
| ARKutuPatlatma-Kurulum-Kilavuzu.docx | Xcode ve iPhone için kurulum adımları |
| ARKutuPatlatma-Kullanici-Kilavuzu.docx | Oyunun nasıl oynandığına dair kullanım adımları |
| ARKutuPatlatma-Test-Raporu.docx | Test senaryoları, başarı oranı ve sonuçlar |
| ARKutuPatlatma-Programci-Kilavuzu.docx | Kod yapısı, önemli sınıflar ve geliştirici notları |
| ARKutuPatlatma-Zaman-Cizelgesi.docx | Haftalık proje planı ve tamamlanma durumu |
| ARKutuPatlatma-Urün-Degerlendirme.docx | Hedeflere ulaşma değerlendirmesi |
| ARKutuPatlatma-Proje-Sunumu.pptx | Final sunum slaytları |
| ARKutuPatlatma-Class-Diagram.pdf | Sınıflar arası ilişkileri gösteren UML diyagramı |

---

## 🎥 APK Video Gösterimi

📽️ [Demo Videosu - YouTube'da İzle](https://www.youtube.com/shorts/yshWJ_DEKjo)

---

## 📋 Trello Panosu

📌 [AR Kutu Patlatma Oyunu - Trello Proje Takibi](https://trello.com/b/7gjRe2zo/ar-kutu-patlatma-oyunu-proje-takibi)

---

## 👨‍🎓 Geliştirici Bilgileri

Adı Soyadı: Halit Mustafa Karagöz
Öğrenci No: 200541043
Proje Dersi: Yazılım Mühendisliğinde Güncel Konular
Teslim Dönemi: Bahar 2025
