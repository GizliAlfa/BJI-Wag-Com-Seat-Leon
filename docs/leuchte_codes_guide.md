# Leuchte Kodları Rehberi - 2016 Seat Leon Style

## 📖 Leuchte Nedir?

**Leuchte** (Almanca: "Işık/Lamba") parametreleri, araçtaki her bir aydınlatma kanalının davranışını kontrol eder. 2016 Seat Leon'da toplam **32 kanal** (Leuchte0 - Leuchte31) bulunur.

Her Leuchte kanalı için **3 ana parametre** ayarlanır:
1. **SLH** - Lamba tipi ve konumu
2. **BLK** - Yanıp sönme davranışı (Blink)
3. **DIM** - Parlaklık seviyesi (Dimming)

---

## 🔧 SLH Kodları (Lamba Tipi)

**Format**: `[Modül]-[Çıkış]-[Tip]`

### Yaygın SLH Değerleri:

| Value | Açıklama | Örnek Kullanım |
|-------|----------|----------------|
| `0` | Devre dışı / Lamba yok | Kullanılmayan kanallar |
| `1` | Aktif - Standart lamba | Basit on/off lambalar |
| `2` | LED modül | LED DRL, LED kuyruk lambaları |
| `3` | Xenon modül | Xenon farlar (varsa) |
| `4` | Halogen | Standart halogen ampuller |
| `5` | Aktif - Dimming destekli | Karartılabilir lambalar |
| `6` | CAN kontrollü | CAN bus üzerinden kontrol |
| `7` | PWM kontrollü | PWM ile kontrol |

### Örnek SLH Kodları (2016 Leon):
```
C1-58-05  → Sol kısa far, Halogen, Dimming
C1-42-02  → Sol DRL, LED modül
C1-35-01  → Sol sis farı, Standart
C2-12-05  → İç tavan lambası, Dimming
C2-51-01  → Arka stop/fren lambası
```

---

## 💡 BLK Kodları (Yanıp Sönme)

**BLK** = **Blink** (Yanıp Sönme Davranışı)

| Kod | İsim | Davranış | Kullanım Alanı |
|-----|------|----------|----------------|
| **BLK0** | No Blink | Sabit yanar, yanıp sönmez | Farlar, park lambaları, iç aydınlatma |
| **BLK1** | Slow Blink | Yavaş yanıp sönme (0.5 Hz) | Uyarı lambaları |
| **BLK2** | Normal Blink | Normal yanıp sönme (1 Hz) | **Sinyal lambaları (standart)** |
| **BLK3** | Fast Blink | Hızlı yanıp sönme (2 Hz) | Arıza durumu, uyarı |
| **BLK4** | Double Flash | Çift flaş | Özel efektler |
| **BLK5** | Triple Flash | Üç kez yanıp sönme | Şerit değiştirme (tek dokunuş sinyal) |
| **BLK6** | Comfort Blink | Konfor yanıp sönme | Şerit değiştirme konfor sinyal (3x) |
| **BLK7** | Fade In/Out | Yumuşak açılma/kapanma | Coming/Leaving home, LED efektler |
| **BLK8** | Pulse | Nabız gibi | Alarm lambası |
| **BLK9** | Random | Rastgele | Kullanılmaz genelde |
| **BLK10** | Sequential | Sıralı yanma | Dinamik sinyal (üst modeller) |

### Tipik Kullanım:
```
Leuchte0BLK = BLK0     → Kısa far (sabit)
Leuchte6BLK = BLK2     → Ön sinyal (normal yanıp sönme)
Leuchte10BLK = BLK0    → Sis farı (sabit)
Leuchte27BLK = BLK7    → İç lamba (yumuşak aç/kapa)
```

---

## 🔆 DIM Kodları (Parlaklık)

**DIM** = **Dimming** (Karartma/Parlaklık Seviyesi)

| Value | Parlaklık | Yüzde | Kullanım |
|-------|-----------|-------|----------|
| **DIM0** | Kapalı | 0% | Lamba tamamen kapalı |
| **DIM1** | Çok Düşük | 10% | Gece modu iç lambalar |
| **DIM2** | Düşük | 20% | Park lambaları |
| **DIM3** | Orta-Düşük | 30% | Arka stop (gece) |
| **DIM4** | Orta | 40% | Coming Home (40%) |
| **DIM5** | Orta | 50% | Yarı güç |
| **DIM6** | Orta-Yüksek | 60% | - |
| **DIM7** | Yüksek | 70% | DRL gündüz farı |
| **DIM8** | Çok Yüksek | 80% | - |
| **DIM9** | Maksimum | 90% | - |
| **DIM10** | Tam Güç | 100% | Farlar, sinyal, fren |

### Tipik Kullanım:
```
Leuchte0DIM = DIM10    → Kısa far (tam güç)
Leuchte4DIM = DIM7     → DRL (70% - yasal)
Leuchte12DIM = DIM3    → Park lambası (30%)
Leuchte27DIM = DIM5    → İç lamba (50%)
Leuchte29DIM = DIM2    → Ayak aydınlatma (20%)
```

---

## 🚗 Leuchte Kanal Atamaları

### Ön ve Yan Işıklar (Leuchte0-15)

| Kanal | Fonksiyon | SLH | BLK | DIM |
|-------|-----------|-----|-----|-----|
| **Leuchte0** | Sol Kısa Far | C1-58-05 | BLK0 | DIM10 |
| **Leuchte1** | Sağ Kısa Far | C1-59-05 | BLK0 | DIM10 |
| **Leuchte2** | Sol Uzun Far | C1-60-05 | BLK0 | DIM10 |
| **Leuchte3** | Sağ Uzun Far | C1-61-05 | BLK0 | DIM10 |
| **Leuchte4** | Sol DRL (Gündüz Farı) | C1-42-02 | BLK0 | DIM7 |
| **Leuchte5** | Sağ DRL | C1-43-02 | BLK0 | DIM7 |
| **Leuchte6** | Sol Ön Sinyal | C1-28-01 | BLK2 | DIM10 |
| **Leuchte7** | Sağ Ön Sinyal | C1-29-01 | BLK2 | DIM10 |
| **Leuchte8** | Sol Yan Sinyal (Ayna) | C1-30-01 | BLK2 | DIM10 |
| **Leuchte9** | Sağ Yan Sinyal | C1-31-01 | BLK2 | DIM10 |
| **Leuchte10** | Sol Ön Sis Farı | C1-35-01 | BLK0 | DIM10 |
| **Leuchte11** | Sağ Ön Sis Farı | C1-36-01 | BLK0 | DIM10 |
| **Leuchte12** | Sol Park Lambası | C1-32-01 | BLK0 | DIM3 |
| **Leuchte13** | Sağ Park Lambası | C1-33-01 | BLK0 | DIM3 |
| **Leuchte14** | Sol Viraj Işığı | - | - | - |
| **Leuchte15** | Sağ Viraj Işığı | - | - | - |

### Arka Işıklar (Leuchte16-23)

| Kanal | Fonksiyon | SLH | BLK | DIM |
|-------|-----------|-----|-----|-----|
| **Leuchte16** | Sol Arka Stop | C2-51-01 | BLK0 | DIM3 |
| **Leuchte17** | Sağ Arka Stop | C2-52-01 | BLK0 | DIM3 |
| **Leuchte18** | Sol Fren Lambası | C2-51-01 | BLK0 | DIM10 |
| **Leuchte19** | Sağ Fren Lambası | C2-52-01 | BLK0 | DIM10 |
| **Leuchte20** | Sol Arka Sinyal | C2-54-01 | BLK2 | DIM10 |
| **Leuchte21** | Sağ Arka Sinyal | C2-55-01 | BLK2 | DIM10 |
| **Leuchte22** | Sol Geri Vites | C2-56-01 | BLK0 | DIM10 |
| **Leuchte23** | Sağ Geri Vites | C2-57-01 | BLK0 | DIM10 |

### İç ve Ek Işıklar (Leuchte24-31)

| Kanal | Fonksiyon | SLH | BLK | DIM |
|-------|-----------|-----|-----|-----|
| **Leuchte24** | Arka Sis Farı | C2-58-01 | BLK0 | DIM10 |
| **Leuchte25** | Plaka Aydınlatması | C2-59-01 | BLK0 | DIM5 |
| **Leuchte26** | Üçüncü Stop | C2-60-01 | BLK0 | DIM10 |
| **Leuchte27** | Ön İç Tavan | C2-12-05 | BLK7 | DIM5 |
| **Leuchte28** | Arka İç Tavan | C2-13-05 | BLK7 | DIM5 |
| **Leuchte29** | Ayak Alanı ⚠️ | - | BLK7 | DIM2 |
| **Leuchte30** | Ambient Işık ⚠️ | - | BLK0 | DIM3 |
| **Leuchte31** | Ek Fonksiyonlar | - | - | - |

⚠️ = Opsiyonel (Style pakette yoktur)

---

## 📚 Almanca Terimler Sözlüğü

### Işık Tipleri:
- **Standlicht** = Park lambası / Pozisyon lambası
- **Begrenzunglicht** = Park lambası (sınırlayıcı ışık)
- **Positionslicht** = Pozisyon lambası (yan lambalar)
- **Abblendlicht** = Kısa far
- **Fernlicht** = Uzun far
- **Tagfahrlicht** = Gündüz farı (DRL)
- **Nebelscheinwerfer** = Sis farı (ön)
- **Nebelschlussleuchte** = Sis lambası (arka)
- **Blinker** = Sinyal lambası
- **Bremslicht** = Fren lambası
- **Rückfahrlicht** = Geri vites lambası
- **Kennzeichenbeleuchtung** = Plaka aydınlatması
- **Innenraumbeleuchtung** = İç aydınlatma

### Fonksiyonlar:
- **Blinkfunktion** = Yanıp sönme fonksiyonu
- **Dimmfunktion** = Karartma/Dimming fonksiyonu
- **Lichtfunktion** = Işık fonksiyonu
- **Helligkeitsregelung** = Parlaklık ayarı

---

## 🎯 Pratik Kodlama Örnekleri

### Örnek 1: Coming Home Efekti
```
Leuchte0 (Sol Kısa Far)
├─ SLH = C1-58-05  (Halogen, dimming)
├─ BLK = BLK7      (Fade in/out - yumuşak)
└─ DIM = DIM4      (40% parlaklık)
```

### Örnek 2: DRL Aktivasyonu
```
Leuchte4 (Sol DRL)
├─ SLH = C1-42-02  (LED modül)
├─ BLK = BLK0      (Sabit yanma)
└─ DIM = DIM7      (70% - yasal standart)
```

### Örnek 3: Dinamik Sinyal (LED modül gerekli!)
```
Leuchte6 (Sol Ön Sinyal)
├─ SLH = C1-28-02  (LED modül)
├─ BLK = BLK10     (Sequential - sıralı)
└─ DIM = DIM10     (Tam güç)
```

### Örnek 4: Viraj Lambası
```
Leuchte10 (Sol Sis - Viraj Lambası olarak)
├─ SLH = C1-35-01  (Standart)
├─ BLK = BLK0      (Sabit)
└─ DIM = DIM10     (Tam güç)
+ Byte 3'te Cornering Light = 1
```

---

## ⚠️ Önemli Uyarılar

### Yasal Gereksinimler:
- 🔴 **DRL**: AB'de 2016+ araçlarda zorunlu
- 🔴 **Sinyal Frekansı**: 90 flaş/dakika (BLK2)
- 🔴 **Far Parlaklığı**: Kısa/uzun far tam güç (DIM10)
- 🔴 **Fren Lambası**: Çift taraflı, tam güç (DIM10)

### Teknik Kısıtlamalar:
- ❌ LED modül yoksa LED kodu kullanmayın
- ❌ Dimming desteklemeyen lambalara DIM ayarı yapmayın
- ❌ Fren lambalarını dim yapmayın (güvenlik!)
- ❌ Sinyal lambalarını çok hızlı/yavaş yapmayın

### Güvenlik:
- ⚠️ Farları yanıp sönen mod yapmayın (BLK0)
- ⚠️ DRL çok parlak olmamalı (DIM7 ideal)
- ⚠️ İç lambaları çok parlak yapmayın (gece körlüğü)

---

**Oluşturulma Tarihi**: 8 Kasım 2025  
**Hedef Araç**: 2016 Seat Leon Style (5F1)  
**VCDS Sürümü**: 20.x ve üzeri
