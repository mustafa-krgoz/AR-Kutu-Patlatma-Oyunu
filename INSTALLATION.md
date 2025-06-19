# ⚙️ Kurulum Rehberi – AR Kutu Patlatma Oyunu

Bu doküman, **AR Kutu Patlatma Oyunu**'nun geliştirme ortamında nasıl çalıştırılacağını adım adım açıklamaktadır. Proje, Swift ve ARKit teknolojileri kullanılarak iOS platformu için geliştirilmiştir.

---

## 🧰 Gereksinimler

- macOS yüklü bir cihaz  
- Xcode 12 veya üzeri  
- iOS 14.0 veya üzeri bir iPhone (ARKit destekli: iPhone 7 ve üstü)  
- Apple Developer hesabı (test cihazında çalıştırmak için)  

---

## 🚀 Kurulum Adımları

### 1. Projeyi Klonla

```bash
git clone https://github.com/halitmustafakaragoz/AR-Kutu-Patlatma-Oyunu.git
```

### 2. Xcode ile Aç  
• Terminalden ya da Finder üzerinden `KutulariYikAR.xcodeproj` dosyasına çift tıklayarak projeyi Xcode ile aç.

### 3. Apple Developer Hesabını Ayarla  
• Xcode’da sol üstte yer alan proje adına tıkla.  
• `Signing & Capabilities` sekmesinde kendi Apple hesabını seç.

### 4. Cihazını Bağla  
• iPhone cihazını USB ile Mac’e bağla.  
• Hedef cihaz olarak iPhone’unu seç.

### 5. Build ve Çalıştır  
• Xcode sol üstte yer alan ▶️ tuşuna (veya `Cmd + R`) basarak projeyi derle ve cihazda çalıştır.

---

Uygulama başarıyla yüklendiğinde, cihazın kamerası ortamı tarar ve kutular otomatik olarak sahnede belirir. Oyuncu top fırlatarak kutuları devirmeye çalışır 🎯
