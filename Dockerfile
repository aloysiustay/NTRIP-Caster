# ========== BUILD STAGE ==========
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution file first
COPY Caster.sln ./

# Copy only the projects we need (for dependency restore)
COPY CasterServer/CasterServer.csproj CasterServer/
COPY RtcmSharp/RtcmSharp.csproj RtcmSharp/
COPY RtkMathLib/RtkMathLib.csproj RtkMathLib/

# Restore dependencies for CasterServer (pulls libraries automatically)
RUN dotnet restore "CasterServer/CasterServer.csproj"

# Copy the rest of the source code
COPY . .

# Build and publish the caster server only
RUN dotnet publish "CasterServer/CasterServer.csproj" -c Release -o /app/publish

# ========== RUNTIME STAGE ==========
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Render sets $PORT automatically
ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}

# Optional (document default port)
EXPOSE 8080

ENTRYPOINT ["dotnet", "CasterServer.dll"]
