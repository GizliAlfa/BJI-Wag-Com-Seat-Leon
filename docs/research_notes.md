# VAG-COM Seat Leon Araştırma Notları

## 🚗 Seat Leon Genel Bilgileri

### Nesil Bilgileri
- **Leon 1 (1M)**: 1999-2006 → PQ34 platform
- **Leon 2 (1P)**: 2005-2012 → PQ35 platform  
- **Leon 3 (5F)**: 2012-2020 → MQB platform
- **Leon 4 (KL)**: 2020+ → MQB Evo platform

### ECU Modülleri (Tipik)
- **01 - Motor ECU** (Engine Control Module)
- **02 - Otomatik Şanzıman** (Auto Transmission)
- **03 - ABS** (Anti-lock Braking System)
- **08 - Klima** (Air Conditioning)
- **09 - Central Electronics** (Comfort Control)
- **15 - Airbag** (SRS)
- **17 - İnstrument Cluster** (Dashboard)
- **19 - CAN Gateway**
- **46 - Central Comfort** (Keyless, etc.)

## 🔌 İletişim Protokolleri

### K-Line (ISO 9141-2)
```
Protokol: KWP2000
Baud Rate: 9600/10400 bps
Connector: OBD-II Pin 7 (K-Line)
Voltage: 12V logic
```

### CAN Bus (ISO 11898)
```
High Speed CAN: 500 kbps
Low Speed CAN: 125 kbps  
Connector: OBD-II Pin 6/14
Protocol: UDS (ISO 14229)
```

## 🛠️ VAG-COM/VCDS

### Desteklenen İşlemler
- **Auto-Scan**: Tüm ECU'ları tara
- **Fault Codes**: Hata kodları oku/sil
- **Measuring Values**: Gerçek zamanlı veri
- **Basic Settings**: Temel ayarlar
- **Adaptations**: Adaptasyon değerleri
- **Coding**: ECU kodlama
- **Login**: Güvenlik erişimi

### Tipik VAG Kodları
```
00000 - No Fault Found
00001 - ECU not responding  
00515 - Intake Air Temperature Sensor
00519 - Lambda Sensor
01314 - Engine Control Module
```

## 🔧 BJI Potansiyel Anlamları

### Olasılıklar:
1. **Brand/Company Name** → Özel diagnostik yazılım
2. **Bus Junction Interface** → CAN bus arayüz
3. **Basic Injection Interface** → Yakıt enjeksiyon
4. **Bosch Joint Initiative** → Bosch ortak proje
5. **Custom Tool Name** → Özelleştirilmiş araç

## 📊 Diagnostik Data Örnekleri

### Motor Parametreleri
```
RPM: 0-8000
Coolant Temp: -40°C to 150°C  
Intake Temp: -40°C to 120°C
Load: 0-100%
Throttle: 0-100%
Lambda: 0.5-1.5
Fuel Pressure: 0-8 bar
```

### Transmission (DSG)
```
Oil Temp: -40°C to 150°C
Gear: P,R,N,D,S,1-7
Clutch Position: 0-100%
```

## 🎯 Proje Potansiyel Özellikleri

### Temel Özellikler
- [ ] ECU tarama ve tanımlama
- [ ] Hata kodu okuma/silme  
- [ ] Gerçek zamanlı veri gösterimi
- [ ] Parametrik ölçümler

### Gelişmiş Özellikler  
- [ ] ECU kodlama/adaptasyon
- [ ] Özel funktionlar (Coding helper)
- [ ] Log kaydı ve analiz
- [ ] Grafik gösterim

### BJI Özel Özellikler
- [ ] [Belirlenmeli - BJI ne anlama geliyor?]
- [ ] Özel diagnostik rutinler
- [ ] Seat Leon optimizasyonları

## 🔍 Araştırılması Gerekenler

1. **BJI tanımı nedir?**
2. **Hangi Seat Leon modeli hedef?**
3. **Hangi ECU modülleri öncelikli?** 
4. **Yazılım platformu tercihi?**
5. **Donanım gereksinimleri neler?**

---
**Araştırma Tarihi**: 7 Kasım 2025