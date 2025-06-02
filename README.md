# 📦 AR Kutu Patlatma Oyunu

 ARKit kullanılarak Swift ile geliştirilen eğlenceli ve etkileşimli bir artırılmış gerçeklik (AR) oyunudur. Oyuncular, gerçek dünya ortamında sanal kutuları hedef alarak top fırlatır ve kutuları patlatmaya çalışır. Gerçekçi fizik, puanlama ve etkileşimli deneyim sunar.

---

## 🎯 Proje Amacı

- ARKit ile etkileşimli oyun tasarımı gerçekleştirmek  
- Fizik temelli kutu patlatma mekaniği geliştirmek  
- iOS platformunda gerçek dünya ile uyumlu oyun deneyimi sunmak  

---

## 🚀 Oyunun Özellikleri

- **Düzlem Algılama (Plane Detection)**: Cihazın kamerası ile düz yüzey algılanır.
- **Otomatik Kutular Yerleşimi**: Yüzey keşfedildiğinde kutular yerleştirilir.
- **Top ile Etkileşim**: Oyuncu ekrana dokunarak top fırlatır.
- **Gerçek Zamanlı Puanlama**: Kalan kutulara göre skor güncellenir.
- **Basit ve Eğlenceli Oynanış**: Minimum UI, maksimum etkileşim.

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
   git clone https://github.com/halitmustafakaragoz/KutulariYikAR.git
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

📽️ [Demo Videosu - YouTube'da İzle](https://www.youtube.com/shorts/_U19OS-dXWE)

---

## 📋 Trello Panosu

📌 [AR Kutu Patlatma Oyunu - Trello Proje Takibi](https://trello.com/b/7gjRe2zo/ar-kutu-patlatma-oyunu-proje-takibi)

---

## 👨‍🎓 Geliştirici Bilgileri

Adı Soyadı: Halit Mustafa Karagöz
Öğrenci No: 200541043
Proje Dersi: Yazılım Mühendisliğinde Güncel Konular
Teslim Dönemi: Bahar 2025
