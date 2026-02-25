# Use .NET SDK to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DatabaseFirst.csproj", "."]
RUN dotnet restore "./DatabaseFirst.csproj"
COPY . .
RUN dotnet publish "./DatabaseFirst.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Use .NET Runtime for final image
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DatabaseFirst.dll"]