# Kırmızı Fil Git Workflow

## Amaç

Bu doküman, Kırmızı Fil projesinde kullanılacak Git ve GitHub çalışma düzenini tanımlar.

Amaç;

- Temiz commit geçmişi oluşturmak
- Kod kalitesini korumak
- Güvenli geliştirme yapmak
- Geri dönüşü kolaylaştırmak
- Ekip çalışmasını standartlaştırmaktır.

---

# Branch Stratejisi

Kalıcı Branch

main

Geçici Branchler

feature/*
fix/*
hotfix/*
docs/*
refactor/*

---

# Branch İsimlendirme

Yeni özellik

feature/homepage

feature/design-system

feature/blog

feature/repair

Hata düzeltme

fix/mobile-navbar

fix/footer-layout

Dokümantasyon

docs/update-readme

Refactor

refactor/service-layer

---

# Geliştirme Süreci

1.

main branch güncellenir.

```
git checkout main
git pull origin main
```

2.

Yeni feature branch oluşturulur.

```
git checkout -b feature/homepage
```

3.

Geliştirme yapılır.

4.

Commit oluşturulur.

5.

GitHub'a gönderilir.

```
git push -u origin feature/homepage
```

6.

Pull Request açılır.

7.

Kod gözden geçirilir.

8.

Squash & Merge yapılır.

9.

Feature branch silinir.

---

# Commit Kuralları

Her commit tek bir işi temsil etmelidir.

Küçük ve anlamlı commitler tercih edilir.

---

# Commit Türleri

feat:

Yeni özellik

fix:

Hata düzeltme

docs:

Dokümantasyon

style:

Kod biçimlendirme

refactor:

Kod iyileştirme

test:

Testler

chore:

Bakım işleri

---

# Commit Örnekleri

feat: create homepage hero section

feat: add repair cards

fix: resolve mobile navigation

docs: update roadmap

refactor: simplify service layer

style: improve button spacing

---

# Pull Request Kuralları

Her özellik Pull Request ile merge edilir.

Doğrudan main branch'e commit yapılmaz.

---

# Merge Stratejisi

Squash and Merge kullanılacaktır.

Merge Commit kullanılmayacaktır.

Rebase Merge kullanılmayacaktır.

---

# Branch Koruması

main branch korunacaktır.

- Pull Request zorunludur.
- Force Push kapalıdır.
- Branch silinemez.
- Linear History kullanılır.

---

# Kod İncelemesi

Merge öncesinde;

- Kod okunabilir olmalıdır.
- Coding Standards'a uygun olmalıdır.
- Design System'e uygun olmalıdır.
- Gereksiz kod bulunmamalıdır.

---

# Git Ignore

Derlenmiş dosyalar

Geçici dosyalar

IDE dosyaları

Kullanıcı ayarları

Repository'ye eklenmez.

---

# Pull Request Kontrol Listesi

- Kod çalışıyor mu?
- Responsive tasarım bozuldu mu?
- Console hatası var mı?
- Gereksiz kod var mı?
- Dokümantasyon güncellendi mi?

---

# Hedef

Repository geçmişi okunabilir, temiz ve sürdürülebilir olacaktır.

Her feature kendi branch'inde geliştirilecek ve güvenli şekilde main branch'e taşınacaktır.