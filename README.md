# 🧑‍🍳 AR Mini Şef

AR destekli, küçük çocuklara yönelik adım-adım yemek yapma oyunu.

Bu proje, küçük çocuklara algoritmik düşünme becerisi kazandırmak amacıyla geliştirilmiş, mobil tabanlı bir Artırılmış Gerçeklik (AR) oyunudur. Çocuklar, ekranda beliren 3D yemek malzemelerini doğru sırayla kullanarak çeşitli tarifleri hazırlamayı öğrenir.

📋 Proje sürecini adım adım takip etmek için:
🔗 https://trello.com/b/7gjRe2zo/ar-mini-sef-proje-takibi

---

## 🎯 Amaç

- Çocuklara sırayla işlem yapma (algoritmik düşünme) öğretmek  
- Etkileşimli bir öğrenme ortamı sunmak  
- Görsel ve işitsel geri bildirimlerle dikkat süresini artırmak

---

## 🔧 Özellikler

- 📷 AR kamera ile gerçek dünyada sanal yemek malzemelerini görüntüleme  
- 🧩 Görevler: Reçelli ekmek, salata, muzlu süt gibi tarifleri doğru sırayla yapma  
- 🔊 Sesli ve görsel geri bildirim sistemi  
- ⭐ Rozet ve yıldız sistemi ile ilerleme motivasyonu  
- 👶 Renkli ve sade tasarım, küçük çocuklara uygun arayüz

---

## 💻 Kullanılan Teknolojiler

- Unity 2021.3.16f1 (LTS)  
- C#  
- AR Foundation (ARKit ile iOS desteği)  
- Sketchfab / TurboSquid (3D modeller)  
- Unity AudioSource (ses efektleri)  
- Unity Raycasting (kullanıcı etkileşimi)

---

---

## ⚙️ Kurulum ve Çalıştırma Kılavuzu

Bu kılavuz, AR Mini Şef mobil uygulamasını sıfırdan derleyip çalıştırmak isteyenler için hazırlanmıştır.

---

### 🧰 Gereksinimler

- Unity Hub (önerilen sürüm: 2021.3.16f1 LTS)
- Xcode (iOS için, önerilen: 14 veya üzeri)
- Apple Developer hesabı (test amaçlı)
- iPhone cihazı
- Git yüklü sistem

---

## 🧱 Projenin Kurulumu

1. Bu repoyu klonlayın:

   ```bash
   git clone https://github.com/mustafa-krgoz/AR-Mini-Sef.git
   cd AR-Mini-Sef	
2.	Unity Hub’ı açın ve AR-Mini-Sef klasörünü Add butonuyla projeye ekleyin.
3.	Unity’de proje açıldığında, sahnede yer alan SampleScene’i açın:
Assets > Scenes > SampleScene.unity
4.	File > Build Settings > iOS platformunu seçin ve Switch Platform yapın.


---

## 📱 iOS Build Alma

1. File > Build Settings‘ten iOS platformunu seçin ve sahneyi build’e ekleyin.
2. Build tuşuna basarak build klasörü oluşturun (örneğin: ARMiniSefBuild).
3. Oluşan .xcodeproj dosyasını Xcode ile açın.
4. Signing & Capabilities sekmesinden Apple hesabınızı seçin.
5. iPhone’unuzu bağlayın, Xcode üzerinden Cmd + R yaparak uygulamayı çalıştırın.

---

## 📁 Klasör Yapısı

- `Assets/` → Tüm oyun içeriği ve sahneler  
- `Packages/` → Unity paket yönetimi  
- `ProjectSettings/` → Proje yapılandırmaları  
- `docs/` → Dökümantasyon dosyaları (gereksinim, test, sunum, vb.)

---

## 📄 Teslim Belgeleri

- ARMiniSefGereksinimAnalizi.docx  
- AR_Mini_Sef_Alfa_Beta_Surum_Raporu.docx  
- AR_Mini_Sef_Haftalik_Durum_Toplantilari.docx  
- AR_Mini_Sef_Kullanici_Kilavuzu.docx  
- AR_Mini_Sef_Kurulum_Kilavuzu_Guncel.docx  
- AR_Mini_Sef_Programci_Kilavuzu.docx  
- AR_Mini_Sef_Proje_Genel_Bakis.docx  
- AR_Mini_Sef_Proje_Sunumu.pptx  
- AR_Mini_Sef_Prototip_Sahne_Mockup_Belgesi.docx  
- AR_Mini_Sef_Sistem_Mimarisi.docx  
- AR_Mini_Sef_Takim_Rehberi_Bireysel_Katki.docx  
- AR_Mini_Sef_Test_Raporu.docx  
- AR_Mini_Sef_Urun_Degerlendirme_Belgesi.docx  
- AR_Mini_Sef_Zaman_Cizelgesi.docx  
- RAMS Tasarım İlkeleri.docx  
- Class Diagram.pdf  
- SequenceDiagram.pdf  
- UseCase Diagram.pdf

---

## 👨‍🎓 Geliştirici

**Adı Soyadı:** Halit Mustafa Karagöz  
**Öğrenci No:** 200541043  
**Proje Dersi:** Yazılım Mühendisliğinde Güncel Konular  
**Teslim Dönemi:** Bahar 2025
