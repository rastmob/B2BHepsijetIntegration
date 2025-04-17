# 🚚 B2BHepsijetIntegration

.NET 7 tabanlı Clean Architecture mimarisi ile hazırlanmış Hepsijet B2B Marketplace entegrasyon projesi. Bu proje, Hepsijet API servislerine (token alma, gönderi oluşturma, mağaza kaydetme vs.) .NET Core üzerinden güvenli ve yapılandırılabilir şekilde bağlanmak için temel altyapıyı sağlar.

---

## 📦 Özellikler

- ✅ **Katmanlı Mimari** (API, Application, Domain, Infrastructure, Persistence)
- 🔐 **Token Bazlı Hepsijet API Entegrasyonu**
- 🧾 Gönderi oluşturma (sendDeliveryAdvance/v2) servisi hazır
- 🧪 Swagger ile test edilebilir uç noktalar
- 🧱 Genişletilebilir yapı (CQRS, Logging, Caching vs. için hazır)
- 🌍 Çoklu ortamlar için kolay yapılandırma

---

## 🚀 Hızlı Kurulum

### 1. Repoyu Klonla

```bash
git clone https://github.com/rastmob/B2BHepsijetIntegration.git
cd B2BHepsijetIntegration
```

### 2. .NET Sürümünü Kontrol Et

```bash
dotnet --version
# En az: 7.0.100
```

### 3. Derleme ve Çalıştırma

```bash
dotnet restore
dotnet build
cd B2BHepsijetIntegration.API
dotnet run
```

> Swagger UI: `http://localhost:5143/swagger`

---

## 📁 Proje Yapısı

```
B2BHepsijetIntegration/
├── B2BHepsijetIntegration.API          → ASP.NET Core Web API
├── B2BHepsijetIntegration.Application  → Servis Arayüzleri ve UseCase Logic
├── B2BHepsijetIntegration.Domain       → Domain modelleri, Entity'ler
├── B2BHepsijetIntegration.Infrastructure → Dış servis bağlantıları (örneğin Hepsijet)
├── B2BHepsijetIntegration.Persistence  → Veritabanı işlemleri (EF Core, Repo Pattern)
```

---

## 🔐 API Özellikleri

### 1. Token Alma

```
GET /api/auth/get-token?username=xxx&password=yyy
```

Header Authorization gerekmez. Basic Auth yapılır.

### 2. Gönderi Oluşturma (V2)

```
POST /api/delivery/send-advance
```

Header'da `X-Auth-Token` gönderilmelidir.  
Body: `DeliveryAdvanceRequest` JSON (örnekler Swagger'da mevcuttur)

---

## 🧪 Test Edilecek Örnek Dummy Veriler

- Firma: Rast Mobile
- Kullanıcı: Mehmet Alp
- Email: mobilerast@gmail.com
- Şehir: İstanbul
- İlçe: Merter
- Adres: Alparslan İş Merkezi, Merter, İstanbul

---

## 🌐 Bağlantılar

- 🧠 [Rast Mobile Website](https://www.rastmobile.com)
- 💻 [Rast Mobile GitHub](https://github.com/rastmob)
- 💼 [Rast Mobile LinkedIn](https://www.linkedin.com/company/rastmobile)

---

## ✍️ İletişim

- **Author:** Mehmet Alp  
- 📧 mehmet.alp@rastmobile.com  
- 📬 mobilerast@gmail.com  

---

## 🔍 Etiketler / Anahtar Kelimeler

```
hepsijet, hepsijet entegrasyonu, hepsilojistik, hepsijet dotnet, hepsijet api, b2b entegrasyon, rastmobile
```

---

## 📄 Lisans

MIT Lisansı altında açık kaynak olarak sunulmaktadır.