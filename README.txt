# ControleFinanceiroDesktop

**ControleFinanceiroDesktop** is a personal finance management application developed with Windows Forms and .NET Core 8, following the MVC pattern. The name is in Portuguese, but it roughly translates to "**Desktop Financial Control**".

## 🧾 Description

This desktop app allows users to manage financial statements, supporting multiple tabs (such as different bank accounts or credit cards). It also provides a summary report screen with filtering by date range.

The application supports both manual and spreadsheet-based statement entries, with automatic category identification based on pre-configured keywords.

## ✅ Features

- **Statement Management**
  - Add financial entries manually or import via spreadsheet
  - Filter statements by start and end date
  - Automatically categorize entries using keyword matching

- **Category Management**
  - Create, edit, and delete categories (e.g., Water, Electricity, Internet)
  - Assign keywords to categories (e.g., "Outback", "Applebees" → *Restaurants*)

- **Statement Type Management**
  - Manage types of statements (e.g., Checking Account, Credit Card)
  - Full CRUD with dependency validation (prevents deletion when in use)

- **Reports**
  - View financial summary grouped by category, date range, etc.
  - Identify uncategorized transactions for manual correction

## 🛠️ Tech Stack

- **Platform:** Windows Forms
- **Framework:** .NET Core 8
- **Database:** Firebird 3.0
- **ORM:** Entity Framework Core
- **Architecture:** MVC

## 📁 Project Structure (Key Folders)

Controllers/ → Handles UI event logic and user actions
Data/ → Database context and Firebird connection
Models/ → Domain models, DTOs, ViewModels
Services/ → Business logic, grouped by context (e.g., Category, Statement)
Views/ → Forms (UI), Helpers for rendering
Responses/ → Structured API responses (used internally)


## 🚀 How to Run Locally

1. **Install Firebird 3.0** on your machine (required to access the database).
2. **Clone this repository** and open it in Visual Studio.
3. Locate the database file (included in the repository) and place it in a preferred local folder.
4. Update the connection string in Program.cs to point to the correct .fdb file path.
5. Build and run the project.

> 🔥 The application uses a `.fdb` Firebird database file and assumes the Firebird service is running.

---

## 📄 License

This project is open source under the [MIT License](LICENSE).

