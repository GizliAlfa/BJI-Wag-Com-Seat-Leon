# VCDS Kodlama Tarifleri - 2016 Seat Leon Style Paket

## 📋 İçindekiler
- [Aydınlatma Özellikleri](#aydınlatma-özellikleri)
- [Konfor Özellikleri](#konfor-özellikleri)
- [Güvenlik Özellikleri](#güvenlik-özellikleri)
- [Silecek ve Cam Özellikleri](#silecek-ve-cam-özellikleri)
- [Menü ve Gösterge Özellikleri](#menü-ve-gösterge-özellikleri)
- [Klima Özellikleri](#klima-özellikleri)
- [Gelişmiş Özellikler](#gelişmiş-özellikler)

---

## Aydınlatma Özellikleri

### 💡 Coming Home / Leaving Home (Karşılama/Uğurlama Işıkları)

**Özellik Açıklaması:**  
Aracı kilitlediğinizde veya açtığınızda farlar belirli bir süre açık kalır. Karanlıkta aracınıza yaklaşırken veya ayrılırken yolu aydınlatır.

**Modül:** `09 - Central Electronics`  
**Kategori:** Long Coding → Byte 1

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Coming Home Duration** | `0` (Devre dışı) | `3` (30 saniye) | Araç açıldığında farlar 30 saniye açık kalır |
| **Leaving Home Duration** | `0` (Devre dışı) | `3` (30 saniye) | Araç kilitlendiğinde farlar 30 saniye açık kalır |
| **Leuchte0BLK** (Sol kısa far) | `BLK0` | `BLK7` | Yumuşak fade in/out efekti |
| **Leuchte0DIM** (Sol kısa far) | `DIM10` | `DIM4` | %40 parlaklık (gece için ideal) |
| **Leuchte1BLK** (Sağ kısa far) | `BLK0` | `BLK7` | Yumuşak fade in/out efekti |
| **Leuchte1DIM** (Sağ kısa far) | `DIM10` | `DIM4` | %40 parlaklık (gece için ideal) |

**Değerler:**
- `0` = Devre dışı
- `1` = 10 saniye
- `2` = 20 saniye
- `3` = 30 saniye (Önerilen)
- `4` = 40 saniye
- `5` = 60 saniye

**⚠️ Not:** Akü ömrü için 30-40 saniye ideal.

---

### 🌞 Gündüz Farı (DRL - Daytime Running Light)

**Özellik Açıklaması:**  
Gündüz vakti görünürlüğü artırmak için otomatik yanan farlar. 2016 sonrası araçlarda AB'de yasal zorunluluk. LED veya halogen olarak çalışabilir.

**Modül:** `09 - Central Electronics`  
**Kategori:** Long Coding → Byte 0

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Daytime Running Lights** | `0` veya `1` | `1` | DRL aktif (LED varsa) |
| **Leuchte4SLH** (Sol DRL) | `0` (Kapalı) | `C1-42-02` | LED modül (LED varsa) |
| **Leuchte4BLK** | `BLK0` | `BLK0` | Sabit yanma |
| **Leuchte4DIM** | `DIM0` | `DIM7` | %70 parlaklık (yasal standart) |
| **Leuchte5SLH** (Sağ DRL) | `0` (Kapalı) | `C1-43-02` | LED modül (LED varsa) |
| **Leuchte5BLK** | `BLK0` | `BLK0` | Sabit yanma |
| **Leuchte5DIM** | `DIM0` | `DIM7` | %70 parlaklık (yasal standart) |

**Değerler:**
- `0` = DRL devre dışı
- `1` = DRL aktif (LED varsa)
- `2` = DRL aktif (Halogen)
- `3` = DRL aktif (Kısa far yarım güç) ⚠️ *Ampul ömrünü kısaltır*

**⚠️ Not:** LED DRL modülü yoksa halogen sis farlarını DRL olarak kullanabilirsiniz (Byte 0 = 2).

**LED Modülü Yoksa Alternatif:**  
Sis farlarını DRL olarak kullanma:
- `Leuchte10SLH` = `C1-35-01` (Sol sis)
- `Leuchte10DIM` = `DIM5` (%50 parlaklık)
- Byte 0 değerini `2` yapın (Halogen DRL modu)

---

### 🔦 Sis Farını Viraj Lambası Yapma (Cornering Light)

**Özellik Açıklaması:**  
Direksiyonu sağa/sola çevirdiğinizde ilgili taraftaki sis farı yanar ve virajı aydınlatır. Özellikle dar sokaklarda ve park manevrasında çok kullanışlıdır.

**Modül:** `09 - Central Electronics`  
**Kategori:** Long Coding → Byte 3

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Cornering Light Function** | `0` (Devre dışı) | `1` | Sis farı ile viraj aydınlatması |
| **Leuchte10SLH** (Sol sis) | `C1-35-01` | `C1-35-01` | Değiştirmeyin |
| **Leuchte10BLK** | `BLK0` | `BLK0` | Sabit yanma |
| **Leuchte10DIM** | `DIM10` | `DIM10` | Tam güç |
| **Leuchte11SLH** (Sağ sis) | `C1-36-01` | `C1-36-01` | Değiştirmeyin |
| **Leuchte11BLK** | `BLK0` | `BLK0` | Sabit yanma |
| **Leuchte11DIM** | `DIM10` | `DIM10` | Tam güç |

**Değerler:**
- `0` = Devre dışı
- `1` = Sis farı ile aktif (Önerilen)
- `2` = Ayrı lamba ile aktif ⚠️ *Donanım gerekli*

**Çalışma Mantığı:**
- Hız < 40 km/h olmalı
- Direksiyon >30° çevrilmeli
- Kısa far açık olmalı
- İlgili taraf sis farı yanar (sağa kırdığınızda sağ sis, sola kırdığınızda sol sis)

---

### 🚦 Amerikan Park (Sinyal + Park Lambası)

**Özellik Açıklaması:**  
Kontak kapalıyken sinyal kolunu sağa/sola çevirdiğinizde o taraftaki park lambası + sinyal lambası açık kalır. Yolda park ederken arabanızı daha görünür yapar (Amerika'da yaygın).

**Modül:** `09 - Central Electronics`  
**Kategori:** Adaptation Channels veya Long Coding

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **American Parking Lights** | `0` (Devre dışı) | `1` | Amerikan park modu aktif |
| **Leuchte12SLH** (Sol park) | `C1-40-01` | `C1-40-01` | Değiştirmeyin |
| **Leuchte12DIM** | `DIM3` | `DIM3` | %30 parlaklık |
| **Leuchte13SLH** (Sağ park) | `C1-41-01` | `C1-41-01` | Değiştirmeyin |
| **Leuchte13DIM** | `DIM3` | `DIM3` | %30 parlaklık |

**Değerler:**
- `0` = Devre dışı (Normal Avrupa park lambası)
- `1` = Amerikan park modu aktif

**Kullanım:**
1. Aracı park edin, motoru kapatın
2. Sinyal kolunu SAĞa çevirin → Sağ taraf lambaları yanık kalır
3. Sinyal kolunu SOLA çevirin → Sol taraf lambaları yanık kalır
4. Sinyal kolunu ortaya alın → Lambalar söner

**⚠️ Dikkat:** Akü boşalmasını önlemek için uzun süre kullanmayın!

---

### 💫 Dinamik Sinyal (Sequential Turn Signal)

**Özellik Açıklaması:**  
Sinyal verdiğinizde lambalar içeriden dışarıya doğru sırayla yanar (Audi/VW üst modellerde standart). Çok şık bir görüntü verir.

**Modül:** `09 - Central Electronics`  
**Kategori:** Long Coding

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Leuchte6SLH** (Sol ön sinyal) | `C1-28-01` | `C1-28-02` | LED modül GEREKLİ! |
| **Leuchte6BLK** | `BLK2` | `BLK10` | Sequential (sıralı yanma) |
| **Leuchte7SLH** (Sağ ön sinyal) | `C1-29-01` | `C1-29-02` | LED modül GEREKLİ! |
| **Leuchte7BLK** | `BLK2` | `BLK10` | Sequential (sıralı yanma) |
| **Leuchte20SLH** (Sol arka sinyal) | `C2-54-01` | `C2-54-02` | LED modül GEREKLİ! |
| **Leuchte20BLK** | `BLK2` | `BLK10` | Sequential (sıralı yanma) |
| **Leuchte21SLH** (Sağ arka sinyal) | `C2-55-01` | `C2-55-02` | LED modül GEREKLİ! |
| **Leuchte21BLK** | `BLK2` | `BLK10` | Sequential (sıralı yanma) |

**⚠️ ÇOK ÖNEMLİ:**
- Bu özellik için **dinamik LED sinyal modülü** GEREKLİDİR!
- Style pakette STANDART DEĞİLDİR!
- Halogen sinyallerde ÇALIŞMAZ!
- Aftermarket LED modül takılmalı veya üst paket far grubu gerekli

**Değerler (BLK):**
- `BLK2` = Normal yanıp sönme (Standart)
- `BLK10` = Sequential (Dinamik/Sıralı)

---

### 🌃 Motorway Light (Otoyol Işığı)

**Özellik Açıklaması:**  
Otoyolda yüksek hızda (130+ km/h) giderken farların menzili otomatik olarak uzar, daha iyi aydınlatma sağlar.

**Modül:** `09 - Central Electronics`  
**Kategori:** Long Coding → Byte 2

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Motorway Mode** | `0` (Devre dışı) | `1` | Otoyol modu aktif |
| **Dynamic Headlight Range** | `0` (Statik) | `1` | Dinamik far seviye ayarı |

**Değerler:**
- `0` = Devre dışı
- `1` = 130 km/h üzerinde ek aydınlatma

**⚠️ Not:** Xenon veya LED farlar için daha etkilidir. Halogen farlarda fark minimum olabilir.

---

## Konfor Özellikleri

### 🔐 15 km/h Otomatik Kilitleme

**Özellik Açıklaması:**  
Araç 15 km/h hızı geçince tüm kapılar otomatik olarak kilitlenir. Hırsızlık ve çocuk güvenliği için yararlıdır.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding → Byte 5 veya Adaptation

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Auto Door Lock at Speed** | `0` (Devre dışı) | `1` | 15 km/h'de otomatik kilitle |
| **Tuer_AutoLock_Speed** | `0` | `15` | Kilitleme hızı (km/h) |

**Değerler:**
- `0` = Devre dışı
- `1` = 15 km/h (Önerilen)
- `20` = 20 km/h

**Ek Seçenek - Kontak Kapatınca Kilit Açma:**

| Parametre | Default | Önerilen | Açıklama |
|-----------|---------|----------|----------|
| **Auto Unlock on Ignition Off** | `0` | `1` | Kontak kapanınca kilidi aç |

---

### 🚪 Çift Kademeli Kilit Açma (Selective Unlock)

**Özellik Açıklaması:**  
Uzaktan kumandada kilit açma tuşuna ilk basışta sadece sürücü kapısı açılır. İkinci basışta tüm kapılar açılır. Güvenlik için kullanışlıdır.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Double Unlock Press** | `0` | `1` | Çift kademeli açma |
| **Selective Unlock** | `0` | `1` | Seçici kilit açma aktif |

**Değerler:**
- `0` = Tek basışta tüm kapılar açılır (Fabrika)
- `1` = İlk basış: Sürücü, İkinci basış: Tüm kapılar (Önerilen)

**Çalışma Mantığı:**
1. Uzaktan kumanda: **1. Basış** → Sadece sürücü kapısı açılır
2. Uzaktan kumanda: **2. Basış** → Tüm kapılar açılır

---

### 🔊 Kilitleme Sesi (Acoustic Confirmation)

**Özellik Açıklaması:**  
Araç kilitlendiğinde veya kilit açıldığında "bip" sesi verir. Aracın kilitlendiğinden emin olmanızı sağlar.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding → Byte 0

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Acoustic Confirmation** | `0` (Sessiz) | `1` | Sesli uyarı (bip) |
| **Tuer_AcousticLock** | `0` | `2` | Kilitleme + kilit açma sesi |
| **Tuer_AcousticVolume** | `0` | `2` | Orta ses şiddeti |

**Değerler (Acoustic Confirmation):**
- `0` = Sadece sinyal lambası (Sessiz)
- `1` = Sesli uyarı (bip sesi)

**Değerler (AcousticLock):**
- `0` = Sessiz
- `1` = Sadece kilitleme sesi
- `2` = Kilitleme + kilit açma sesi (Önerilen)

**Değerler (Ses Şiddeti):**
- `0` = Sessiz
- `1` = Düşük
- `2` = Orta (Önerilen)
- `3` = Yüksek

---

### 🪟 Uzaktan Kumanda ile Cam Açma/Kapama (Convenience Open/Close)

**Özellik Açıklaması:**  
Uzaktan kumandada kilit açma/kapama tuşunu 3 saniye basılı tuttuğunuzda camlar açılır/kapanır. Yaz sıcağında araç havalandırmak için harikadır.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding → Byte 2

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Fenster_ComfortOpen** | `0` (Devre dışı) | `1` | Camları açma aktif |
| **Fenster_ComfortClose** | `0` (Devre dışı) | `1` | Camları kapama aktif |
| **Windows via Remote** | `0` | `3` | Her ikisi de aktif |

**Değerler:**
- `0` = Devre dışı
- `1` = Sadece açma
- `2` = Sadece kapama
- `3` = Hem açma hem kapama (Önerilen)

**Kullanım:**
- **Cam açma:** Kilit **AÇMA** tuşunu 3 saniye basılı tut → Camlar açılır
- **Cam kapama:** Kilit **KAPAMA** tuşunu 3 saniye basılı tut → Camlar kapanır

**⚠️ Güvenlik:** Camları kapatırken çocuk/hayvan araçta olmamalı (sıkışma riski)!

---

### 🪞 Geri Viteste Ayna Eğilme (Mirror Tilt in Reverse)

**Özellik Açıklaması:**  
Geri vitese attığınızda sağ (veya sol) ayna otomatik olarak aşağı eğilir, kaldırımı ve park çizgilerini görebilirsiniz. Park ederken çok kullanışlıdır.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding → Byte 5

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Mirror Tilt in Reverse** | `0` (Devre dışı) | `1` | Sağ ayna aşağı eğilir |
| **Spiegel_TiltReverse** | `0` | `1` | Geri viteste eğilme aktif |
| **Spiegel_TiltAngle** | `0` | `8` | Eğilme açısı (8 derece ideal) |

**Değerler:**
- `0` = Devre dışı
- `1` = Geri viteste sağ ayna eğilir (Önerilen - yolcu tarafı)
- `2` = Geri viteste sol ayna eğilir
- `3` = Her iki ayna eğilir ⚠️ *Kontrol gerekebilir*

**⚠️ Not:** Elektrikli ayarlanabilir ayna gereklidir! Manuel aynalarda çalışmaz.

---

### 🪞 Kilitleme ile Ayna Katlanması (Auto Fold on Lock)

**Özellik Açıklaması:**  
Aracı kilitlediğinizde dış aynalar otomatik olarak katlanır. Aracı açtığınızda otomatik açılır. Dar sokaklarda ve güvenlik için yararlıdır.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding → Byte 2

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Mirror Auto Fold on Lock** | `0` (Devre dışı) | `1` | Kilitleme ile katlan |
| **Spiegel_AutoFold** | `0` | `1` | Elektrikli katlanır modül |
| **Spiegel_AutoFold_OnLock** | `0` | `1` | Kilitleme ile katlanma |
| **Spiegel_AutoFold_OnStart** | `0` | `1` | Motor çalışınca açılma |

**Değerler:**
- `0` = Devre dışı
- `1` = Aktif

**⚠️ ÇOK ÖNEMLİ:**
- Bu özellik için **elektrikli katlanır ayna modülü** GEREKLİDİR!
- 2016 Leon Style pakette STANDART DEĞİLDİR!
- Aftermarket veya orijinal katlanır ayna takılmalı
- Sadece kodlama ile çalışmaz!

---

### 🌧️ Geri Viteste Arka Silecek (Auto Rear Wiper in Reverse)

**Özellik Açıklaması:**  
Ön silecek çalışırken geri vitese attığınızda arka silecek otomatik olarak çalışmaya başlar. Yağmurda park yaparken çok kullanışlıdır.

**Modül:** `09 - Central Electronics`  
**Kategori:** Long Coding → Byte 7

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Rear Wiper in Reverse** | `0` (Devre dışı) | `1` | Geri viteste arka silecek |
| **Wischer_hinten_AutoReverse** | `0` | `1` | Otomatik aktivasyon |

**Değerler:**
- `0` = Devre dışı
- `1` = Geri viteste otomatik çalışır

**Çalışma Mantığı:**
1. Ön silecek çalışıyor olmalı (aralıklı veya sürekli)
2. Geri vitese atın
3. Arka silecek otomatik olarak çalışır
4. Geri vitesten çıkınca arka silecek durur

---

## Güvenlik Özellikleri

### 🔒 Güvenli Kilit (Safe Lock)

**Özellik Açıklaması:**  
Araç kilitlendiğinde içeriden kapı kolları devre dışı kalır, araç içeriden açılamaz. Hırsızlık girişimlerinde pencere kırılsa bile kapı açılamaz.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding → Byte 5

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Safe Lock** | `0` (Normal kilit) | `1` | Güvenli kilit aktif |
| **Auto Safe After Time** | `0` | `1` | 2 dakika sonra otomatik safe |

**Değerler:**
- `0` = Normal kilit (içeriden açılabilir)
- `1` = Güvenli kilit (içeriden açılamaz)

**Değerler (Auto Safe):**
- `0` = Manuel safe moda geçiş
- `1` = Kilitli kalırsa 2 dakika sonra otomatik safe

**⚠️ ÇOK ÖNEMLİ:**
- Safe mode aktifken araç içinde kimse olmamalı!
- İçeride kalan kişi dışarı çıkamaz!
- Acil durumlarda tehlikeli olabilir!
- Çocuk/hayvan araçta bırakmayın!

---

### 🔔 Anahtar ve Far Uyarıları

**Özellik Açıklaması:**  
Kontak kapalıyken sürücü kapısı açılırsa ve anahtar kontakta ise veya farlar açıksa sesli uyarı verir. Akü boşalmasını önler.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding → Byte 3

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Key in Ignition Warning** | `0` | `1` | Anahtar kontakta uyarısı |
| **Lights On Warning** | `0` | `1` | Farlar açık uyarısı |
| **Tuer_KeyInIgnition_Warning** | `0` | `1` | Kontak açık + kapı açık = bip |
| **Tuer_LightsOn_Warning** | `0` | `1` | Farlar açık + kontak kapalı = bip |

**Değerler:**
- `0` = Uyarı yok
- `1` = Sesli uyarı (bip sesi) aktif

---

## Silecek ve Cam Özellikleri

### 🌧️ Yağmur Sensörü Aktivasyonu

**Özellik Açıklaması:**  
Cam üzerindeki sensör yağmuru algılar ve silecekleri otomatik olarak çalıştırır. Hassasiyeti ayarlanabilir.

**Modül:** `09 - Central Electronics`  
**Kategori:** Long Coding → Byte 7

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Rain Sensor** | `0` (Yok) | `1` | Yağmur sensörü var |
| **Rain Sensor Sensitivity** | `0` | `2` | Yüksek hassasiyet |

**Değerler (Sensor):**
- `0` = Yok (Style standart)
- `1` = Var ⚠️ *Fiziksel sensör gerekli*

**Değerler (Hassasiyet):**
- `0` = Düşük (az yağmurda çalışmaz)
- `1` = Orta
- `2` = Yüksek (Önerilen)
- `3` = Çok yüksek (çok hassas)

**⚠️ ÖNEMLİ:**
- Fiziksel yağmur sensörü GEREKLİDİR!
- Style pakette genelde YOKTUR!
- Cam üzerine sensör takılmalı

---

### 🪟 Tek Dokunuş Cam Açma/Kapama (One-Touch Window)

**Özellik Açıklaması:**  
Cam düğmesine hafifçe dokunduğunuzda cam tamamen açılır veya kapanır. Basılı tutmanıza gerek kalmaz.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Fenster_FL_OneTouch** | `1` (Sadece aşağı) | `2` | Aşağı + yukarı tek dokunuş |
| **Fenster_FR_OneTouch** | `1` | `2` | Sağ ön cam |
| **Fenster_RL_OneTouch** | `0` | `1` | Sol arka cam (sadece aşağı) |
| **Fenster_RR_OneTouch** | `0` | `1` | Sağ arka cam (sadece aşağı) |

**Değerler:**
- `0` = Tek dokunuş yok (basılı tutmalısınız)
- `1` = Sadece aşağı tek dokunuş (Ön camlar standart)
- `2` = Aşağı + yukarı tek dokunuş (Önerilen)

**⚠️ Not:** Arka camlar genelde sadece aşağı tek dokunuş destekler (güvenlik).

---

### 🛡️ Cam Sıkışma Koruması (Pinch Protection)

**Özellik Açıklaması:**  
Cam kapanırken bir engel algılarsa (el, parmak, vb.) otomatik olarak durur ve geri açılır. Güvenlik özelliğidir.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Long Coding

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Fenster_FL_PinchProtection** | `1` | `1` | Sıkışma koruması aktif |
| **Fenster_ReverseSensitivity** | `3` | `2` | Orta hassasiyet |

**Değerler (Protection):**
- `0` = Sıkışma koruması yok ⚠️ *TEHLİKELİ!*
- `1` = Sıkışma koruması var (Önerilen)
- `2` = Hassas sıkışma koruması

**Değerler (Hassasiyet):**
- `1` = Çok hassas (çok hafif dokunuşta durur)
- `2` = Orta (Önerilen)
- `3` = Az hassas (daha fazla kuvvet gerekir)
- `4-5` = Çok az hassas ⚠️ *Güvenli değil*

**⚠️ GÜVENLİK:** Asla devre dışı bırakmayın! Çocuk güvenliği için kritiktir.

---

## Menü ve Gösterge Özellikleri

### 🎯 İğne Tarama (Needle Sweep)

**Özellik Açıklaması:**  
Kontak açıldığında gösterge panelindeki tüm iğneler (hız, devir, yakıt, sıcaklık) maksimuma kadar tur atar. Görsel olarak çok hoş bir efekttir.

**Modül:** `17 - Instrument Cluster`  
**Kategori:** Long Coding → Byte 6

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Startup Needle Sweep** | `0` (Devre dışı) | `1` | İğne tarama aktif |
| **Sweep Type** | `0` | `0` | Normal hız (yumuşak) |

**Değerler:**
- `0` = İğneler tarama yapmaz (fabrika)
- `1` = İğneler kontak açılışta tur atar (Önerilen)

---

### 🌡️ Dijital Hız Göstergesi

**Özellik Açıklaması:**  
Gösterge panelinin ortasındaki küçük ekranda dijital olarak hızınızı gösterir. Analog göstergeye ek olarak kesin hız bilgisi verir.

**Modül:** `17 - Instrument Cluster`  
**Kategori:** Long Coding → Byte 8

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Digital Speed Display** | `0` (Devre dışı) | `1` | Dijital hız göster |
| **Menu_DigitalSpeed** | `0` | `1` | MFD'de dijital hız |

**Değerler:**
- `0` = Devre dışı
- `1` = MFD'de dijital hız göstergesi (Önerilen)

---

### ⚠️ Hız Uyarısı (Speed Warning)

**Özellik Açıklaması:**  
Belirlediğiniz hızı geçtiğinizde gösterge panelinde uyarı verir. Hız limitlerini aşmamak için kullanışlıdır.

**Modül:** `17 - Instrument Cluster`  
**Kategori:** Long Coding → Byte 3

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Speed Warning** | `0` (Devre dışı) | `1` | Hız uyarısı aktif |
| **Warning Threshold** | `0` | `120` | 120 km/h'de uyar |
| **Menu_SpeedWarning** | `0` | `1` | Uyarı sistemi aktif |

**Değerler:**
- `0` = Devre dışı
- `1` = Hız uyarısı aktif

**Uyarı Hızı:**
- Türkiye için: `90`, `110`, `120`, `130` km/h
- Manuel ayarlanabilir (0-250 km/h arası)

---

### ⚙️ Vites Önerisi (Gear Recommendation)

**Özellik Açıklaması:**  
Manuel şanzımanlı araçlarda yakıt ekonomisi için en uygun vitesi önerir. MFD'de "↑5" gibi gösterir (5. vitese geç).

**Modül:** `17 - Instrument Cluster`  
**Kategori:** Long Coding → Byte 8

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Gear Recommendation** | `0` veya `1` | `1` | Vites önerisi aktif |

**Değerler:**
- `0` = Devre dışı (otomatik şanzıman)
- `1` = Vites önerisi aktif (manuel şanzıman - Style)

**⚠️ Not:** Sadece manuel şanzımanlı araçlarda çalışır. DSG'de anlamsızdır.

---

## Klima Özellikleri

### ❄️ Otomatik Buğu Çözme (Auto Defrost)

**Özellik Açıklaması:**  
Dış sıcaklık 5°C altına düştüğünde veya nem sensörü buğu algıladığında klimatik otomatik olarak buğu çözme moduna geçer.

**Modül:** `08 - Air Conditioning`  
**Kategori:** Long Coding → Byte 3

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Auto Defrost** | `0` (Devre dışı) | `1` | 5°C altında otomatik |
| **Klima_AutoDefrost** | `0` | `1` | Otomatik buğu çözme |

**Değerler:**
- `0` = Devre dışı (manuel buğu çözme)
- `1` = 5°C altında otomatik buğu çözme
- `2` = Nem sensörü ile otomatik ⚠️ *Sensör gerekli*

---

### 🌡️ Varsayılan Klima Sıcaklığı

**Özellik Açıklaması:**  
Araç her başlatıldığında klimatik bu sıcaklığa ayarlanır. Konfor için idealdir.

**Modül:** `08 - Air Conditioning`  
**Kategori:** Adaptation → Default Temperature

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Default Temperature** | `21` veya `22` | `22` | 22°C (ideal konfor) |

**Değerler:**
- `18-28` °C arası (genelde `21-22°C` önerilir)

---

## Gelişmiş Özellikler

### 🚗 Cruise Control Minimum Hız

**Özellik Açıklaması:**  
Hız sabitleyicinin çalışabileceği minimum hızı belirler. Düşük hızlarda da hız sabitlemek isterseniz azaltabilirsiniz.

**Modül:** `09 - Central Electronics`  
**Kategori:** Adaptation → Cruise Control

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **CruiseControl_MinSpeed** | `40` km/h | `30` km/h | Düşük hızda da çalışır |

**Değerler:**
- `30` km/h = Şehir içi için uygun
- `40` km/h = Standart (fabrika)
- `50` km/h = Sadece otoyol

---

### 🔊 Emniyet Kemeri Uyarı Süresi

**Özellik Açıklaması:**  
Kemer takılı değilse sesli uyarının ne kadar süreceğini ayarlar. Rahatsız edici ise süreyi kısaltabilirsiniz (önerilmez).

**Modül:** `17 - Instrument Cluster`  
**Kategori:** Long Coding → Byte 9

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Seatbelt Warning Duration** | `90` saniye | `60` saniye | 60 saniye uyarı |

**Değerler:**
- `30` = 30 saniye
- `60` = 60 saniye (Önerilen)
- `90` = 90 saniye (fabrika)
- `255` = Sürekli (kemer takılana kadar)

**⚠️ GÜVENLİK:** Emniyet kemeri hayat kurtarır! Uyarıyı kapatmayın, kemerinizi takın!

---

### 🅿️ Park Sensörü Ses Şiddeti

**Özellik Açıklaması:**  
Park sensörlerinin bip sesinin şiddetini ayarlar. Çok yüksekse rahatsız edebilir.

**Modül:** `46 - Central Comfort System`  
**Kategori:** Adaptation → PDC Volume

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **PDC_Volume** | `2` (Orta) | `2` | Orta ses şiddeti |

**Değerler:**
- `0` = Sessiz (önerilmez)
- `1` = Düşük
- `2` = Orta (Önerilen)
- `3` = Yüksek

**⚠️ Not:** Style pakette park sensörü opsiyoneldir.

---

### 🔋 Kontak Kapatıldıktan Sonra Aksesuar Gücü Süresi

**Özellik Açıklaması:**  
Kontak kapatıldıktan sonra radyo, camlar, vb. ne kadar süre daha çalışabilir. Akü koruma için önemlidir.

**Modül:** `09 - Central Electronics`  
**Kategori:** Adaptation → Klemme 15 Timeout

| Parametre | Default (Fabrika) | Önerilen Değer | Açıklama |
|-----------|-------------------|----------------|----------|
| **Klemme15_Timeout** | `10` dakika | `10` dakika | 10 dakika sonra kes |

**Değerler:**
- `0` = Hemen kesilir (önerilmez)
- `5` = 5 dakika
- `10` = 10 dakika (Önerilen)
- `60` = 60 dakika ⚠️ *Akü boşalabilir*
- `255` = Süresiz ⚠️ *Akü biter!*

---

## 📝 Kodlama Öncesi Kontrol Listesi

### ✅ Yapmadan Önce:
1. **VCDS ile bağlantıyı test edin**
2. **Mevcut kodları yedekleyin** (Auto-Scan → Save)
3. **Akü voltajını kontrol edin** (12.5V+ olmalı)
4. **Motor kapalı, kontak açık** olmalı
5. **Tüm elektrikli cihazları kapatın** (klima, radyo, vb.)

### ✅ Kodlama Sırasında:
1. **Bir seferde bir modülde çalışın**
2. **Bir seferde bir özellik aktifleştirin**
3. **Her değişiklikten sonra kaydedin**
4. **Hata kodu kontrolü yapın**

### ✅ Kodlama Sonrası:
1. **Aracı test edin** (her özelliği deneyin)
2. **Hata kodlarını tekrar kontrol edin**
3. **Sorun varsa önceki değerlere dönün**
4. **Yeni yedek alın** (çalışan konfigürasyon)

---

## ⚠️ Önemli Uyarılar

### 🔴 Asla Dokunmayın:
- ❌ İmmobilizer ayarları
- ❌ Airbag kodlama
- ❌ ABS/ESP modül varlığı
- ❌ CAN Gateway devre dışı bırakma
- ❌ Güvenlik kritik parametreler

### 🟡 Dikkatli Olun:
- ⚠️ Far kodlamaları (yasal gereksinimler)
- ⚠️ Emniyet kemeri uyarıları (güvenlik)
- ⚠️ Cam sıkışma koruması (güvenlik)
- ⚠️ Fren lambası ayarları (güvenlik)

### 🟢 Güvenle Yapabilirsiniz:
- ✅ Coming/Leaving Home
- ✅ Kilitleme sesleri
- ✅ Menü dili/birimleri
- ✅ İğne tarama
- ✅ Klima varsayılan sıcaklık

---

## 🛠️ Sorun Giderme

### "Coding Failed" Hatası
**Sebep:** Yanlış kod veya yetkisiz modül  
**Çözüm:** Login yapın (code: 31347) ve tekrar deneyin

### Özellik Çalışmıyor
**Sebep:** Fiziksel donanım eksik  
**Çözüm:** Donanım varlığını kontrol edin (LED modül, elektrikli ayna, vb.)

### Hata Kodları Geldi
**Sebep:** Yanlış Leuchte kodu  
**Çözüm:** SLH kodunu kontrol edin, fiziksel lambayla eşleşmeli

### Akü Boşalıyor
**Sebep:** Klemme15 timeout çok uzun  
**Çözüm:** Timeout'u 10 dakikaya düşürün

---

**Oluşturulma Tarihi:** 7 Kasım 2025  
**Hedef Araç:** 2016 Seat Leon Style Paket (5F1)  
**VCDS Sürümü:** 20.x ve üzeri

**⚠️ Yasal Uyarı:** Araç kodlamaları trafik güvenliğini etkileyebilir. Tüm değişiklikler kendi sorumluluğunuzdadır. Yasal gereksinimlere uygun hareket edin. Emin olmadığınız durumlarda profesyonel yardım alın.
