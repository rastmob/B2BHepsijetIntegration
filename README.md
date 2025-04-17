# 🚚 B2BHepsijetIntegration

.NET 7 tabanlı Clean Architecture mimarisi ile hazırlanmış Hepsijet B2B Marketplace entegrasyon projesi. Bu proje, Hepsijet API servislerine (token alma, gönderi oluşturma, mağaza kaydetme vs.) .NET Core üzerinden güvenli ve yapılandırılabilir şekilde bağlanmak için temel altyapıyı sağlar.

---

## 📦 Özellikler

- ✅ **Katmanlı Mimari** (API, Application, Domain, Infrastructure, Persistence)
- 🔐 **Token Bazlı Hepsijet API Entegrasyonu**
- 🧪 Swagger ile test edilebilir uç noktalar
- 🧱 Genişletilebilir yapı (CQRS, Logging, Caching vs. için hazır)
- 🌍 Çoklu ortamlar için kolay yapılandırma

---

## 🚀 Hızlı Kurulum

### 1. Repozitörü Klonla

```bash
git clone https://github.com/rastmob/B2BHepsijetIntegration.git
cd B2BHepsijetIntegration
```

### 2. .NET Sürümünü Kontrol Et

```bash
dotnet --version
# Örnek: 7.0.100 veya üstü
```

### 3. Gerekli Projeleri Çözüm Dosyasına Ekle

```bash
dotnet restore
dotnet build
```

### 4. API'yi Başlat

```bash
cd B2BHepsijetIntegration.API
dotnet run
```

> Swagger UI: `https://localhost:5001/swagger`

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

## 🔐 Hepsijet Token Alma Örneği

```csharp
var request = new HttpRequestMessage(HttpMethod.Get, "https://integration-apitest.hepsijet.com/auth/getToken");
var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

var response = await _httpClient.SendAsync(request);
var json = await response.Content.ReadAsStringAsync();
var token = JsonConvert.DeserializeObject<TokenResponse>(json)?.Data?.Token;
```

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