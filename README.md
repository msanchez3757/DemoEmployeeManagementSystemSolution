🚀 Features
Core Functionality

User Authentication & Authorization

Secure login system with role-based access (Admin vs User).

JWT-based authentication for secure API access.

Employee Management

Create, read, update, and delete employee information.

Store and display employee details such as name, role, status, and employment data.

State Tracking

Track overtime hours, vacation requests, sanctions/disciplinary records, and other employee metrics.

Admin dashboard to review and manage state changes.

Frontend Interface

Responsive UI for both employees and administrators.

Clear navigation to view employee lists, individual details, and state metrics.

🧱 Technology Stack
Layer	Technology
Backend API	C#, ASP.NET Core Web API
Authentication	JWT tokens
ORM / Database Access	Entity Framework Core (SQL Server / SQLite)
Frontend	React / Blazor / HTML/CSS/JS (Update based on your actual UI)
Development Tools	Visual Studio / VS Code
📁 Project Structure
/DemoEmployeeManagementSystemSolution
├── Server/                # ASP.NET Core backend API
├── Client/                # Frontend app (React/Blazor/etc.)
├── BaseLibrary/           # Shared DTOs and core models
├── ClientLibrary/         # Shared client logic
├── ServerLibrary/         # Shared server logic
├── .gitignore
├── README.md

📦 Getting Started
Prerequisites

Make sure you have the following installed:

.NET SDK 8+

SQL Server (or SQLite) instance

Node.js & npm (if using React frontend)

IDE: Visual Studio / VS Code

🛠 Installation
1. Clone the Repo
git clone https://github.com/msanchez3757/DemoEmployeeManagementSystemSolution.git
cd DemoEmployeeManagementSystemSolution

2. Setup Backend

From the Server/ folder:

dotnet restore
dotnet ef database update     # Apply EF Core migrations
dotnet run


The backend will start and expose API endpoints (e.g., https://localhost:5001/api/...).

3. Setup Frontend (if separate)

From the Client/ folder:

npm install
npm start


The frontend will launch locally (e.g., http://localhost:3000). Configure it to call your backend API.

🧪 Usage
Authentication

Register or log in with a user account.

Admins have access to employee state management features.

Users can view their own data (vacation, overtime, etc.).

Employee State Management

Admin UI: Add new employees, approve vacation or sanction requests, and modify overtime.

User UI: Submit vacation requests, log hours, and view personal details.

📌 TODO / Future Improvements
THIS PROJECT IS NOT FINISHED
