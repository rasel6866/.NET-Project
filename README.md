# Blood Bank Management System

A web-based **Blood Bank Management System** built with **ASP.NET Core MVC, C#, Entity Framework Core, SQL Server, and N-Tier Architecture**.

## Features
### User

* User Registration
* User Login
* User Authentication
* User Dashboard
* View Profile
* Edit Profile
* Delete Profile
* Logout

### Donor

* Add Donor
* View Donor List
* Edit Donor Information
* Delete Donor
* Search Donor
* Filter Donor by Blood Group
* Manage Donor Information
* Track Last Donation Date

### Blood Request

* Create Blood Request
* View Blood Request List
* Edit Blood Request
* Delete Blood Request
* Search Blood Request
* Filter Requests by Blood Group
* Manage Patient Information
* Manage Hospital Information

### Blood Management

* View Available Blood Groups
* Search Available Blood
* Track Blood Availability
* Manage Blood Stock
* Monitor Blood Donations
* Manage Blood Requests

## Architecture

The project follows **N-Tier Architecture**:

```text
APP
 ├── Controllers
 └── Views

BLL
 ├── DTOs
 ├── Services
 ├── Validations
 └── MapperConfig

DAL
 ├── EF
 │   ├── DbContext
 │   └── Tables
 └── Repos
```

### Application Flow

```text
View
  ↓
Controller
  ↓
Service (BLL)
  ↓
Repository (DAL)
  ↓
Entity Framework Core
  ↓
SQL Server
```

## Database Relationships

```text
User       1 ──────── * BloodRequest
Donor      1 ──────── * Donation
BloodGroup 1 ──────── * Donor
BloodGroup 1 ──────── * BloodRequest
```

## Technologies Used

* C#
* ASP.NET Core MVC
* .NET
* Entity Framework Core
* SQL Server
* AutoMapper
* Bootstrap
* Razor Views
* HTML
* CSS
* JavaScript
* Git & GitHub

## Design Patterns & Concepts

* N-Tier Architecture
* Repository Pattern
* Service Layer
* DTO Pattern
* AutoMapper
* CRUD Operations
* Entity Framework Core
* Database Relationships
* Form Validation
* Business Logic Validation
* Search & Filtering
* Dependency Injection

## Main Routes

### User

```text
/Auth/Registration
/Auth/Login
/Auth/Dashboard
/Auth/Profile
/Auth/EditProfile
/Auth/DeleteProfile
/Auth/Logout
```

### Donor

```text
/Donor/Index
/Donor/Create
/Donor/Edit/{id}
/Donor/Delete/{id}
/Donor/Search
```

### Blood Request

```text
/BloodRequest/Index
/BloodRequest/Create
/BloodRequest/Edit/{id}
/BloodRequest/Delete/{id}
/BloodRequest/Search
```

### Blood Management

```text
/Blood/Index
/Blood/Search
/Blood/Availability
```

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/rasel6866/Blood-Bank-Management-System.git
```

2. Open the project in **Visual Studio**.

3. Configure the SQL Server connection string in:

```text
appsettings.json
```

4. Restore NuGet packages:

```bash
dotnet restore
```

5. Apply the database migration:

```bash
dotnet ef database update
```

6. Build the project:

```bash
dotnet build
```

7. Run the application:

```bash
dotnet run
```

## Git Branches

This project uses two branches:

```text
main
development
```

* **development** → Development and testing
* **main** → Stable version

### Workflow

```text
development
     ↓
Development & Testing
     ↓
Pull Request
     ↓
main
```

## Purpose

This project was developed as an **academic and learning project** to practice **ASP.NET Core MVC, N-Tier Architecture, Entity Framework Core, SQL Server, CRUD operations, authentication, DTOs, Repository Pattern, Service Layer, database relationships, validation, and search/filtering functionality**.

The main purpose of the system is to provide an organized platform for managing **blood donors, blood requests, blood groups, blood availability, and user information** efficiently.

## Author

**SM Rasel**

GitHub: https://github.com/rasel6866

## Future Improvements

* Email/SMS notification for blood requests
* Blood donation reminder
* Advanced blood availability reports
* Admin dashboard with analytics
* Blood request status tracking
* Donor recommendation based on blood group and location
* Unit and integration testing
