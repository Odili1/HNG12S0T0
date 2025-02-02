# HNG12 API Task - C# (ASP.NET Core)

This is a simple ASP.NET Core Web API that returns JSON data containing my registered email, the current UTC time in ISO 8601 format, and the GitHub URL of the project repository.

## 📌 API Features

- Returns a JSON response with:
  - Your **email** (registered on HNG12 Slack)
  - The **current datetime** in ISO 8601 format (UTC)
  - The **GitHub repository URL**
- Supports **CORS** (Cross-Origin Resource Sharing)
- Uses **ASP.NET Core Web API**
- **Publicly deployed** for access

---

## 📥 Installation & Running Locally

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)
- A code editor like **VS Code** or **Rider**

### Steps

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/hng12-s0-t1.git
   cd hng12-s0-t1
   ```
2. Restore Dependencies: `dotnet restore`

3. Run Locally: `dotnet run`

### API Documentation

GET /info

Returns:

```json
{
  "email": string,
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/Odili1/HNG12S0T0"
}
```

## Deployment

Live URL:

GitHub Repo: https://github.com/Odili1/hngHNG12S0T0

## Useful Links

- [Hire C# Developers](https://hng.tech/hire/csharp-developers)

- [ASP.NET Core Docs](https://learn.microsoft.com/en-us/aspnet/core/)
