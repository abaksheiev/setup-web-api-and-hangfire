# Setup Web API and Hangfire (.NET 8)

This solution demonstrates how to set up a modern ASP.NET Core Web API project with integrated [Hangfire](https://www.hangfire.io/) for background job processing, targeting .NET 8.

## Features

- **ASP.NET Core Web API**: RESTful API endpoints built with .NET 8.
- **Hangfire Integration**: Background job scheduling and processing.
- **Modern Project Structure**: SDK-style project, easy to maintain and extend.
- **Ready for Docker and Cloud**: Configurable for containerization and cloud deployment.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later

### Running the Application

1. **Clone the repository:**

```git clone https://github.com/abaksheiev/setup-web-api-and-hangfire.git```

```cd setup-web-api-and-hangfire```

3. **Restore dependencies:**
```dotnet restore```

4. **Build the solution:**
```dotnet build```

5. **Run the Web API:**
```dotnet run --project App.Web```

6. **Access the API and Hangfire Dashboard:**
- API endpoints: `https://localhost:7775` (or as configured in `launchSettings.json`)
- Hangfire Dashboard: `https://localhost:7775/hangfire`
