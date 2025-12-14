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
git clone https://github.com/abaksheiev/setup-web-api-and-hangfire.git cd setup-web-api-and-hangfire

2. **Restore dependencies:**
dotnet restore

3. **Build the solution:**
dotnet build

4. **Run the Web API:**

5. **Access the API and Hangfire Dashboard:**
- API endpoints: `https://localhost:7775` (or as configured in `launchSettings.json`)
- Hangfire Dashboard: `https://localhost:7775/hangfire`

### Project Structure
App.Web/                # Main ASP.NET Core Web API project Properties/ launchSettings.json # Launch profiles for local development ... README.md               # This file
### Configuration

- **launchSettings.json**: Contains profiles for running the API locally (IIS Express, Kestrel, etc.).
- **Hangfire**: Configured in `Startup.cs` or `Program.cs` (see code for details).