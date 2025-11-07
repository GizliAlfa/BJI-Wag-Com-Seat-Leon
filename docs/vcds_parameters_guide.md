# VCDS Parametreleri - 2016 Seat Leon Style Paket

## 📋 İçindekiler
- [Leuchte (Işık/Lamba Kanalları) - Genel Bakış](#leuchte-ışıklamba-kanalları---genel-bakış)
- [Diğer Önemli Parametreler](#diğer-önemli-parametreler)
  - [Klemmen (Terminal/Kontak Pozisyonları)](#klemmen-terminalkontak-pozisyonları)
  - [Wischer (Silecek Sistemleri)](#wischer-silecek-sistemleri)
  - [Fenster (Cam Sistemleri)](#fenster-cam-sistemleri)
  - [Spiegel (Ayna Sistemleri)](#spiegel-ayna-sistemleri)
  - [Tuer (Kapı Sistemleri)](#tuer-kapı-sistemleri)
  - [Sitze (Koltuk Sistemleri)](#sitze-koltuk-sistemleri)
  - [Klima (İklim Kontrolü)](#klima-i̇klim-kontrolü)
  - [Menu (Menü Ayarları)](#menu-menü-ayarları)
- [09 - Central Electronics (Merkezi Elektronik)](#09---central-electronics)
- [17 - Instrument Cluster (Gösterge Paneli)](#17---instrument-cluster)
- [19 - CAN Gateway](#19---can-gateway)
- [46 - Central Comfort System](#46---central-comfort-system)
- [5F - Information Electronics](#5f---information-electronics)
- [55 - Headlight Range Control](#55---headlight-range-control)
- [08 - Air Conditioning](#08---air-conditioning)

---

## Leuchte (Işık/Lamba Kanalları) - Genel Bakış

### 🔦 Leuchte Nedir?

**Leuchte** (Almanca: Işık/Lamba) parametreleri, araçtaki her bir aydınlatma kanalının davranışını kontrol eder. 2016 Seat Leon'da genellikle **Leuchte0** ile **Leuchte31** arasında toplam 32 kanal bulunur.

Her Leuchte kanalı için 3 ana parametre ayarlanır:
1. **Leuchte[X]SLH** - Lamba tipi ve konumu
2. **Leuchte[X]BLK** - Yanıp sönme davranışı (Blink)
3. **Leuchte[X]DIM** - Karartma/Dimming seviyesi

---

### 📍 Leuchte Kanal Atamaları (2016 Leon Style)

#### **Leuchte0 - Leuchte15 (Ön ve Yan Işıklar)**

| Kanal | İsim | Konum/Fonksiyon | Açıklama |
|-------|------|-----------------|----------|
| **Leuchte0** | Left Low Beam | Sol Kısa Far | Halogen/Xenon/LED kısa far sol |
| **Leuchte1** | Right Low Beam | Sağ Kısa Far | Halogen/Xenon/LED kısa far sağ |
| **Leuchte2** | Left High Beam | Sol Uzun Far | Uzun far sol |
| **Leuchte3** | Right High Beam | Sağ Uzun Far | Uzun far sağ |
| **Leuchte4** | Left DRL | Sol Gündüz Farı | DRL (Daytime Running Light) sol |
| **Leuchte5** | Right DRL | Sağ Gündüz Farı | DRL sağ |
| **Leuchte6** | Left Turn Signal Front | Sol Ön Sinyal | Ön sol sinyal lambası |
| **Leuchte7** | Right Turn Signal Front | Sağ Ön Sinyal | Ön sağ sinyal lambası |
| **Leuchte8** | Left Side Marker | Sol Yan Sinyal | Ayna üzeri sinyal sol |
| **Leuchte9** | Right Side Marker | Sağ Yan Sinyal | Ayna üzeri sinyal sağ |
| **Leuchte10** | Left Front Fog Light | Sol Ön Sis Farı | Ön sis farı sol (Style standart) |
| **Leuchte11** | Right Front Fog Light | Sağ Ön Sis Farı | Ön sis farı sağ |
| **Leuchte12** | Left Parking Light | Sol Park Lambası | Park lambası sol |
| **Leuchte13** | Right Parking Light | Sağ Park Lambası | Park lambası sağ |
| **Leuchte14** | Left Cornering Light | Sol Viraj Işığı | Viraj aydınlatması sol ⚠️ *Opsiyonel* |
| **Leuchte15** | Right Cornering Light | Sağ Viraj Işığı | Viraj aydınlatması sağ ⚠️ *Opsiyonel* |

#### **Leuchte16 - Leuchte23 (Arka Işıklar)**

| Kanal | İsim | Konum/Fonksiyon | Açıklama |
|-------|------|-----------------|----------|
| **Leuchte16** | Left Tail Light | Sol Arka Stop | Arka stop lambası sol |
| **Leuchte17** | Right Tail Light | Sağ Arka Stop | Arka stop lambası sağ |
| **Leuchte18** | Left Brake Light | Sol Fren Lambası | Fren lambası sol |
| **Leuchte19** | Right Brake Light | Sağ Fren Lambası | Fren lambası sağ |
| **Leuchte20** | Left Turn Signal Rear | Sol Arka Sinyal | Arka sinyal lambası sol |
| **Leuchte21** | Right Turn Signal Rear | Sağ Arka Sinyal | Arka sinyal lambası sağ |
| **Leuchte22** | Left Reverse Light | Sol Geri Vites Lambası | Geri vites lambası sol |
| **Leuchte23** | Right Reverse Light | Sağ Geri Vites Lambası | Geri vites lambası sağ |

#### **Leuchte24 - Leuchte31 (İç ve Ek Işıklar)**

| Kanal | İsim | Konum/Fonksiyon | Açıklama |
|-------|------|-----------------|----------|
| **Leuchte24** | Rear Fog Light | Arka Sis Farı | Arka sis lambası (genelde sağda) |
| **Leuchte25** | License Plate Light | Plaka Aydınlatması | Arka plaka lambası |
| **Leuchte26** | Third Brake Light | Üçüncü Stop | Arka camda üçüncü stop lambası |
| **Leuchte27** | Interior Light Front | Ön İç Tavan Lambası | Ön iç aydınlatma |
| **Leuchte28** | Interior Light Rear | Arka İç Tavan Lambası | Arka iç aydınlatma |
| **Leuchte29** | Footwell Light | Ayak Alanı Aydınlatması | Ayak alanı lambası ⚠️ *Opsiyonel* |
| **Leuchte30** | Ambient Light | Ambient Işık | İç ambient aydınlatma ⚠️ *Üst paketlerde* |
| **Leuchte31** | Additional Functions | Ek Fonksiyonlar | Özel kodlamalar için |

---

### 🔧 Leuchte Parametreleri Detayları

#### **LeuchteXSLH - Lamba Tipi ve Konumu**

Bu parametre lambanın **fiziksel tipini** ve **hangi modülde** olduğunu belirtir.

**Format**: `[Modül]-[Çıkış]-[Tip]`

**Yaygın Değerler:**

| Value | Açıklama | Örnek Kullanım |
|-------|----------|----------------|
| `0` | Devre dışı / Lamba yok | Kullanılmayan kanallar |
| `1` | Aktif - Standart lamba | Basit on/off lambalar |
| `2` | LED modül | LED DRL, LED kuyruk lambaları |
| `3` | Xenon modül | Xenon farlar (varsa) |
| `4` | Halogen | Standart halogen ampuller |
| `5` | Aktif - Dimming destekli | Karartılabilir lambalar |
| `6` | CAN kontrollü | CAN bus üzerinden kontrol |
| `7` | PWM kontrollü | PWM (Pulse Width Modulation) ile |

**Örnek Kodlar (2016 Leon için):**
```
Leuchte0SLH = C1-58-05  → Sol kısa far, Halogen, Dimming
Leuchte4SLH = C1-42-02  → Sol DRL, LED modül
Leuchte10SLH = C1-35-01 → Sol sis farı, Standart
Leuchte27SLH = C2-12-05 → İç tavan lambası, Dimming
```

---

#### **LeuchteXBLK - Yanıp Sönme Davranışı (Blink)**

Bu parametre lambanın **nasıl yanıp söneceğini** kontrol eder.

**Blink Kodları:**

| Code | İsim | Davranış | Kullanım Alanı |
|------|------|----------|----------------|
| **BLK0** | No Blink | Sabit yanar, yanıp sönmez | Farlar, park lambaları, iç aydınlatma |
| **BLK1** | Slow Blink | Yavaş yanıp sönme (0.5 Hz) | Uyarı lambaları |
| **BLK2** | Normal Blink | Normal yanıp sönme (1 Hz) | **Sinyal lambaları (standart)** |
| **BLK3** | Fast Blink | Hızlı yanıp sönme (2 Hz) | Arıza durumu, uyarı |
| **BLK4** | Double Flash | Çift flaş | Özel efektler |
| **BLK5** | Triple Flash | Üç kez yanıp sönme | Şerit değiştirme (tek dokunuş sinyal) |
| **BLK6** | Comfort Blink | Konfor yanıp sönme | Şerit değiştirme konfor sinyal (3x yanıp söner) |
| **BLK7** | Fade In/Out | Yumuşak açılma/kapanma | Coming/Leaving home, modern LED efektler |
| **BLK8** | Pulse | Nabız gibi | Alarm lambası |
| **BLK9** | Random | Rastgele | Kullanılmaz genelde |
| **BLK10** | Sequential | Sıralı yanma | Sıralı sinyal (Dinamik sinyal) ⚠️ *Üst modellerde* |

**Tipik Kullanım Örnekleri:**
```
Leuchte0BLK = BLK0     → Kısa far (sabit yanar)
Leuchte6BLK = BLK2     → Ön sinyal (normal yanıp sönme)
Leuchte10BLK = BLK0    → Sis farı (sabit)
Leuchte27BLK = BLK7    → İç lamba (yumuşak aç/kapa)
Leuchte14BLK = BLK0    → Viraj lambası (sabit)
```

---

#### **LeuchteXDIM - Karartma/Dimming Seviyesi**

Bu parametre lambanın **parlaklık seviyesini** ayarlar (PWM kontrol ile).

**Dimming Değerleri:**

| Value | Parlaklık | Yüzde | Kullanım |
|-------|-----------|-------|----------|
| **DIM0** | Kapalı | 0% | Lamba tamamen kapalı |
| **DIM1** | Çok Düşük | 10% | Gece modu iç lambalar |
| **DIM2** | Düşük | 20% | Park lambaları |
| **DIM3** | Orta-Düşük | 30% | DRL gündüz modu |
| **DIM4** | Orta | 40% | - |
| **DIM5** | Orta | 50% | Yarı güç |
| **DIM6** | Orta-Yüksek | 60% | - |
| **DIM7** | Yüksek | 70% | - |
| **DIM8** | Çok Yüksek | 80% | - |
| **DIM9** | Maksimum | 90% | - |
| **DIM10** | Tam Güç | 100% | Farlar, sinyal, fren lambaları |

**Özel Dimming Modları:**

| Code | Açıklama |
|------|----------|
| **DIM_AUTO** | Otomatik (Gece/gündüz sensörüne göre) |
| **DIM_AD** | Adaptif dimming (Duruma göre) |

**Tipik Kullanım Örnekleri:**
```
Leuchte0DIM = DIM10    → Kısa far (tam güç)
Leuchte4DIM = DIM7     → DRL (70% parlaklık)
Leuchte12DIM = DIM3    → Park lambası (30%)
Leuchte27DIM = DIM5    → İç lamba (50% - yumuşak)
Leuchte29DIM = DIM2    → Ayak aydınlatma (20% - çok yumuşak)
```

---

### 🎯 Leuchte Kodlama Örnekleri (2016 Leon Style)

#### **Örnek 1: Ön Sinyal Lambasını Yapılandırma**
```
Leuchte6 - Sol Ön Sinyal (Left Front Turn Signal)
├─ Leuchte6SLH = C1-28-01  (Standart lamba, Modul C1, Çıkış 28)
├─ Leuchte6BLK = BLK2      (Normal yanıp sönme, 1 Hz)
└─ Leuchte6DIM = DIM10     (Tam güç, %100)
```

#### **Örnek 2: Gündüz Farını (DRL) Aktifleştirme**
```
Leuchte4 - Sol DRL (Left Daytime Running Light)
├─ Leuchte4SLH = C1-42-02  (LED modül)
├─ Leuchte4BLK = BLK0      (Sabit yanma, yanıp sönmez)
└─ Leuchte4DIM = DIM7      (70% parlaklık - yasal gereksinim)
```

#### **Örnek 3: Coming Home Lambası**
```
Leuchte0 - Kısa Far Coming Home için
├─ Leuchte0SLH = C1-58-05  (Halogen, dimming destekli)
├─ Leuchte0BLK = BLK7      (Yumuşak fade in/out)
└─ Leuchte0DIM = DIM4      (40% parlaklık - gece için uygun)
```

#### **Örnek 4: Sis Farını Viraj Lambası Olarak Kullanma**
```
Leuchte10 - Sol Sis Farı → Viraj Lambası
├─ Leuchte10SLH = C1-35-01 (Standart lamba)
├─ Leuchte10BLK = BLK0     (Sabit yanma)
├─ Leuchte10DIM = DIM10    (Tam güç)
└─ Ek Kodlama: Viraj sensörlü aktivasyon (Byte 3'te ayarlanır)
```

#### **Örnek 5: İç Tavan Lambasını Yumuşak Açma/Kapama**
```
Leuchte27 - Ön İç Tavan Lambası
├─ Leuchte27SLH = C2-12-05 (Dimming destekli iç lamba)
├─ Leuchte27BLK = BLK7     (Fade in/out - yumuşak geçiş)
└─ Leuchte27DIM = DIM5     (50% parlaklık)
```

#### **Örnek 6: Dinamik Sinyaller (Sequential) ⚠️**
*Not: Bu özellik Style pakette standart değil, LED sinyal modülleri gerektirir*
```
Leuchte6 - Dinamik Sol Ön Sinyal
├─ Leuchte6SLH = C1-28-02  (LED modül gerekli)
├─ Leuchte6BLK = BLK10     (Sequential - sıralı yanma)
└─ Leuchte6DIM = DIM10     (Tam güç)
```

---

### 🔍 Leuchte Kodlama Adımları (VCDS)

#### **VCDS ile Leuchte Kodlama:**

1. **VCDS Başlat** → OBD bağlantısını yap
2. **Select** → `09 - Central Electronics`
3. **Coding - 07** → Seç
4. **Long Coding Helper** → Aç
5. İlgili **Leuchte kanalını** bul (örn: Leuchte4)
6. **SLH, BLK, DIM** değerlerini ayarla
7. **Do It!** → Kaydet
8. **Close Controller** → Çık
9. **Test et!** → Işıkları kontrol et

---

### ⚠️ Önemli Uyarılar - Leuchte Kodlama

#### **Yasal Gereksinimler:**
- 🔴 **DRL (Gündüz Farı)**: AB'de yasal zorunluluk (2016 sonrası)
- 🔴 **Sinyal Frekansı**: 90 flaş/dakika standart (BLK2 kullanın)
- 🔴 **Far Parlaklığı**: Kısa/uzun far tam güçte olmalı (DIM10)
- 🔴 **Fren Lambası**: Arka fren lambası çift taraflı, tam güç (DIM10)

#### **Teknik Kısıtlamalar:**
- LED modül yoksa LED kodu kullanmayın (ampul yanar ama çabuk bozulur)
- Xenon modül yoksa Xenon kodu kullanmayın
- Dimming desteklemeyen lambalara DIM ayarı yapmayın (çalışmaz)

#### **Güvenlik:**
- ❌ Fren lambalarını asla dim yapmayın (DIM10 olmalı)
- ❌ Sinyal lambalarını çok hızlı/yavaş yapmayın (BLK2 standart)
- ❌ Farları yanıp sönen mod yapmayın (BLK0 olmalı)
- ⚠️ Gündüz farı çok parlak olmamalı (DIM7 ideal, DIM10 fazla)

---

### 📊 Leuchte Durum Kontrol Tablosu (2016 Leon Style)

#### **Standart Konfigürasyon:**

| Leuchte | Fonksiyon | SLH | BLK | DIM | Durum |
|---------|-----------|-----|-----|-----|-------|
| **0** | Sol Kısa Far | C1-58-05 | BLK0 | DIM10 | ✅ Standart |
| **1** | Sağ Kısa Far | C1-59-05 | BLK0 | DIM10 | ✅ Standart |
| **4** | Sol DRL | C1-42-02 | BLK0 | DIM7 | ✅ LED varsa |
| **5** | Sağ DRL | C1-43-02 | BLK0 | DIM7 | ✅ LED varsa |
| **6** | Sol Ön Sinyal | C1-28-01 | BLK2 | DIM10 | ✅ Standart |
| **7** | Sağ Ön Sinyal | C1-29-01 | BLK2 | DIM10 | ✅ Standart |
| **10** | Sol Sis Farı | C1-35-01 | BLK0 | DIM10 | ✅ Style standart |
| **11** | Sağ Sis Farı | C1-36-01 | BLK0 | DIM10 | ✅ Style standart |
| **14** | Viraj Lambası | - | - | - | ❌ Style'da yok |
| **16** | Sol Arka Stop | C2-51-01 | BLK0 | DIM3 | ✅ Standart |
| **18** | Sol Fren | C2-51-01 | BLK0 | DIM10 | ✅ Standart |
| **20** | Sol Arka Sinyal | C2-54-01 | BLK2 | DIM10 | ✅ Standart |
| **24** | Arka Sis | C2-58-01 | BLK0 | DIM10 | ✅ Standart |
| **27** | İç Tavan Ön | C2-12-05 | BLK7 | DIM5 | ✅ Standart |

---

### 💡 Popüler Leuchte Modifikasyonları

#### **1. Sis Farını Viraj Lambası Yapmak**
```
Değişiklik: Leuchte10 (Sol Sis) ve Leuchte11 (Sağ Sis)
Amaç: Direksiyon kırıldığında ilgili taraf sis farı yanar

Adımlar:
- Leuchte10BLK = BLK0 (değiştirme)
- Leuchte10DIM = DIM10 (değiştirme)
- Byte 3, Bit 0-1 = 1 (Sis farı ile viraj lambası aktif)
```

#### **2. DRL Aktivasyonu (LED DRL varsa)**
```
Değişiklik: Leuchte4 ve Leuchte5
Amaç: Gündüz farlarını aktif etmek

Adımlar:
- Leuchte4SLH = C1-42-02 (LED modül)
- Leuchte4BLK = BLK0
- Leuchte4DIM = DIM7 (70% - yasal standart)
- Byte 0, Bit 0 = 1 (DRL aktif)
```

#### **3. Coming Home Süre Uzatma**
```
Değişiklik: Leuchte0, Leuchte1 (Kısa farlar)
Amaç: Aracı kilitlediğinde farlar 60 saniye açık kalsın

Adımlar:
- Leuchte0BLK = BLK7 (Yumuşak söner)
- Leuchte0DIM = DIM4 (40% parlaklık)
- Byte 1, Bit 0-2 = 5 (60 saniye)
```

#### **4. Şerit Değiştirme Sinyali (Comfort Blink)**
```
Değişiklik: Sinyal lambaları
Amaç: Sinyal koluna hafif dokunca 3 kez yanıp sönsün

Adımlar:
- Leuchte6BLK = BLK6 (Comfort blink)
- Leuchte7BLK = BLK6 (Comfort blink)
- Sinyal sayısı: 3x (genelde varsayılan)
```

#### **5. İç Aydınlatma Yumuşak Geçiş**
```
Değişiklik: Leuchte27, Leuchte28 (İç lambalar)
Amaç: Kapı açıldığında yumuşak açılsın/kapansın

Adımlar:
- Leuchte27BLK = BLK7 (Fade in/out)
- Leuchte27DIM = DIM5 (50% - göz yormaz)
- Byte 8, Bit 0-2 = 3 (20 saniye açık kalsın)
```

---

### 🛠️ Troubleshooting (Sorun Giderme)

#### **Lamba Yanarken Hata Kodu**
**Sebep**: Yanlış SLH kodu (lamba tipi uyumsuz)  
**Çözüm**: SLH kodunu kontrol edin, fiziksel lambayla eşleşmeli

#### **Lamba Çok Sönük**
**Sebep**: DIM değeri çok düşük  
**Çözüm**: DIM10 yapın (tam güç)

#### **Sinyal Çok Hızlı Yanıp Sönüyor**
**Sebep**: BLK3 (Fast blink) seçilmiş  
**Çözüm**: BLK2 (Normal blink) yapın

#### **DRL Aktif Ama Çalışmıyor**
**Sebep**: LED modül yok ama LED kodu girilmiş  
**Çözüm**: Halogen için SLH kodunu değiştirin veya LED modül takın

#### **Viraj Lambası Çalışmıyor**
**Sebep**: Byte 3'te viraj fonksiyonu aktif değil  
**Çözüm**: Byte 3, Bit 0-1 = 1 yapın

---

## Diğer Önemli Parametreler

### 🔌 Klemmen (Terminal/Kontak Pozisyonları)

**Klemmen** (Almanca: Terminal/Kontak), aracın elektrik sistemindeki farklı güç durumlarını kontrol eder.

#### **Klemmen Durumları**

| Klemme | İsim | Durum | Açıklama |
|--------|------|-------|----------|
| **Klemme R** | Radio | Kontak Kapalı | Radyo/medya sistemi için sürekli güç |
| **Klemme 15** | Ignition ON | Kontak Açık | Aksesuar gücü (kontak ON pozisyonunda) |
| **Klemme 15SV** | Start Preparation | Ön Kontak | Motor çalıştırma hazırlığı ⚠️ *Kontrol gerekebilir* |
| **Klemme 30** | Battery Plus | Sürekli + | Doğrudan akü + (sürekli aktif) |
| **Klemme 31** | Ground | Toprak | Şase toprağı (negatif) |
| **Klemme 50** | Starter | Marş | Marş motoru konumu |
| **Klemme 58** | Parking Light | Park Lambası | Park lambası kontrolü |
| **Klemme 75** | Radio Signal | Radyo Sinyali | Radyo için sinyal hattı |

#### **Klemmen Konfigürasyon Parametreleri**

**09 - Central Electronics → Klemmen Ayarları**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Klemme15_Timeout** | 0 | Devre dışı (kontak kapanınca hemen keser) |
| | 1-60 | Kontak kapatıldıktan X dakika sonra kes |
| | 255 | Süresiz (kapı açılana kadar) ⚠️ *Akü biter!* |
| **Klemme15_BatteryProtection** | 0 | Devre dışı |
| | 1 | Akü 11.5V altına düşerse otomatik kes |
| **KlemmeR_Permanent** | 0 | Radyo gücü kontak ile açılır/kapanır |
| | 1 | Radyo sürekli güçlü (hafıza için) |

**Örnek Kullanım:**
```
Klemme15_Timeout = 10  → Kontak kapandıktan 10 dakika sonra aksesuar gücünü kes
```

---

### 🌧️ Wischer (Silecek Sistemleri)

**Wischer** (Almanca: Silecek), ön ve arka silecek davranışlarını kontrol eder.

#### **Wischer Parametreleri**

**09 - Central Electronics → Wischer Configuration**

##### **Wischer_vorne (Ön Silecek)**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Wischer_vorne_Interval** | 0 | Aralıklı mod yok |
| | 1 | Aralıklı mod var (Style standart) |
| **Wischer_vorne_IntervalSteps** | 4 | 4 kademe aralık ayarı |
| | 8 | 8 kademe aralık ayarı ⚠️ *Üst modellerde* |
| **Wischer_vorne_RainSensor** | 0 | Yağmur sensörü yok (Style standart) |
| | 1 | Yağmur sensörü var ⚠️ *Opsiyonel* |
| **Wischer_vorne_Speed_v1** | 30-60 | Birinci hız (vuruş/dakika) |
| **Wischer_vorne_Speed_v2** | 50-100 | İkinci hız (vuruş/dakika) |

##### **Wischer_hinten (Arka Silecek)**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Wischer_hinten** | 0 | Arka silecek yok ⚠️ *Leon'da var!* |
| | 1 | Arka silecek var (Standart) |
| **Wischer_hinten_AutoReverse** | 0 | Geri viteste otomatik çalışma yok |
| | 1 | Geri vitese atınca arka silecek çalışır |
| **Wischer_hinten_Interval** | 5-20 | Arka silecek aralık süresi (saniye) |

##### **Wischer Özel Fonksiyonlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Wischer_Comfort** | 0 | Normal mod |
| | 1 | Kontak kapanınca son bir vuruş (temizleme) |
| **Wischer_WashFunction** | 0 | Basit yıkama |
| | 1 | Yıkama + 3 vuruş + 1 gecikmeli vuruş |
| **Wischer_ServicePosition** | 0 | Devre dışı |
| | 1 | Silecek koluna uzun basınca servis pozisyonuna gelir |

**Örnek Kullanım:**
```
Wischer_hinten_AutoReverse = 1    → Geri viteste arka silecek otomatik çalışır
Wischer_Comfort = 1               → Kontak kapanınca son temizlik vuruşu
Wischer_WashFunction = 1          → Yıkama + gecikmeli silme
```

---

### 🪟 Fenster (Cam Sistemleri)

**Fenster** (Almanca: Pencere/Cam), elektrikli cam sistemlerinin davranışını kontrol eder.

#### **Fenster Parametreleri**

**46 - Central Comfort → Fenster Configuration**

##### **FensterFL/FR/RL/RR (Tüm Camlar)**
- **FL**: Front Left (Ön sol)
- **FR**: Front Right (Ön sağ)
- **RL**: Rear Left (Arka sol)
- **RR**: Rear Right (Arka sağ)

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Fenster_FL_OneTouch** | 0 | Tek dokunuş yok (basılı tutmalısınız) |
| | 1 | Tek dokunuş aşağı (Style standart) |
| | 2 | Tek dokunuş aşağı + yukarı |
| **Fenster_FL_PinchProtection** | 0 | Sıkışma koruması yok ⚠️ *Tehlikeli!* |
| | 1 | Sıkışma koruması var (Style standart) |
| | 2 | Hassas sıkışma koruması ⚠️ *Kontrol gerekebilir* |
| **Fenster_FL_ComfortOpen** | 0 | Konfor açma yok |
| | 1 | Uzaktan kumanda ile camları aç (uzun basış) |
| **Fenster_FL_ComfortClose** | 0 | Konfor kapama yok |
| | 1 | Uzaktan kumanda ile camları kapat (uzun basış) |
| **Fenster_RL_Control** | 0 | Arka camlar çocuk kilidi aktif |
| | 1 | Arka camlar normal çalışır |

##### **Fenster Güvenlik Ayarları**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Fenster_SafeClose** | 0 | Normal kapanma |
| | 1 | Motor durduktan sonra camları kapat (uzaktan kumanda) |
| **Fenster_ClosingForce** | 1 | Düşük (Güvenli) |
| | 2 | Orta (Standart) |
| | 3 | Yüksek ⚠️ *Sıkışma riski artar!* |
| **Fenster_ReverseSensitivity** | 1-5 | Sıkışma hassasiyeti (1=Çok hassas, 5=Az hassas) |

##### **Fenster Comfort Features**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Fenster_KeyInDoor** | 0 | Devre dışı |
| | 1 | Kapı kilidi ile cam açma/kapama (anahtar çevirme) |
| **Fenster_Delay** | 0 | Kontak kapanınca hemen çalışmaz |
| | 1 | Kontak kapandıktan sonra 10 dakika çalışır |
| | 2 | Sürücü kapısı açılana kadar çalışır |

**Örnek Kullanım:**
```
Fenster_FL_OneTouch = 2             → Tek dokunuş aşağı + yukarı
Fenster_FL_ComfortClose = 1         → Uzaktan kumanda ile kapat
Fenster_ReverseSensitivity = 2      → Orta hassasiyet
```

---

### 🪞 Spiegel (Ayna Sistemleri)

**Spiegel** (Almanca: Ayna), dış ayna davranışlarını kontrol eder.

#### **Spiegel Parametreleri**

**46 - Central Comfort → Spiegel Configuration**

##### **Spiegel Temel Ayarlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Spiegel_Left** | 0 | Sol ayna yok ⚠️ *Olmaz!* |
| | 1 | Manuel ayna |
| | 2 | Elektrikli ayna (Style standart) |
| | 3 | Elektrikli + ısıtmalı |
| **Spiegel_Right** | 0 | Sağ ayna yok ⚠️ *Olmaz!* |
| | 1 | Manuel ayna |
| | 2 | Elektrikli ayna (Style standart) |
| | 3 | Elektrikli + ısıtmalı |

##### **Spiegel Özel Fonksiyonlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Spiegel_AutoFold** | 0 | Katlanma yok (Style standart) |
| | 1 | Elektrikli katlanır ⚠️ *Opsiyonel, donanım gerekli* |
| **Spiegel_AutoFold_OnLock** | 0 | Kilitleme ile katlanma yok |
| | 1 | Araç kilitlenince aynalar otomatik katlanır |
| **Spiegel_AutoFold_OnStart** | 0 | Motor çalışınca açılmaz |
| | 1 | Motor çalışınca aynalar otomatik açılır |
| **Spiegel_TiltReverse** | 0 | Geri viteste eğilme yok |
| | 1 | Geri viteste sağ ayna aşağı eğilir (kaldırım görme) |
| | 2 | Geri viteste sol ayna aşağı eğilir |
| | 3 | Geri viteste her iki ayna eğilir ⚠️ *Kontrol gerekebilir* |
| **Spiegel_TiltAngle** | 0-15 | Geri viteste eğilme açısı (derece) |

##### **Spiegel Hafıza Sistemi**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Spiegel_Memory** | 0 | Hafıza yok (Style standart) |
| | 1 | 2 pozisyon hafıza ⚠️ *Üst paketlerde* |
| | 2 | 3 pozisyon hafıza ⚠️ *Üst paketlerde* |
| **Spiegel_MemorySync** | 0 | Anahtar senkronizasyonu yok |
| | 1 | Her anahtar kendi ayarını hatırlar ⚠️ *Üst paketlerde* |

##### **Spiegel Isıtma**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Spiegel_Heating** | 0 | Isıtma yok |
| | 1 | Manuel ısıtma |
| | 2 | Otomatik ısıtma (arka cam buğu çözme ile) |
| **Spiegel_HeatingTemp** | -10 | -10°C altında otomatik ısıt |
| | 0 | 0°C altında otomatik ısıt |
| | 5 | 5°C altında otomatik ısıt |

**Örnek Kullanım:**
```
Spiegel_TiltReverse = 1          → Geri viteste sağ ayna aşağı eğilir
Spiegel_Heating = 2              → Otomatik ısıtma
Spiegel_AutoFold_OnLock = 1      → Kilitleme ile katlan (donanım varsa)
```

---

### 🚪 Tuer (Kapı Sistemleri)

**Tuer** (Almanca: Kapı), kapı kilitleme ve açma davranışlarını kontrol eder.

#### **Tuer Parametreleri**

**46 - Central Comfort → Tuer Configuration**

##### **Tuer Kilitleme Ayarları**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Tuer_AutoLock_Speed** | 0 | Hız ile otomatik kilitleme yok |
| | 15 | 15 km/h üzerinde kilitle (Yaygın) |
| | 20 | 20 km/h üzerinde kilitle |
| **Tuer_AutoUnlock_Stop** | 0 | Durduğunda kilit açma yok |
| | 1 | Motor kapatılınca kilidi aç |
| | 2 | Sürücü kapısı açılınca kilidi aç |
| **Tuer_DoubleUnlock** | 0 | Tek basışta tüm kapılar açılır |
| | 1 | İlk basış: Sürücü, İkinci basış: Tüm kapılar |
| **Tuer_SelectiveUnlock** | 0 | Devre dışı |
| | 1 | Seçici kilit açma aktif |

##### **Tuer Konfor Fonksiyonlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Tuer_SafeLock** | 0 | Normal kilit |
| | 1 | Güvenli kilit (içeriden açılamaz) |
| **Tuer_SafeLock_AutoDelay** | 0 | Devre dışı |
| | 120 | Kilitli 120 saniye sonra otomatik safe moda geç |
| **Tuer_CentralLock_OnStart** | 0 | Motor çalışınca kilitleme yok |
| | 1 | Motor çalışınca otomatik kilitle |

##### **Tuer Uyarılar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Tuer_KeyInIgnition_Warning** | 0 | Uyarı yok |
| | 1 | Kontak açık + sürücü kapısı açık = bip sesi |
| **Tuer_LightsOn_Warning** | 0 | Uyarı yok |
| | 1 | Kontak kapalı + farlar açık = bip sesi |
| **Tuer_OpenDoor_Warning** | 0 | Uyarı yok |
| | 1 | Hareket halinde kapı açık = uyarı |

##### **Tuer Akustik/Görsel Geri Bildirim**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Tuer_AcousticLock** | 0 | Sessiz |
| | 1 | Kilitleme sesi (bip) |
| | 2 | Kilitleme + kilit açma sesi |
| **Tuer_AcousticVolume** | 0-3 | Ses şiddeti (0=Sessiz, 3=Yüksek) |
| **Tuer_VisualConfirm** | 0 | Görsel onay yok |
| | 1 | Sinyal lambası yanıp söner |
| | 2 | Sinyal + uyarı lambası |

**Örnek Kullanım:**
```
Tuer_AutoLock_Speed = 15         → 15 km/h'de otomatik kilitle
Tuer_DoubleUnlock = 1            → İki kademeli kilit açma
Tuer_AcousticLock = 1            → Kilitleme sesi var
```

---

### 💺 Sitze (Koltuk Sistemleri)

**Sitze** (Almanca: Koltuk), koltuk ayar sistemlerini kontrol eder.

#### **Sitze Parametreleri**

**46 - Central Comfort → Sitze Configuration**

##### **Sitze Temel Ayarlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Sitze_Driver** | 0 | Manuel koltuk (Style standart) |
| | 1 | Elektrikli koltuk ⚠️ *Üst paketlerde* |
| | 2 | Elektrikli + hafızalı ⚠️ *Üst paketlerde* |
| **Sitze_Passenger** | 0 | Manuel koltuk (Style standart) |
| | 1 | Elektrikli koltuk ⚠️ *Üst paketlerde* |

##### **Sitze Isıtma**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Sitze_HeatingDriver** | 0 | Isıtma yok (Style standart) |
| | 1 | 1 kademe ısıtma ⚠️ *Opsiyonel* |
| | 2 | 2 kademe ısıtma ⚠️ *Opsiyonel* |
| | 3 | 3 kademe ısıtma ⚠️ *Üst paketlerde* |
| **Sitze_HeatingPassenger** | 0 | Isıtma yok (Style standart) |
| | 1 | 1 kademe ısıtma ⚠️ *Opsiyonel* |
| | 2 | 2 kademe ısıtma ⚠️ *Opsiyonel* |

##### **Sitze Hafıza (Memory)**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Sitze_Memory** | 0 | Hafıza yok (Style standart) |
| | 1 | 2 pozisyon hafıza ⚠️ *Üst paketlerde* |
| | 2 | 3 pozisyon hafıza ⚠️ *Üst paketlerde* |
| **Sitze_MemorySync** | 0 | Anahtar senkronizasyonu yok |
| | 1 | Her anahtar kendi koltuk pozisyonunu hatırlar |
| **Sitze_EasyEntry** | 0 | Kolay giriş yok |
| | 1 | Motor kapatınca koltuk otomatik geri kayar ⚠️ *Kontrol gerekebilir* |

**Örnek Kullanım:**
```
Sitze_HeatingDriver = 2          → Sürücü koltuğu 2 kademe ısıtma (varsa)
Sitze_Memory = 1                 → 2 pozisyon hafıza (donanım varsa)
```

---

### ❄️ Klima (İklim Kontrolü)

**Klima** parametreleri iklim kontrol sisteminin davranışını ayarlar.

#### **Klima Parametreleri**

**08 - Air Conditioning → Klima Configuration**

##### **Klima Temel Ayarlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Klima_Type** | 0 | Yok ⚠️ *Style'da var!* |
| | 1 | Manuel klima |
| | 2 | Climatronic (Otomatik - Style standart) |
| | 3 | Çift bölge klimatik ⚠️ *Üst paketlerde* |
| **Klima_AutoMode** | 0 | Manuel mod |
| | 1 | Otomatik mod varsayılan (Style) |

##### **Klima Fonksiyonlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Klima_AutoDefrost** | 0 | Otomatik buğu çözme yok |
| | 1 | 5°C altında otomatik buğu çözme |
| | 2 | Nem sensörü ile otomatik |
| **Klima_Recirculation** | 0 | Manuel devir daim |
| | 1 | Otomatik devir daim (kirli hava algılandığında) ⚠️ *Hava kalitesi sensörü gerekli* |
| **Klima_RestHeat** | 0 | Artık ısı kullanımı yok |
| | 1 | Motor kapatıldıktan sonra artık ısı ile ısıtma ⚠️ *Kontrol gerekebilir* |
| **Klima_AirQuality** | 0 | Hava kalitesi sensörü yok (Style standart) |
| | 1 | Hava kalitesi sensörü var ⚠️ *Üst paketlerde* |

##### **Klima Sıcaklık Ayarları**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Klima_DefaultTemp** | 18-28 | Varsayılan sıcaklık (°C) - genelde 21-22°C |
| **Klima_TempUnit** | 0 | Celsius (°C) |
| | 1 | Fahrenheit (°F) |
| **Klima_TempStep** | 0.5 | 0.5°C adımlar |
| | 1.0 | 1.0°C adımlar |

##### **Klima Fan Ayarları**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Klima_AutoFanSpeed** | 1 | Çok düşük otomatik fan |
| | 2 | Düşük otomatik fan |
| | 3 | Orta otomatik fan (Standart) |
| | 4 | Yüksek otomatik fan |
| **Klima_MaxFanSpeed** | 8-16 | Maksimum fan devri (kademe) |

##### **Klima Ekonomi Modu**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Klima_EcoMode** | 0 | Ekonomi modu yok |
| | 1 | Ekonomi modu var (kompresör daha az çalışır) |
| **Klima_EcoTemp** | 2 | Hedef sıcaklıktan ±2°C tolerans |
| | 3 | Hedef sıcaklıktan ±3°C tolerans |

**Örnek Kullanım:**
```
Klima_AutoDefrost = 1            → 5°C altında otomatik buğu çözme
Klima_DefaultTemp = 22           → Varsayılan 22°C
Klima_AutoFanSpeed = 3           → Orta otomatik fan hızı
```

---

### 🎛️ Menu (Menü Ayarları)

**Menu** parametreleri araç menüsündeki seçenekleri kontrol eder.

#### **Menu Parametreleri**

**17 - Instrument Cluster → Menu Configuration**

##### **Menu Dil ve Birimler**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Menu_Language** | 0 | Almanca |
| | 1 | İngilizce |
| | 6 | Türkçe |
| | ... | Diğer diller (market bağımlı) |
| **Menu_SpeedUnit** | 0 | km/h |
| | 1 | mph |
| **Menu_TempUnit** | 0 | Celsius (°C) |
| | 1 | Fahrenheit (°F) |
| **Menu_DistanceUnit** | 0 | Kilometer (km) |
| | 1 | Mile (mi) |
| **Menu_ConsumptionUnit** | 0 | L/100km |
| | 1 | km/L |
| | 2 | mpg (UK) |
| | 3 | mpg (US) |

##### **Menu Gösterge Seçenekleri**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Menu_SpeedWarning** | 0 | Hız uyarısı yok |
| | 1 | Hız uyarısı var |
| **Menu_SpeedWarning_Value** | 0-250 | Uyarı hızı (km/h veya mph) |
| **Menu_DigitalSpeed** | 0 | Dijital hız göstergesi yok |
| | 1 | MFD'de dijital hız göster |
| **Menu_GearDisplay** | 0 | Vites göstergesi yok (otomatik şanzıman) |
| | 1 | Vites göstergesi var (manuel şanzıman - Style) |

##### **Menu Bilgi Ekranları**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Menu_TripComputer** | 0 | Yol bilgisayarı yok ⚠️ *Style'da var* |
| | 1 | Basit yol bilgisayarı (Style standart) |
| | 2 | Gelişmiş yol bilgisayarı ⚠️ *Üst paketlerde* |
| **Menu_RangeDisplay** | 0 | Menzil göstergesi yok |
| | 1 | Menzil göstergesi var (Style standart) |
| **Menu_AverageConsumption** | 0 | Ortalama tüketim yok |
| | 1 | Ortalama tüketim var (Style standart) |
| **Menu_CurrentConsumption** | 0 | Anlık tüketim yok |
| | 1 | Anlık tüketim var (Style standart) |

##### **Menu Uyarı Ayarları**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Menu_SeatbeltWarning** | 0 | Sadece sesli uyarı |
| | 1 | Sesli + görsel uyarı (Style) |
| **Menu_SeatbeltDuration** | 30 | 30 saniye uyarı |
| | 60 | 60 saniye uyarı |
| | 90 | 90 saniye uyarı |
| | 255 | Sürekli (kemer takılana kadar) |
| **Menu_DoorWarning** | 0 | Kapı açık uyarısı yok |
| | 1 | Hareket halinde uyarı (Style) |

##### **Menu Servis Bilgileri**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Menu_ServiceInterval** | 0 | Servis göstergesi yok |
| | 1 | Zaman/mesafe bazlı (Style standart) |
| | 2 | LongLife esnek servis |
| **Menu_ServiceReset** | 0 | Sadece servis sıfırlayabilir |
| | 1 | Kullanıcı da sıfırlayabilir ⚠️ *Önerilmez* |
| **Menu_OilQuality** | 0 | Normal motor yağı |
| | 1 | LongLife yağ (VW 504.00) |

##### **Menu Özel Fonksiyonlar**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Menu_NeedleSweep** | 0 | Kontak açılışta iğne tarama yok |
| | 1 | Kontak açılışta iğneler tur atar |
| **Menu_StartupLogo** | 0 | Başlangıç logosu yok |
| | 1 | SEAT logosu göster (Style standart) |
| **Menu_ClockSync** | 0 | Manuel saat ayarı |
| | 1 | GPS saat senkronizasyonu ⚠️ *Navigasyon gerekli* |

**Örnek Kullanım:**
```
Menu_Language = 6                → Türkçe dil
Menu_SpeedWarning = 1            → Hız uyarısı aktif
Menu_SpeedWarning_Value = 120    → 120 km/h'de uyar
Menu_NeedleSweep = 1             → İğne tarama aktif
Menu_DigitalSpeed = 1            → Dijital hız göster
```

---

### 🔧 Diğer Özel Parametreler

#### **Cruise Control (Hız Sabitleyici)**

**09 - Central Electronics → Cruise Control**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **CruiseControl** | 0 | Hız sabitleyici yok |
| | 1 | Basit hız sabitleyici (Style standart) |
| | 2 | Adaptif hız sabitleyici (ACC) ⚠️ *Üst paketlerde* |
| **CruiseControl_MinSpeed** | 30 | Minimum 30 km/h'de devreye girer |
| | 40 | Minimum 40 km/h'de devreye girer |
| **CruiseControl_Resume** | 0 | Resume fonksiyonu yok |
| | 1 | Resume fonksiyonu var |

#### **PDC (Park Distance Control - Park Sensörleri)**

**46 - Central Comfort → PDC Configuration**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **PDC_Front** | 0 | Ön park sensörü yok (Style standart) |
| | 1 | Ön park sensörü var ⚠️ *Opsiyonel* |
| **PDC_Rear** | 0 | Arka park sensörü yok |
| | 1 | Arka park sensörü var ⚠️ *Opsiyonel* |
| **PDC_Volume** | 0-3 | Ses şiddeti (0=Sessiz, 3=Yüksek) |
| **PDC_AutoOff_Speed** | 15 | 15 km/h üzerinde otomatik kapanır |

#### **Alarm System (Alarm Sistemi)**

**46 - Central Comfort → Alarm Configuration**

| Parametre | Value | Açıklama |
|-----------|-------|----------|
| **Alarm_Type** | 0 | Alarm yok |
| | 1 | Basit mekanik alarm (Style) |
| | 2 | Elektronik alarm ⚠️ *Üst paketlerde* |
| **Alarm_InteriorSensor** | 0 | İç mekan sensörü yok (Style standart) |
| | 1 | İç mekan sensörü var ⚠️ *Opsiyonel* |
| **Alarm_TowProtection** | 0 | Çekme koruması yok (Style standart) |
| | 1 | Çekme koruması var ⚠️ *Opsiyonel* |

---

## 09 - Central Electronics (Merkezi Elektronik)

### **Lighting & Visibility (Aydınlatma ve Görüş)**

#### **Byte 0 - Daytime Running Lights (Gündüz Farları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Daytime running lights | 0 | DRL devre dışı |
| | | 1 | DRL aktif (LED varsa) |
| | | 2 | DRL aktif (Halojen) |
| | | 3 | DRL aktif (Kısa far yarım güç) ⚠️ *Emin değilim - Kontrol gerekebilir* |

#### **Byte 1 - Coming/Leaving Home (Karşılama/Uğurlama Işıkları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | Coming Home Duration | 0 | Devre dışı |
| | | 1 | 10 saniye |
| | | 2 | 20 saniye |
| | | 3 | 30 saniye |
| | | 4 | 40 saniye |
| | | 5 | 60 saniye |
| | | 6 | 90 saniye ⚠️ *Emin değilim - Kontrol gerekebilir* |
| 3-5 | Leaving Home Duration | 0 | Devre dışı |
| | | 1 | 10 saniye |
| | | 2 | 20 saniye |
| | | 3 | 30 saniye |
| | | 4 | 40 saniye |
| | | 5 | 60 saniye |

#### **Byte 2 - Motorway Lights (Otoyol Işıkları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Motorway mode | 0 | Devre dışı |
| | | 1 | Aktif (130 km/h üzerinde fazladan aydınlatma) |
| 1 | Dynamic headlight range | 0 | Statik ayar |
| | | 1 | Dinamik ayar (yol durumuna göre) |

#### **Byte 3 - Cornering Lights (Viraj Işıkları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Cornering light function | 0 | Devre dışı |
| | | 1 | Sis farı ile aktif |
| | | 2 | Ayrı lamba ile aktif ⚠️ *Style pakette olmayabilir* |
| | | 3 | LED modül ile aktif ⚠️ *Style pakette olmayabilir* |

#### **Byte 4 - Fog Light Configuration (Sis Farı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Front fog lights | 0 | Yok |
| | | 1 | Var (Style standartta var) |
| 1 | Rear fog light | 0 | Yok |
| | | 1 | Var (Standart) |
| 2 | Fog light with main beam | 0 | Ana far açıkken sis farı kapanır |
| | | 1 | Ana far açıkken de sis farı açık kalır |

### **Convenience Features (Konfor Özellikleri)**

#### **Byte 5 - Door & Mirror Functions (Kapı ve Ayna)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Auto door lock at 15 km/h | 0 | Devre dışı |
| | | 1 | Aktif (15 km/h'de otomatik kilitleme) |
| 1 | Auto door unlock on ignition off | 0 | Kontak kapatınca kilidi açma |
| | | 1 | Kontak kapatınca kilidi aç |
| 2 | Mirror auto fold on lock | 0 | Devre dışı |
| | | 1 | Kilit yapınca aynalar kapanır ⚠️ *Style pakette elektrikli katlanır ayna olmayabilir* |
| 3 | Mirror tilt in reverse | 0 | Devre dışı |
| | | 1 | Geri viteste yolcu aynası aşağı eğilir |

#### **Byte 6 - Window & Sunroof (Cam ve Sunroof)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Comfort opening (windows) | 0 | Devre dışı |
| | | 1 | Uzaktan kumanda ile camları aç |
| | | 2 | Uzaktan kumanda + sensör ile |
| 2-3 | Comfort closing (windows) | 0 | Devre dışı |
| | | 1 | Uzaktan kumanda ile camları kapat |
| | | 2 | Uzaktan kumanda + sensör ile |
| 4 | Sunroof in convenience | 0 | Devre dışı |
| | | 1 | Sunroof da konfor fonksiyonuna dahil ⚠️ *Style pakette sunroof olmayabilir* |

#### **Byte 7 - Wiper & Rain Sensor (Silecek ve Yağmur Sensörü)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Rain sensor | 0 | Yok |
| | | 1 | Var (Style pakette olmayabilir) |
| 1-2 | Rain sensor sensitivity | 0 | Düşük |
| | | 1 | Orta |
| | | 2 | Yüksek |
| | | 3 | Çok yüksek |
| 3 | Rear wiper in reverse | 0 | Devre dışı |
| | | 1 | Geri viteste arka silecek otomatik çalışır |

### **Interior Lighting (İç Aydınlatma)**

#### **Byte 8 - Interior Light Behavior (İç Aydınlatma Davranışı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | Door opening light duration | 0 | Işık yok |
| | | 1 | 5 saniye |
| | | 2 | 10 saniye |
| | | 3 | 20 saniye |
| | | 4 | 30 saniye |
| | | 5 | Kalıcı (kontak kapanana kadar) |
| 3-5 | Light off delay after lock | 0 | Anında söner |
| | | 1 | 5 saniye |
| | | 2 | 10 saniye |
| | | 3 | 20 saniye |

#### **Byte 9 - Footwell & Ambient Lighting (Ayak ve Ambient Işık)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Footwell lighting | 0 | Devre dışı |
| | | 1 | Aktif (Kontak açıldığında ayak alanı aydınlatması) |
| 1-2 | Ambient light color | 0 | Yok / Devre dışı |
| | | 1 | Beyaz ⚠️ *Style pakette ambient olmayabilir* |
| | | 2 | Kırmızı ⚠️ *Style pakette ambient olmayabilir* |
| | | 3 | Mavi ⚠️ *Style pakette ambient olmayabilir* |

---

## 17 - Instrument Cluster (Gösterge Paneli)

### **Display Configuration (Ekran Ayarları)**

#### **Byte 0 - Display Language (Ekran Dili)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-7 | Language | 0 | Almanca (DE) |
| | | 1 | İngilizce (EN) |
| | | 2 | Fransızca (FR) |
| | | 3 | İspanyolca (ES) |
| | | 4 | İtalyanca (IT) |
| | | 5 | Portekizce (PT) |
| | | 6 | Türkçe (TR) |
| | | 7 | Lehçe (PL) |
| | | 8+ | Diğer diller ⚠️ *Model ve pazara göre değişir* |

#### **Byte 1 - Units (Birimler)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Speed unit | 0 | km/h |
| | | 1 | mph |
| 2-3 | Temperature unit | 0 | Celsius (°C) |
| | | 1 | Fahrenheit (°F) |
| 4-5 | Fuel consumption unit | 0 | L/100km |
| | | 1 | km/L |
| | | 2 | mpg (UK) |
| | | 3 | mpg (US) |
| 6-7 | Distance unit | 0 | Kilometer (km) |
| | | 1 | Mile (mi) |

#### **Byte 2 - Clock & Time (Saat ve Zaman)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Time format | 0 | 24 saat formatı |
| | | 1 | 12 saat formatı (AM/PM) |
| 1 | Summer time adjustment | 0 | Devre dışı (manuel) |
| | | 1 | Otomatik yaz saati geçişi |

### **Warning & Information (Uyarı ve Bilgilendirme)**

#### **Byte 3 - Speed Warning (Hız Uyarısı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Speed warning | 0 | Devre dışı |
| | | 1 | Aktif |
| 1-7 | Warning threshold | 0-250 | Uyarı hızı (km/h veya mph cinsinden) |

#### **Byte 4 - Oil Service Interval (Servis Aralığı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Service interval type | 0 | Zaman bazlı (1 yıl / 15,000 km) |
| | | 1 | Esnek servis (Longlife) |
| | | 2 | Sabit (30,000 km) ⚠️ *Kontrol gerekebilir* |
| 2 | Oil level warning | 0 | Minimum seviye uyarısı |
| | | 1 | Düşük seviye erken uyarısı |

#### **Byte 5 - Brake Pad Warning (Balata Uyarısı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Brake pad sensor | 0 | Sensör yok |
| | | 1 | Sensör var (Ön balata) |
| 1 | Rear brake pad sensor | 0 | Yok |
| | | 1 | Var ⚠️ *Style pakette genelde sadece ön balata sensörü var* |

### **Gauges & Needles (Göstergeler)**

#### **Byte 6 - Needle Sweep (İğne Tarama)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Startup needle sweep | 0 | Devre dışı (İğneler tarama yapmaz) |
| | | 1 | Aktif (Kontak açılışta iğneler tur atar) |
| 1 | Sweep type | 0 | Normal hız |
| | | 1 | Hızlı tarama ⚠️ *Kontrol gerekebilir* |

#### **Byte 7 - Display Brightness (Ekran Parlaklığı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-7 | Brightness level | 0-15 | Ekran parlaklık seviyesi (0=Min, 15=Max) |

### **Advanced Features (Gelişmiş Özellikler)**

#### **Byte 8 - MFD Settings (Çok Fonksiyonlu Ekran)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Digital speed display | 0 | Devre dışı |
| | | 1 | Aktif (Dijital hız göstergesi MFD'de) |
| 1 | Gear recommendation | 0 | Devre dışı |
| | | 1 | Vites öneri göstergesi aktif (Manuel şanzımanlarda) |
| 2 | Current consumption | 0 | Anlık tüketimi gösterme |
| | | 1 | Göster |

#### **Byte 9 - Warning Preferences (Uyarı Tercihleri)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Seatbelt warning | 0 | Sadık ses uyarısı |
| | | 1 | Ses + görsel uyarı |
| 1-2 | Warning duration | 0 | 30 saniye |
| | | 1 | 60 saniye |
| | | 2 | 90 saniye |
| | | 3 | Sürekli (kemer takılana kadar) |

---

## 19 - CAN Gateway

### **Network Configuration (Ağ Yapılandırması)**

#### **Byte 0 - Diagnosis Protocol (Teşhis Protokolü)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-3 | Protocol version | 0 | KWP2000 |
| | | 1 | UDS (ISO 14229) - Standart 2016 Leon için |
| | | 2 | Mixed mode ⚠️ *Kontrol gerekebilir* |

#### **Byte 1 - CAN Bus Configuration (CAN Bus Ayarları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Powertrain CAN | 0 | Devre dışı ⚠️ *Asla devre dışı bırakmayın!* |
| | | 1 | Aktif (500 kbps) |
| 1 | Comfort CAN | 0 | Devre dışı |
| | | 1 | Aktif (125 kbps) |
| 2 | Infotainment CAN | 0 | Devre dışı |
| | | 1 | Aktif (125 kbps) |
| 3 | Extended CAN | 0 | Yok |
| | | 1 | Var ⚠️ *Üst donanımlarda kamera sistemleri için* |

### **Security & Access (Güvenlik ve Erişim)**

#### **Byte 2 - Immobilizer (İmmobilizer)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Immobilizer type | 0 | Yok ⚠️ *Standart araçlarda mutlaka var!* |
| | | 1 | İmmobilizer 3 |
| | | 2 | İmmobilizer 4 |
| | | 3 | İmmobilizer 5 ⚠️ *2016 Leon için tipik* |
| 2-4 | Keys programmed | 0-7 | Sistemde kayıtlı anahtar sayısı (max 8) |

#### **Byte 3 - Gateway Diagnose Mode (Gateway Teşhis Modu)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Extended diagnosis | 0 | Standart mod |
| | | 1 | Genişletilmiş teşhis (servis modu) |
| 1 | Sleep mode enable | 0 | Devre dışı (Gateway sürekli uyanık) |
| | | 1 | Uyku modu aktif (araç kullanılmadığında gateway uyur) |

### **Module Presence (Modül Varlığı)**
*Bu bölüm araçta hangi modüllerin mevcut olduğunu gösterir*

#### **Byte 4 - Basic Modules (Temel Modüller)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Engine ECU (01) | 0 | Yok ⚠️ *Asla 0 olmamalı!* |
| | | 1 | Var |
| 1 | Transmission (02) | 0 | Yok (Manuel şanzıman) |
| | | 1 | Var (DSG şanzıman) |
| 2 | ABS/ESP (03) | 0 | Yok ⚠️ *Style pakette standart* |
| | | 1 | Var |
| 3 | Airbag (15) | 0 | Yok ⚠️ *Style pakette standart* |
| | | 1 | Var |

#### **Byte 5 - Comfort Modules (Konfor Modülleri)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Central Electronics (09) | 0 | Yok |
| | | 1 | Var (Standart) |
| 1 | Central Comfort (46) | 0 | Yok |
| | | 1 | Var (Style pakette standart) |
| 2 | Climate Control (08) | 0 | Manuel klima |
| | | 1 | Otomatik klima (Style pakette standart) |

#### **Byte 6 - Infotainment & Display (Bilgi-Eğlence ve Ekran)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Radio/Media (56) | 0 | Yok |
| | | 1 | Seat Sound System (Style pakette standart) |
| 1 | Navigation (5F) | 0 | Yok (Sadece media sistemi) |
| | | 1 | Navigasyon var ⚠️ *Style pakette opsiyonel* |
| 2 | Phone Module (77) | 0 | Yok |
| | | 1 | Var (Bluetooth sistemi) |

---

## 46 - Central Comfort System

### **Remote Key Configuration (Uzaktan Kumanda Ayarları)**

#### **Byte 0 - Remote Key Functions (Uzaktan Kumanda Fonksiyonları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Double unlock press | 0 | Tek basışta tüm kapılar açılır |
| | | 1 | İlk basış sürücü, ikinci basış tüm kapılar |
| 1 | Acoustic confirmation | 0 | Sessiz (sadece flasher) |
| | | 1 | Sesli uyarı (bip sesi) |
| 2 | Visual confirmation | 0 | Devre dışı |
| | | 1 | Sinyal lambası yanıp söner |
| 3 | Selective unlock | 0 | Devre dışı |
| | | 1 | Aktif (Sadece sürücü kapısı açılır) |

#### **Byte 1 - Autolock Configuration (Otomatik Kilit Ayarları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Autolock at speed | 0 | Devre dışı |
| | | 1 | 15 km/h üzerinde otomatik kilitle |
| 1 | Auto unlock on stop | 0 | Devre dışı |
| | | 1 | Motor durdurulunca kilidi aç |
| 2 | Safe unlock | 0 | Devre dışı |
| | | 1 | Sadece Park konumunda kilidi aç |

### **Comfort Features (Konfor Özellikleri)**

#### **Byte 2 - Convenience Opening/Closing (Konfor Açma/Kapama)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Windows via remote | 0 | Devre dışı |
| | | 1 | Aç (Kilit açma tuşunu basılı tut) |
| | | 2 | Kapat (Kilit kapama tuşunu basılı tut) |
| | | 3 | Her ikisi de aktif |
| 2 | Sunroof via remote | 0 | Devre dışı |
| | | 1 | Aktif ⚠️ *Style pakette sunroof olmayabilir* |
| 3 | Mirror fold via remote | 0 | Devre dışı |
| | | 1 | Kilit yapınca aynalar kapanır ⚠️ *Elektrikli katlanır ayna gerekli* |

#### **Byte 3 - Key in Ignition Warning (Kontak Anahtarı Uyarısı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Key warning | 0 | Devre dışı |
| | | 1 | Sürücü kapısı açıkken anahtar kontakta ise uyar |
| 1 | Lights on warning | 0 | Devre dışı |
| | | 1 | Kontak kapalı, far açıksa uyar |

### **Interior Monitoring (İç Mekan İzleme)**

#### **Byte 4 - Anti-theft Alarm (Hırsızlık Alarmı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Alarm system | 0 | Yok |
| | | 1 | Mekanik alarm (Standart) |
| | | 2 | Elektronik alarm ⚠️ *Kontrol gerekebilir* |
| 1 | Interior monitoring | 0 | Devre dışı |
| | | 1 | İç mekan sensörü aktif ⚠️ *Üst paketlerde* |
| 2 | Tow-away protection | 0 | Devre dışı |
| | | 1 | Çekme koruması aktif ⚠️ *Üst paketlerde* |

#### **Byte 5 - Safe System (Güvenli Kilit)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Safe mode | 0 | Normal kilit |
| | | 1 | Güvenli kilit (İçeriden açılamaz) |
| 1 | Auto safe after time | 0 | Devre dışı |
| | | 1 | Kilitli kalırsa 2 dakika sonra otomatik safe moda geçer |

### **Door & Window Settings (Kapı ve Cam Ayarları)**

#### **Byte 6 - Window Behavior (Cam Davranışı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | One-touch operation | 0 | Devre dışı |
| | | 1 | Tek dokunuşla tam açma/kapama |
| 1 | Pinch protection | 0 | Devre dışı ⚠️ *Güvenlik için açık tutun* |
| | | 1 | Sıkışma koruması aktif |
| 2-3 | Closing force | 0 | Düşük |
| | | 1 | Orta (Standart) |
| | | 2 | Yüksek ⚠️ *Sıkışma riski* |

#### **Byte 7 - Door Lock Sound (Kapı Kilidi Sesi)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | Lock sound volume | 0 | Sessiz |
| | | 1 | Düşük |
| | | 2 | Orta |
| | | 3 | Yüksek |
| | | 4 | Çok yüksek ⚠️ *Rahatsız edici olabilir* |

---

## 5F - Information Electronics

### **Media System (Medya Sistemi)**

#### **Byte 0 - System Configuration (Sistem Konfigürasyonu)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | System type | 0 | Yok |
| | | 1 | Composition Touch (Style standart) |
| | | 2 | Composition Media |
| | | 3 | Seat Sound System ⚠️ *Style pakette bu olabilir* |
| | | 4 | Media System Plus ⚠️ *Üst paket* |

#### **Byte 1 - Audio Configuration (Ses Ayarları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | Speaker count | 0 | 4 hoparlör |
| | | 1 | 6 hoparlör |
| | | 2 | 8 hoparlör (Style standart) |
| | | 3 | 10 hoparlör + subwoofer ⚠️ *BeatsAudio üst paket* |
| 3 | External amplifier | 0 | Yok (Head unit dahili amp) |
| | | 1 | Harici amplifikatör var |

### **Bluetooth & Phone (Bluetooth ve Telefon)**

#### **Byte 2 - Bluetooth Configuration (Bluetooth Ayarları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Bluetooth module | 0 | Yok |
| | | 1 | Var (Style standart) |
| 1 | Bluetooth audio streaming | 0 | Sadece telefon |
| | | 1 | Telefon + müzik streaming |
| 2 | Phone book download | 0 | Devre dışı |
| | | 1 | Rehberi indir |
| 3 | SMS display | 0 | Devre dışı |
| | | 1 | SMS'leri ekranda göster ⚠️ *Kontrol gerekebilir* |

#### **Byte 3 - Voice Control (Sesli Komut)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Voice control | 0 | Yok |
| | | 1 | Basit sesli komut ⚠️ *Style pakette olmayabilir* |
| | | 2 | Gelişmiş sesli komut ⚠️ *Üst paketlerde* |

### **Navigation (Navigasyon)**

#### **Byte 4 - Navigation System (Navigasyon Sistemi)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Navigation type | 0 | Yok (Style standart paket) |
| | | 1 | SD kart tabanlı ⚠️ *Opsiyonel* |
| | | 2 | Sabit disk tabanlı ⚠️ *Üst paket* |
| 2 | Map updates | 0 | Manuel güncelleme |
| | | 1 | Online güncelleme ⚠️ *Kontrol gerekebilir* |
| 3 | Traffic info (TMC) | 0 | Yok |
| | | 1 | TMC var |

### **Display Settings (Ekran Ayarları)**

#### **Byte 5 - Display Configuration (Ekran Konfigürasyonu)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | Display size | 0 | 5 inch |
| | | 1 | 6.5 inch (Style standart) |
| | | 2 | 8 inch ⚠️ *Üst paketlerde* |
| 3 | Touch screen | 0 | Fiziksel tuşlar |
| | | 1 | Dokunmatik ekran (Style standart) |

#### **Byte 6 - Camera Systems (Kamera Sistemleri)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Rear view camera | 0 | Yok (Style standart) |
| | | 1 | Var ⚠️ *Opsiyonel* |
| 1 | Front camera | 0 | Yok |
| | | 1 | Var ⚠️ *Üst paketlerde* |
| 2 | 360° camera | 0 | Yok |
| | | 1 | Var ⚠️ *Üst paketlerde* |
| 3 | Parking sensors | 0 | Yok |
| | | 1 | Sadece arka |
| | | 2 | Ön + arka ⚠️ *Kontrol gerekebilir* |

---

## 55 - Headlight Range Control

### **Headlight Configuration (Far Ayarları)**

#### **Byte 0 - Headlight Type (Far Tipi)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | Headlight type | 0 | Halogen (Style standart) |
| | | 1 | Xenon ⚠️ *Opsiyonel* |
| | | 2 | Bi-Xenon ⚠️ *Opsiyonel* |
| | | 3 | LED ⚠️ *Üst paketlerde* |
| | | 4 | Full LED ⚠️ *Üst paketlerde* |

#### **Byte 1 - Range Adjustment (Seviye Ayarı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Adjustment type | 0 | Manuel (İçeriden düğme ile) |
| | | 1 | Otomatik dinamik (Xenon/LED için) |
| 1-3 | Initial position | 0-7 | Başlangıç seviye konumu (0=En alçak, 7=En yüksek) |

#### **Byte 2 - Dynamic Headlight (Dinamik Far)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | AFS (Adaptive Front Light) | 0 | Yok (Style standart - halogen) |
| | | 1 | Var ⚠️ *Xenon/LED paketlerde* |
| 1 | Curve illumination | 0 | Yok |
| | | 1 | Aktif (Virajda ek aydınlatma) |

#### **Byte 3 - Daytime Running Light Type (Gündüz Farı Tipi)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | DRL type | 0 | Yok |
| | | 1 | Halogen DRL |
| | | 2 | LED DRL (Style'da olabilir) |
| | | 3 | Full LED signature ⚠️ *Üst paketlerde* |

---

## 08 - Air Conditioning

### **Climate System (Klima Sistemi)**

#### **Byte 0 - Climate Control Type (Klima Kontrol Tipi)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-1 | Climate type | 0 | Yok ⚠️ *Asla olmamalı* |
| | | 1 | Manuel klima |
| | | 2 | Otomatik klima (Climatronic - Style standart) |
| | | 3 | Çift bölgeli klima ⚠️ *Üst paketlerde* |

#### **Byte 1 - Temperature Settings (Sıcaklık Ayarları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Temperature unit | 0 | Celsius (°C) |
| | | 1 | Fahrenheit (°F) |
| 1-7 | Default temperature | 18-28 | Varsayılan sıcaklık (°C cinsinden, genelde 21-22°C) |

#### **Byte 2 - Fan & Air Distribution (Fan ve Hava Dağılımı)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0-2 | Auto fan speed | 0 | Çok düşük |
| | | 1 | Düşük |
| | | 2 | Orta (Standart) |
| | | 3 | Yüksek |
| | | 4 | Çok yüksek |
| 3 | Air recirculation auto | 0 | Manuel |
| | | 1 | Otomatik devreye girer |

#### **Byte 3 - Special Functions (Özel Fonksiyonlar)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Auto defrost | 0 | Devre dışı |
| | | 1 | Otomatik buğu çözme aktif |
| 1 | Residual heat | 0 | Devre dışı |
| | | 1 | Motor kapalıyken kalan ısıyı kullan ⚠️ *Kontrol gerekebilir* |
| 2 | Air quality sensor | 0 | Yok |
| | | 1 | Var (Hava kalitesi sensörü) ⚠️ *Üst paketlerde* |

#### **Byte 4 - Compressor Settings (Kompresör Ayarları)**
| Bit | Parametre | Value | Açıklama |
|-----|-----------|-------|----------|
| 0 | Economy mode | 0 | Normal mod |
| | | 1 | Ekonomi modu (Kompresör daha az çalışır) |
| 1 | Dehumidification | 0 | Devre dışı |
| | | 1 | Otomatik nem alma aktif |

---

## 🔒 Güvenlik Notları

### ⚠️ Dikkat Edilmesi Gerekenler:

1. **Asla Değiştirmeyin:**
   - İmmobilizer ayarları
   - Airbag konfigürasyonu
   - ABS/ESP modül varlığı
   - Güvenlik sistemleri

2. **Dikkatli Olun:**
   - Far kodlamaları (yanlış ayar trafik kazasına yol açabilir)
   - Cam sıkışma koruması (güvenlik özelliği)
   - Otomatik kilit ayarları (içeride kalmayın)

3. **Araç Spesifik:**
   - Tüm parametreler sizin aracınızda olmayabilir
   - ⚠️ işaretli parametreler muhtemelen Style pakette yok
   - Değişiklik yapmadan önce mevcut değerleri kaydedin

4. **VCDS Kullanımı:**
   - Her değişiklikten önce yedek alın
   - Bir seferde bir modülde çalışın
   - Değişiklik sonrası test edin
   - Şüphe duyduğunuz değerleri değiştirmeyin

---

## 📝 Kullanım Tavsiyeleri

### Öncelikli Yapılabilecekler (Güvenli):
- ✅ Coming/Leaving Home süreleri
- ✅ Otomatik kilit 15 km/h
- ✅ Sinyal sesi aktif/devre dışı
- ✅ Gösterge paneli dili
- ✅ Birim değişiklikleri (km/h, °C)
- ✅ İç aydınlatma süreleri

### Dikkatli Yapılabilecekler:
- ⚠️ DRL (Gündüz farı) aktivasyonu
- ⚠️ Konfor açma/kapama (camlar)
- ⚠️ Ayna ayarları
- ⚠️ Sis farı davranışı

### Yapılmaması Gerekenler:
- ❌ İmmobilizer değişiklikleri
- ❌ Airbag kodlama
- ❌ Gateway modül varlığı
- ❌ CAN bus devre dışı bırakma
- ❌ Güvenlik sistemi ayarları

---

**Oluşturulma Tarihi**: 7 Kasım 2025  
**Hedef Araç**: 2016 Seat Leon Style Paket (5F1)  
**VCDS Sürümü**: 20.x ve üzeri  
**Platform**: MQB

**Not**: Bu dokümandaki bilgiler genel referans içindir. Aracınıza özel ayarlar farklılık gösterebilir. Değişiklik yapmadan önce mutlaka VCDS ile mevcut kodları yedekleyin ve bir değişiklik yaparken emin olmadığınız parametrelere dokunmayın.
