# 💼 Financial CRM - Desktop Finance Management System

Financial CRM is a desktop-based finance management application developed with **C# Windows Forms**, **.NET Framework**, **Entity Framework**, and **Microsoft SQL Server**.

The project was built to practice real-world desktop application development, database-driven systems, clean UI design, and CRUD-based financial data management.

---

## 🎯 Project Overview

Financial CRM allows users to manage their personal finance data through a simple, modern, and organized desktop interface.

The application includes modules for bank accounts, bank transactions, spending records, billing/payment management, dashboard analytics, and user login flow.

The main goal of this project is to demonstrate practical skills in:

- Desktop application development
- Database design and SQL operations
- Entity Framework integration
- CRUD operations
- Dashboard and chart visualization
- Modern dark-themed UI design
- Multi-form Windows Forms application structure

---

## 🖼️ Screenshots

### 🔐 Login Screen

<img width="862" height="1022" alt="Screenshot 2026-04-26 003506" src="https://github.com/user-attachments/assets/5d608354-e075-412a-b83a-a971e0dfd651" />


### 📊 Dashboard

<img width="1099" height="691" alt="Screenshot 2026-04-26 003519" src="https://github.com/user-attachments/assets/6fbad7cb-000f-438a-beb2-1195835878cb" />


### 🧭 CopyRight

<img width="1002" height="752" alt="Screenshot 2026-04-26 003523" src="https://github.com/user-attachments/assets/dfed7737-a804-4a74-8202-4fc8306edffc" />

---

## ⚙️ Technologies Used

- **C#**
- **.NET Framework 4.7.2**
- **Windows Forms**
- **Entity Framework**
- **Microsoft SQL Server**
- **LINQ**
- **ADO.NET / Entity Data Model**
- **Windows Forms Chart Controls**
- **Visual Studio 2022**

---

## 🧩 Core Features

### 🔐 User Authentication

The application includes a login screen with a modern interface.  
The login structure was designed as the entry point of the application and provides a controlled flow before accessing the main system.

### 📊 Dashboard Analytics

The dashboard provides a quick overview of financial data using cards and charts.

Dashboard includes:

- Total balance overview
- Latest bill information
- Latest bank transaction amount
- Bank balance chart
- Bill chart
- Monthly finance flow chart
- Spending distribution chart

### 🏦 Bank Management

Users can manage bank account records through CRUD operations.

Supported operations:

- Add bank account
- Update bank account
- Delete bank account
- List bank accounts
- View bank balance data inside dashboard charts

### 🔄 Bank Transaction Management

The system includes a bank transaction module for tracking money movement.

This module helps organize:

- Incoming transactions
- Outgoing transactions
- Transaction amount
- Transaction date
- Bank-related financial movements

### 💳 Spending Management

Users can record and manage spending data.

Spending module includes:

- Spending title
- Spending amount
- Category selection
- Spending date
- Category-based filtering
- Daily spending listing

### 🧾 Billing / Payment Management

The billing module allows users to manage bills and payment records.

It includes:

- Bill title
- Bill amount
- Bill period
- Add / update / delete bill records
- Bill data visualization on dashboard

### 🗂️ Category Management

Categories are used to organize spending records and improve financial tracking.

Users can:

- Add categories
- Update categories
- Delete categories
- List all categories

---

## 🏗️ Project Architecture

This project follows a structured Windows Forms architecture.

The application is organized into multiple forms, each responsible for a specific module:

- `FrmLogin`
- `FrmMainMenu`
- `FrmDashboard`
- `FrmBanks`
- `FrmBankProcesses`
- `FrmCategories`
- `FrmSpendings`
- `FrmBilling`
- `FrmAbout`

The database communication is handled with **Entity Framework**, using model-based data access through the `FinancialCrmDbEntities` context.

---

## 🗄️ Database

The project uses **Microsoft SQL Server** as the database management system.

Entity Framework is used to connect the application with the database and perform CRUD operations.

Main database entities include:

- Banks
- BankProcesses
- Categories
- Spendings
- Bills
- Users

---

## 📈 Data Visualization

The dashboard uses **Windows Forms DataVisualization Chart Controls**.

Chart types used in the project include:

- Column Chart
- Pie Chart
- Spline Area Chart
- Doughnut Chart

These charts help users understand financial data visually and quickly.

---

## 🎨 UI / UX Design

The application was redesigned with a modern dark purple theme.

UI design goals:

- Clean layout
- Readable typography
- Modern dashboard feel
- Consistent color palette
- Better form spacing
- User-friendly navigation
- Professional portfolio-ready appearance

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/rdmrcn/BANK-FINANCE-MANAGEMENT-with-MVC-Proj.git
