# CrazyMusicians_Api

## 📌 Project Overview
CrazyMusicians_Api is an ASP.NET Core 8.0 Web API designed to manage a list of funny and crazy musicians. This API supports CRUD (Create, Read, Update, Delete) operations, search functionality, and follows a structured routing system similar to the Galactic Tour application.

## 🚀 Features
- **CRUD Operations**: Create, Read, Update, Delete musicians
- **RESTful Routing**: Improved readability and usability
- **[FromQuery] Usage**: Search musicians by name
- **Validation Checks**: Ensuring proper data entry
- **In-Memory Storage**: No database required for testing

---

## 📂 Folder Structure
```
CrazyMusicians_Api/
│── Controllers/
│   ├── MusiciansController.cs
│
│── Models/
│   ├── Musician.cs
│
│── Program.cs
│── README.md
```

---

## 📌 API Endpoints

### ✅ Get All Musicians
**GET** `/api/musicians`

### ✅ Get Musician by ID
**GET** `/api/musicians/{id}`

### ✅ Search Musicians by Name
**GET** `/api/musicians/find/{name}`

### ✅ Add a New Musician
**POST** `/api/musicians/add`
#### Request Body:
```json
{
    "name": "New Artist",
    "profession": "Guitarist",
    "funnyFeature": "Can play chords backward"
}
```

### ✅ Update Musician
**PUT** `/api/musicians/update/{id}`
#### Request Body:
```json
{
    "name": "Updated Name",
    "profession": "Drummer",
    "funnyFeature": "Hits drums unpredictably"
}
```

### ✅ Update Only the Funny Feature
**PATCH** `/api/musicians/update-feature/{id}`
#### Request Body:
```json
"Now makes music with kitchen utensils"
```

### ✅ Delete Musician
**DELETE** `/api/musicians/remove/{id}`

---

## 🛠 Setup & Run Instructions
### 1️⃣ Clone Repository
```sh
git clone https://github.com/your-repo/crazymusicians_api.git
cd crazymusicians_api
```

### 2️⃣ Open in Visual Studio
- Open `CrazyMusicians_Api.sln`

### 3️⃣ Run the Project
- Press `Ctrl + F5` or click **Run**
- Swagger UI will open at `http://localhost:5000/swagger`

### 4️⃣ Test API with Postman or Swagger

---

## 📝 Notes
- This API uses **in-memory storage**, so data is lost when restarted.
- For production, consider using a **database like SQL Server**.

Enjoy the Crazy Musicians API! 🎸🥁🎶

