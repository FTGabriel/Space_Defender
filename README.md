# README.md
 
# Space Defender
 
![CI Status](https://github.com/FTGabriel/Space_Defender/actions/workflows/ci.yml/badge.svg)
 
Mini-jeu de tir spatial en C# / Unity.
Developpé avec TDD et pipeline CI/CD automatisé.

Le projet est conçu avec **TDD (Test-Driven Development)** et un **pipeline CI/CD automatisé** via GitHub Actions.

---

## 📂 Structure du projet
space-defender/
├── Assets/
│ ├── Scripts/
│ │ └── Core/ # Classes testables
│ └── Tests/
│ └── EditMode/ # Tests NUnit
├── Packages/
├── ProjectSettings/
├── .github/
│ └── workflows/
│ └── ci.yml # Pipeline CI/CD
├── README.md

---

## ⚙️ Fonctionnalités

- Gestion du joueur et des ennemis (Health, Lives, Score)
- Système de calcul de score avec combo et multiplicateur
- Tests unitaires **NUnit** pour chaque fonctionnalité clé
- Pipeline CI/CD avec :
  - Build automatique
  - Tests unitaires
  - Upload des rapports de tests
  - Blocage des merges sur tests échoués

---

## 🧪 Tests

- Tous les tests NUnit sont dans `Assets/Tests/EditMode/`.
- La convention des tests suit `Méthode_Scenario_Resultat`.
- Couverture minimale de 80% sur les classes Core.
- Tests bonus :
  - Le joueur mort ne peut pas être soigné
  - Les ennemis déjà morts ne donnent pas de points
  - Calcul de score avec 0 kills ou 0 secondes

---

## 🚀 CI/CD

- Chaque push ou Pull Request déclenche automatiquement le pipeline GitHub Actions.
- La branche `main` est protégée : merge interdit si des tests échouent.
- Build WebGL générée automatiquement si tous les tests passent.

---

## 🔧 Installation

1. Clonez le dépôt :

```bash
git clone https://github.com/FTGabriel/Space_Defender.git
```

2. Ouvrez le projet dans Unity version 6000.1.17f1.

3. Assurez-vous que les packages nécessaires sont installés via le Package Manager.

4. Les tests NUnit sont exécutables depuis EditMode et vérifiables avec Test Runner.

## 📄 Licence

Projet éducatif — Utilisation libre dans le cadre du cours.

---
