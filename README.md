🏨 HotelFinder API
HotelFinder.API is a RESTful Web API built with .NET Core that allows you to manage hotel data such as listing, adding, updating, and deleting hotels.

📌 Technologies Used

.NET 9 / .NET Core
ASP.NET Core Web API
Entity Framework Core
SQL Server
Dependency Injection (DI)
Repository-Service Pattern

⚙️ Getting Started
1. Clone the repository:
git clone https://github.com/yourusername/HotelFinder.API.git
cd HotelFinder.API

2. Restore NuGet packages:
dotnet restore

3. Apply migrations and create the database:
dotnet ef migrations add InitialCreate
dotnet ef database update

4. Run the project:
dotnet run --project HotelFinder.API

📁 Project Structure
HotelFinder.API/
│

├── Controllers/
│   └── HotelsController.cs
│

├── Business/
│   ├── Abstract/
│   │   └── IHotelService.cs
│   └── Concrete/
│       └── HotelManager.cs
│

├── DataAccess/
│   ├── Abstract/
│   │   └── IHotelRepository.cs
│   └── Concrete/
│       └── HotelRepository.cs
│

├── Entities/
│   └── Hotel.cs
│

├── appsettings.json
├── Program.cs
└── HotelDbContext.cs

📮 API Endpoints
| Method | Endpoint           | Description              |
| ------ | ------------------ | ------------------------ |
| GET    | `/api/hotels`      | Get all hotels           |
| GET    | `/api/hotels/{id}` | Get a specific hotel     |
| POST   | `/api/hotels`      | Add a new hotel          |
| PUT    | `/api/hotels/{id}` | Update an existing hotel |
| DELETE | `/api/hotels/{id}` | Delete a hotel           |


📌 Sample JSON Request
{
  "name": "Grand Palace Hotel",
  "address": "123 City Center",
  "city": "Istanbul",
  "state": "Marmara",
  "zipCode": "34000",
  "country": "Turkey",
  "rating": 4.5,
  "numberOfRooms": 120,
  "isAvailable": true
}

🤝 Contributing
Contributions are welcome! Feel free to fork the repo, create a branch, and open a pull request.

📄 License
This project is licensed under the MIT License.

