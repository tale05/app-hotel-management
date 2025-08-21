# 🏨 Homestay Management Software

## 📖 Overview

The **Homestay Management Software** is a comprehensive solution designed to streamline the management of homestay and hotel operations. Developed using **C#** with **WinForms** for the desktop application and integrated with a **SQL Server** database, the system provides an efficient, secure, and user-friendly platform for both administrators and staff to manage homestay operations.

## ✨ Key Features

- 👥 **Customer Management**  
  Store and manage customer information including personal details, booking history, and special requests.

- 🛏️ **Room Management**  
  Handle room categories, prices, availability status (available, booked, occupied), and amenities.

- 📅 **Booking Management**  
  Support both online and offline reservations, including check-in/check-out processes and flexible deposit policies.

- 🛎️ **Service Management**  
  Manage additional services such as dining, laundry, transportation, spa, fitness, and entertainment options.

- 🧾 **Invoice & Billing**  
  Generate invoices for room bookings, services, and equipment usage with support for detailed tracking and payment history.

- ⚙️ **Equipment Management**  
  Track homestay equipment usage, availability, and maintenance.

- 📊 **Reports & Statistics**  
  Generate business insights, including revenue reports, occupancy rates, and customer statistics to support decision-making.

- 🔒 **Security & Authentication**  
  User account management with role-based access control and password protection mechanisms.

- 🎨 **Friendly UI**  
  Designed with **Guna Framework** for a modern, intuitive interface, making the system accessible to non-technical staff.

## 🏗️ System Architecture

The project follows a **Three-Layer Architecture**:

1. 🎭 **Presentation Layer** – User interface designed with C# WinForms and Guna UI.
2. 🧠 **Business Logic Layer** – Handles booking, billing, and service management processes.
3. 🗄️ **Data Layer** – SQL Server database connected via ADO.NET and LINQ for efficient data operations.

## 🛠️ Technologies Used

- 💻 **Programming Language**: C# (.NET Framework / .NET Core)
- 🗄️ **Database**: Microsoft SQL Server
- 🎨 **UI Framework**: Guna UI for WinForms
- 📦 **Additional Libraries**:
  - 📑 Microsoft.Office.Interop.Word.dll – for exporting reports
  - 🔐 mscorlib.dll – for security and account management

## 🚀 Installation & Setup

1. Install **Microsoft Visual Studio 2019/2022**.
2. Install **Microsoft SQL Server 2012 or later**.
3. Clone or download the project source code.
4. Import the provided SQL script to set up the database.
5. Open the solution in Visual Studio, configure the connection string, and build the project.
6. Run the application to start using the system.

## 🔮 Future Improvements

- 🤖 Enhance the web-based booking system with AI-powered room recommendations.
- 🎨 Improve user interface with more modern design patterns (e.g., WPF or Blazor).
- 📱 Integrate with mobile applications for customers and staff.
- ⚡ Optimize performance for large-scale homestay or hotel operations.

## 📜 License

This project was developed for educational purposes and is not intended for commercial use.
