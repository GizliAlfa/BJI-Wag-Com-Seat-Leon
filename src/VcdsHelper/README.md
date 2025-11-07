# BJI VCDS Helper

**Versiyon: 1.0.4 (Beta)** - 8 Kasım 2025

2016 Seat Leon Style paket için VCDS parametreleri ve kodlama tarifleri görüntüleyici.

## 🚗 Özellikler

- ✅ **VCDS Parametreleri**: 28+ parametre ile tüm parametreleri kategori ve modül bazında görüntüleme
- ✅ **Leuchte Kanalları**: Işık/lamba kanallarını detaylı inceleme
- ✅ **Kodlama Tarifleri**: 29 kapsamlı kodlama tarifi - Aydınlatma, Güvenlik, Konfor, Klima, Silecek ve daha fazlası!
- ✅ **Sayfalama Sistemi**: 20 tarif/sayfa navigasyon sistemi (<< Önceki / Sonraki >>)
- ✅ **Leuchte Kodları Rehberi**: BLK/DIM/SLH kodlarının detaylı açıklamaları
- ✅ **Arama**: Parametre ve tarif arama
- ✅ **Renkli Konsol**: Spectre.Console ile kullanıcı dostu arayüz
- ✅ **Tek Dosya EXE**: Tüm veriler EXE içinde embedded - ek dosya gerektirmez
- ✅ **Windows Uyumlu**: Emoji yerine ASCII karakterler - tüm Windows sürümlerinde düzgün görüntülenir

## 📋 Gereksinimler

- .NET 8.0 SDK veya üzeri
- Windows 10/11

## 🔧 Kurulum

### Yöntem 1: Kaynak Koddan Derleme

```powershell
# Proje klasörüne gidin
cd "src\VcdsHelper"

# Projeyi derleyin
dotnet build -c Release

# Çalıştırın
dotnet run -c Release
```

### Yöntem 2: EXE Olarak Yayınlama (Önerilen)

```powershell
# Proje klasörüne gidin
cd "src\VcdsHelper"

# Tek dosya EXE olarak yayınla (tüm veriler embedded)
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:EnableCompressionInSingleFile=true -p:DebugType=None -p:DebugSymbols=false

# EXE dosyası şurada: bin\Release\net8.0\win-x64\publish\VcdsHelper.exe
# NOT: Data klasörüne ihtiyaç YOK - tüm veriler EXE içinde!
```

## 🚀 Kullanım

1. **VcdsHelper.exe** dosyasını çalıştırın (ek dosyaya gerek yok!)
2. Ana menüden istediğiniz seçeneği seçin:
   - **>** Tüm parametreleri görüntüle
   - **>** Leuchte (ışık) kanalları
   - **>** Kodlama tarifleri
   - **>** Parametre ara
   - **>** Kategoriye göre gör
   - **>** Modüle göre gör
   - **?** Hakkında
   - **X** Çıkış

## 📁 Proje Yapısı

```
src/VcdsHelper/
├── Program.cs              # Ana program
├── Models/
│   └── VcdsModels.cs      # Data modelleri
├── Services/
│   └── VcdsDataService.cs # Veri servisi
├── Data/                  # JSON veri dosyaları
│   ├── categories.json    # Kategoriler
│   ├── parameters.json    # Parametreler
│   ├── leuchte.json       # Leuchte kanalları
│   └── recipes.json       # Kodlama tarifleri
└── VcdsHelper.csproj      # Proje dosyası
```

## 📊 Veri Dosyaları

Tüm VCDS verileri **EXE içinde embedded** olarak saklanır (versiyon 1.0.2+):

- **categories.json**: Parametre kategorileri (9 kategori)
- **parameters.json**: VCDS parametreleri (28+ parametre)
- **leuchte.json**: Leuchte (ışık) kanalları
- **recipes.json**: Kodlama tarifleri

Kaynak kodda `Data/` klasöründeki JSON dosyalarını düzenleyerek yeni parametreler ekleyebilir veya mevcut olanları güncelleyebilirsiniz. Derleme sırasında bu dosyalar otomatik olarak EXE içine gömülür.

## 🎯 Hedef Araç

- **Model**: 2016 Seat Leon (5F1)
- **Platform**: MQB (Modular Transverse Matrix)
- **Paket**: Style
- **Motor**: 1.2 TSI / 1.4 TSI / 1.6 TDI / 2.0 TDI

## ⚠️ Önemli Uyarılar

- Bu uygulama sadece **bilgilendirme amaçlıdır**
- Araç kodlamalarını kendiniz yaparsanız sorumluluk size aittir
- Emin olmadığınız değişiklikleri yapmayın
- Kodlama öncesi mutlaka yedek alın
- Yasal gereksinimlere uygun hareket edin

## 🛠️ Geliştirme

### Yeni Parametre Ekleme

`Data/parameters.json` dosyasına yeni parametre ekleyin:

```json
{
  "Name": "Parametre_Adi",
  "Description": "Parametre açıklaması",
  "Category": "lighting",
  "Module": "09 - Central Electronics",
  "BytePosition": "Byte 0",
  "BitPosition": "Bit 0",
  "Values": [
    {
      "Value": "0",
      "Description": "Devre dışı",
      "IsRecommended": false
    },
    {
      "Value": "1",
      "Description": "Aktif",
      "IsRecommended": true
    }
  ],
  "DefaultValue": "0",
  "RecommendedValue": "1",
  "Notes": ["Notlar"],
  "RequiresHardware": false,
  "IsUnsure": false,
  "IsCritical": false
}
```

### Yeni Kodlama Tarifi Ekleme

`Data/recipes.json` dosyasına yeni tarif ekleyin.

## 📝 Lisans

Bu proje özel kullanım içindir. 2016 Seat Leon Style paket sahipleri için hazırlanmıştır.

## 👨‍💻 Geliştirici

**GizliAlfa**  
GitHub: [BJI-Wag-Com-Seat-Leon](https://github.com/GizliAlfa/BJI-Wag-Com-Seat-Leon)

## 📅 Versiyon Geçmişi

### **1.0.4 (Beta)** - 8 Kasım 2025
**Yeni Özellikler:**
- ✅ **Sayfalama Sistemi**: Kodlama tarifleri artık 20'şerli sayfalarda gösteriliyor
  - `<< Önceki Sayfa / Sonraki Sayfa >>` navigasyonu
  - Sayfa bilgisi göstergesi: "Sayfa X/Y - Toplam Z tarif"
  - Büyük tarif listeleri için optimize edilmiş UX
- ✅ **Leuchte Kodları Rehberi**: Ana menüye yeni bölüm eklendi
  - 🟡 **BLK Kodları (Yanıp Sönme)**: BLK0-BLK10 tüm blink modları
    - BLK0: No Blink (Sabit), BLK1: Slow Blink, BLK2: Normal, BLK3: Fast
    - BLK4: Double Flash, BLK5: Triple Flash, BLK6: Comfort Blink
    - BLK7: Fade In/Out, BLK8: Pulse, BLK9: Sequential, BLK10: Random
  - 🔵 **DIM Kodları (Parlaklık)**: DIM0-DIM10 parlaklık seviyeleri
    - DIM0: 0% (Kapalı), DIM1: 10%, DIM2: 20%, ... DIM10: 100% (Maksimum)
  - 🟢 **SLH Kodları (Lamba Tipi)**: Format açıklaması ve örnekler
    - Format: [Modül]-[Çıkış]-[Lamba Tipi]
    - Örnek: C16-Heckleuchte links SL LC7
  - 📖 **Almanca Sözlük**: 13 teknik terim Türkçe çevirisi
    - Standlicht, Begrenzunglicht, Tagfahrlicht, Abblendlicht, vb.
  - 💡 **Örnek Kodlamalar**: 3 pratik senaryo
    - Coming Home 30 saniye, DRL aktif, Dinamik Sinyal
- ✅ **Kapsamlı Dokümantasyon**: `docs/leuchte_codes_guide.md` (300+ satır)
  - Leuchte0-31 kanal tanımları
  - Güvenlik uyarıları ve yasal gereklilikler
  - Detaylı kod tabloları

**Teknik İyileştirmeler:**
- EXE Boyutu: 34.11 MB (önceki: ~35 MB)
- Tarif Sayısı: 29 (kalite odaklı)
- Renkli tablo border'ları kaldırıldı (performans)

### **1.0.3 (Beta)** - 8 Kasım 2025
- ✅ **29 Kodlama Tarifi Eklendi!** (önceki: 9)
  - 7 Aydınlatma tarifi (Coming Home, DRL, Viraj Lambası, Amerikan Park, Dinamik Sinyal, Otoyol Farı, vb.)
  - 6 Güvenlik tarifi (Otomatik Kilit, Çift Kademeli Açma, Kilitleme Sesi, Safe Lock, vb.)
  - 5 Konfor tarifi (Uzaktan Cam Açma, Ayna Eğilme, Ayna Katlanma, Tek Dokunuş Cam, vb.)
  - 2 Silecek tarifi (Geri Viteste Arka Silecek, Yağmur Sensörü)
  - 5 Menü ve Gösterge tarifi (İğne Tarama, Dijital Hız, Hız Uyarısı, Vites Önerisi, Kemer Uyarısı)
  - 2 Klima tarifi (Otomatik Buğu Çözme, Varsayılan Sıcaklık)
  - 2 Diğer (Cruise Control, Park Sensörü)
- ✅ Her tarifde detaylı adımlar, uyarılar ve donanım gereksinimleri
- ✅ Zorluk seviyeleri: Kolay (0), Orta (1), Zor (2), Uzman (3)

### **1.0.2 (Beta)** - 8 Kasım 2025
- ✅ Tüm veriler EXE içinde embedded (Data klasörüne gerek yok)
- ✅ Emoji yerine ASCII karakterler (Windows uyumluluğu)
- ✅ 28+ parametre eklendi (önceki: 6)
- ✅ 9 kategori sistemi
- ✅ Daha iyi kullanıcı deneyimi

### **1.0.1** - 7 Kasım 2025
- ✅ İlk genişletilmiş parametre seti
- ✅ Kategori sistemi
- ✅ Leuchte kanalları

### **1.0.0** - 7 Kasım 2025
- ✅ İlk sürüm
- ✅ Temel parametre görüntüleme
- ✅ Kodlama tarifleri

---

**Not**: VCDS kodlamaları araç güvenliğini etkileyebilir. Tüm değişiklikler kendi sorumluluğunuzdadır.
