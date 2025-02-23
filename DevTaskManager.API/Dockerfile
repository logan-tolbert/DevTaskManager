# Use the official .NET 9 runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app

# Expose port 8080 (matches the application settings)
EXPOSE 8080

# Use the official .NET 9 SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy the API project files
COPY ["DevTaskManager.API.csproj", "./"]
RUN dotnet restore "./DevTaskManager.API.csproj"

# Copy everything and build the application
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Final stage: Use the base image to run the application
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# Set the entrypoint to run the API
ENTRYPOINT ["dotnet", "DevTaskManager.API.dll"]
