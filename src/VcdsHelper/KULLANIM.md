# VCDS Helper - Hızlı Başlangıç Kılavuzu

## 🎯 EXE Dosyasını Nasıl Oluştururum?

### Yöntem 1: Otomatik Build Script (Önerilen)

1. **PowerShell'i açın** (Windows tuşu + X → Windows PowerShell)

2. **Proje klasörüne gidin:**
   ```powershell
   cd "C:\Users\Oktay\Documents\Çalışmalar\BJI-Wag-Com-Seat-Leon\src\VcdsHelper"
   ```

3. **Build script'i çalıştırın:**
   ```powershell
   .\build.ps1
   ```

4. **Bekleyin** (İlk seferde birkaç dakika sürebilir - NuGet paketleri indiriliyor)

5. **Tamamlandığında:**
   - EXE dosyası: `bin\Release\net8.0\win-x64\publish\VcdsHelper.exe`
   - Script size dosyayı kopyalamak isteyip istemediğinizi soracak

### Yöntem 2: Manuel Derleme

1. **PowerShell'i açın**

2. **Proje klasörüne gidin:**
   ```powershell
   cd "C:\Users\Oktay\Documents\Çalışmalar\BJI-Wag-Com-Seat-Leon\src\VcdsHelper"
   ```

3. **Tek komutla derleyin:**
   ```powershell
   dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
   ```

4. **EXE konumu:**
   ```
   bin\Release\net8.0\win-x64\publish\VcdsHelper.exe
   ```

## 🚀 Uygulamayı Nasıl Çalıştırırım?

### Seçenek 1: Doğrudan Çalıştırma

1. Dosya Gezgini'nde şu konuma gidin:
   ```
   C:\Users\Oktay\Documents\Çalışmalar\BJI-Wag-Com-Seat-Leon\src\VcdsHelper\bin\Release\net8.0\win-x64\publish\
   ```

2. **VcdsHelper.exe** dosyasına çift tıklayın

### Seçenek 2: PowerShell'den Çalıştırma

```powershell
cd "C:\Users\Oktay\Documents\Çalışmalar\BJI-Wag-Com-Seat-Leon\src\VcdsHelper\bin\Release\net8.0\win-x64\publish"
.\VcdsHelper.exe
```

## 📋 Uygulama Menüleri

### Ana Menü:
1. **📋 Tüm Parametreleri Görüntüle** - Tüm VCDS parametrelerini listeler
2. **🔦 Leuchte (Işık) Kanalları** - Leuchte0-31 arasındaki kanalları gösterir
3. **🎯 Kodlama Tarifleri** - Adım adım kodlama talimatları
4. **🔍 Parametre Ara** - Anahtar kelime ile arama yapın
5. **📂 Kategoriye Göre Gör** - Aydınlatma, Konfor, vb.
6. **🎛️ Modüle Göre Gör** - 09, 17, 46, vb. modüllere göre filtrele
7. **ℹ️ Hakkında** - Uygulama bilgileri
8. **🚪 Çıkış** - Uygulamadan çık

## 🎨 Özellikler

- ✅ **Renkli Arayüz**: Spectre.Console ile güzel görünüm
- ✅ **Kolay Navigasyon**: Ok tuşları ile menülerde gezinme
- ✅ **Arama**: Hızlı parametre bulma
- ✅ **Filtreleme**: Kategori ve modül bazlı görüntüleme
- ✅ **Detaylı Bilgi**: Her parametre için açıklama, default ve önerilen değerler
- ✅ **Uyarılar**: Donanım gerektiren veya kritik parametrelerde uyarı

## ⚙️ Veri Dosyalarını Düzenleme

Tüm veriler JSON formatında `Data/` klasöründe:

```
src/VcdsHelper/Data/
├── categories.json    # Kategoriler
├── parameters.json    # VCDS parametreleri
├── leuchte.json       # Leuchte kanalları
└── recipes.json       # Kodlama tarifleri
```

Bu dosyaları herhangi bir metin editörü (Notepad++, VS Code, vb.) ile düzenleyebilirsiniz.

## ❓ Sorun Giderme

### "dotnet komutu bulunamadı" hatası

**Çözüm:** .NET 8.0 SDK'yı yükleyin:
1. https://dotnet.microsoft.com/download adresine gidin
2. .NET 8.0 SDK'yı indirin ve kurun
3. Bilgisayarı yeniden başlatın

### "Script çalıştırma devre dışı" hatası

**Çözüm:** PowerShell execution policy'yi ayarlayın:
```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```

### EXE dosyası büyük (40+ MB)

**Normal:** Self-contained (kendi başına çalışan) EXE tüm .NET runtime'ı içerir. Herhangi bir bilgisayarda .NET yüklü olmadan çalışır.

### Data klasörü bulunamıyor

**Çözüm:** 
- EXE dosyası ile aynı klasörde `Data/` klasörü olmalı
- Veya build script'i çalıştırın, otomatik kopyalar

## 📞 Yardım

Sorun yaşarsanız:
1. README.md dosyalarını okuyun
2. GitHub Issues'da sorun açın
3. Kodları kontrol edin (src/VcdsHelper/)

## 🎯 Sonraki Adımlar

1. ✅ Uygulamayı derleyin
2. ✅ Çalıştırın ve menüleri inceleyin
3. ✅ Parametreleri görüntüleyin
4. ✅ Kodlama tariflerini okuyun
5. 🚗 VCDS ile gerçek araçta test edin (dikkatli olun!)

---

**Önemli:** Bu uygulama sadece bilgilendirme amaçlıdır. Araç kodlamaları kendi sorumluluğunuzdadır.
