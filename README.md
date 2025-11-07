# BJI Wag-Com Seat Leon Project

## 🚗 Proje Özeti
**BJI Wag-Com Seat Leon** - 2016 Seat Leon Style paket için özel VAG-COM/VCDS diagnostik ve iletişim projesi

## 📅 Proje Bilgileri
- **Başlangıç Tarihi**: 7 Kasım 2025
- **Proje Türü**: Automotive Diagnostics
- **Hedef Araç**: 2016 Seat Leon Style Paket
- **Platform**: MQB (Modular Transverse Matrix)
- **Motor**: 1.2 TSI / 1.4 TSI / 1.6 TDI
- **İletişim Protokolü**: VAG-COM/VCDS
- **Repository**: 🔒 Private

## 🎯 Proje Hedefleri
- [ ] VAG-COM protokolü analizi
- [ ] Seat Leon ECU iletişimi
- [ ] Diagnostik kod okuma/yazma
- [ ] Gerçek zamanlı veri izleme
- [ ] Özelleştirilmiş diagnostik araçları

## 📁 Proje Yapısı
```
BJI-Wag-Com-Seat-Leon/
├── README.md                      (Bu dosya)
├── docs/                          (Dökümantasyon)
│   ├── vcds_parameters_guide.md  (Tüm VCDS parametreleri)
│   ├── vcds_coding_recipes.md    (Kodlama tarifleri)
│   └── ...
├── src/                           (Kaynak kodlar)
│   └── VcdsHelper/               (VCDS Helper konsol uygulaması)
│       ├── Program.cs            (Ana program)
│       ├── Models/               (Data modelleri)
│       ├── Services/             (Servisler)
│       ├── Data/                 (JSON veri dosyaları)
│       └── build.ps1             (Build script)
├── protocols/                     (Protokol tanımları)
├── logs/                          (Diagnostik logları)
├── config/                        (Konfigürasyon dosyaları)
└── tools/                         (Yardımcı araçlar)
```

## 🔧 Teknolojiler
- **Protokol**: VAG-COM/VCDS
- **Araç**: 2016 Seat Leon Style (5F1)
- **İletişim**: OBD-II / K-Line / CAN Bus
- **Platform**: Windows (varsayılan)
- **Konsol Uygulaması**: C# .NET 8.0 (VcdsHelper.exe)

## 🚀 VCDS Helper Konsol Uygulaması

Proje artık bir **Windows konsol uygulaması** içeriyor! Tüm VCDS parametrelerini, Leuchte kanallarını ve kodlama tariflerini görüntüleyebilirsiniz.

### Özellikler:
- ✅ Tüm VCDS parametrelerini görüntüleme
- ✅ Leuchte (ışık) kanallarını inceleme
- ✅ Kodlama tariflerini adım adım görme
- ✅ Parametre arama
- ✅ Kategori ve modül bazlı filtreleme
- ✅ Renkli ve kullanıcı dostu arayüz

### Kurulum ve Kullanım:

```powershell
# 1. Proje klasörüne gidin
cd "src\VcdsHelper"

# 2. Build script'i çalıştırın (EXE oluşturur)
.\build.ps1

# 3. Uygulamayı çalıştırın
.\bin\Release\net8.0\win-x64\publish\VcdsHelper.exe
```

Detaylı bilgi için: [VcdsHelper README](src/VcdsHelper/README.md)

## 📊 Güncel Durum
- ✅ Proje workspace oluşturuldu
- ✅ VCDS parametreleri dokümante edildi (vcds_parameters_guide.md)
- ✅ Kodlama tarifleri hazırlandı (vcds_coding_recipes.md)
- ✅ Windows konsol uygulaması geliştirildi (VcdsHelper.exe)
- ✅ **Leuchte Kodları Rehberi eklendi** (BLK/DIM/SLH açıklamaları)
- ✅ **Sayfalama sistemi** (20 tarif/sayfa navigasyon)
- ⏳ VCDS donanım bağlantı testleri
- ⏳ Gerçek araç testleri

## 📋 Version History

### **v1.0.4 (Beta)** - 8 Kasım 2025
**Yeni Özellikler:**
- ✅ **Sayfalama Sistemi**: Kodlama tarifleri artık 20'şerli sayfalarda gösteriliyor
  - << Önceki Sayfa / Sonraki Sayfa >> navigasyonu
  - Sayfa bilgisi göstergesi (Sayfa 1/2 - Toplam 29 tarif)
- ✅ **Leuchte Kodları Rehberi**: Ana menüye yeni bölüm eklendi
  - 🟡 **BLK Kodları**: BLK0-BLK10 (Yanıp sönme modları)
  - 🔵 **DIM Kodları**: DIM0-DIM10 (Parlaklık seviyeleri 0%-100%)
  - 🟢 **SLH Kodları**: Lamba tipi format açıklaması
  - 📖 **Almanca Sözlük**: 13 teknik terim çevirisi
  - 💡 **Örnek Kodlamalar**: 3 pratik senaryo
- ✅ **Dokümantasyon**: `leuchte_codes_guide.md` (300+ satır)
- 🔧 **İyileştirmeler**: Renk şeması optimizasyonu

**Teknik Detaylar:**
- EXE Boyutu: 34.11 MB
- Tarif Sayısı: 29 (genişletme planlanıyor)
- Framework: .NET 8.0
- UI Library: Spectre.Console v0.49.1

### **v1.0.3 (Beta)** - 7 Kasım 2025
- ✅ İlk sürüm: 30 kodlama tarifi
- ✅ 300+ VCDS parametresi
- ✅ Leuchte0-31 kanal tanımları
- ✅ Kategori bazlı filtreleme

## 🔗 İlgili Projeler
- [70V SMPS Project](../70V-SMPS-Project/) → Electronics/Power Management

---

**Son Güncelleme**: 8 Kasım 2025  
**Güncel Versiyon**: v1.0.4 (Beta)  
**Proje Durumu**: � Aktif Geliştirme