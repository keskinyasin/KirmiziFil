# Kırmızı Fil Coding Standards

## Amaç

Bu doküman, Kırmızı Fil projesinde tüm geliştiricilerin aynı standartlarda kod yazmasını sağlamak amacıyla hazırlanmıştır.

Kod;

- Okunabilir
- Sürdürülebilir
- Test edilebilir
- Tekrar kullanılabilir
- Tutarlı

olmalıdır.

---

# Genel Kurallar

- Clean Code prensipleri uygulanacaktır.
- SOLID prensipleri takip edilecektir.
- DRY (Don't Repeat Yourself) uygulanacaktır.
- KISS (Keep It Simple) uygulanacaktır.
- YAGNI (You Aren't Gonna Need It) prensibi gözetilecektir.

---

# İsimlendirme

## Sınıflar

PascalCase

Örnek

ProductService

RepairEvent

BlogPost

---

## Interface

I ile başlar.

Örnek

IProductService

IRepository

---

## Metotlar

PascalCase

Örnek

GetProducts()

CreateEvent()

DeleteBlog()

---

## Property

PascalCase

Örnek

Title

Description

CreatedAt

---

## Değişkenler

camelCase

Örnek

product

repairEvent

blogPost

---

## Constant

PascalCase

Örnek

DefaultPageSize

MaxUploadSize

---

# Klasör Yapısı

Her katman kendi sorumluluğunu taşımalıdır.

Controller

↓

Service

↓

Repository

↓

Database

Controller içerisinde iş mantığı yazılmaz.

---

# Controller Kuralları

Controller yalnızca isteği karşılar.

İş mantığı Service katmanında bulunur.

---

# Service Kuralları

Business Logic burada bulunacaktır.

Veritabanı erişimi doğrudan yapılmayacaktır.

---

# ViewModel

Her View kendi ViewModel'ini kullanacaktır.

Entity doğrudan View'a gönderilmeyecektir.

---

# Entity

Entity sınıfları yalnızca veri modelini temsil eder.

Business Logic içermez.

---

# Dependency Injection

Tüm servisler Dependency Injection kullanacaktır.

new anahtar kelimesi mümkün olduğunca kullanılmayacaktır.

---

# Yorum Satırları

Kod kendini açıklamalıdır.

Gereksiz yorum yazılmaz.

Karmaşık algoritmalarda açıklama yapılabilir.

---

# CSS / SCSS

BEM metodolojisi kullanılacaktır.

Örnek

.hero

.hero__title

.hero__button

.hero--dark

---

# HTML

Semantic HTML kullanılacaktır.

header

nav

main

section

article

footer

---

# JavaScript

Vanilla JavaScript tercih edilir.

Gerektiğinde modüler yapı kullanılır.

Global değişken oluşturulmaz.

---

# Responsive

Mobile First yaklaşımı uygulanacaktır.

---

# Accessibility

WCAG AA standartları hedeflenmektedir.

Her görsel alt metne sahip olmalıdır.

Klavye navigasyonu desteklenmelidir.

---

# Performans

Lazy Loading

Minification

Compression

Caching

Image Optimization

uygulanacaktır.

---

# Git

Her özellik ayrı feature branch üzerinde geliştirilecektir.

Doğrudan main branch'e commit atılmaz.

Pull Request zorunludur.

Squash Merge kullanılacaktır.

---

# Commit Mesajları

feat:

fix:

docs:

style:

refactor:

test:

chore:

Örnek

feat: add homepage hero section

docs: update design system

fix: resolve mobile navbar issue

---

# Kod Kalitesi

Kod okunabilir olmalıdır.

Kopyala-yapıştır koddan kaçınılmalıdır.

Tek sorumluluk prensibi uygulanmalıdır.

Her dosya yalnızca bir işi yapmalıdır.

---

# Hedef

Kod yalnızca çalışmak için değil;

yıllar sonra okunabilir ve geliştirilebilir olmak için yazılacaktır.