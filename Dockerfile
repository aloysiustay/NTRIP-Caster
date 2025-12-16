FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Caster.sln ./

COPY CasterServer/CasterServer.csproj CasterServer/
COPY RtcmSharp/RtcmSharp.csproj RtcmSharp/
COPY RtkMathLib/RtkMathLib.csproj RtkMathLib/

RUN dotnet restore "CasterServer/CasterServer.csproj"

COPY . .

RUN dotnet publish "CasterServer/CasterServer.csproj" -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

RUN apt-get update && \
    apt-get install -y net-tools iproute2 iputils-ping curl traceroute && \
    apt-get clean

WORKDIR /app
COPY --from=build /app/publish .

# Expose your ports
EXPOSE 2101/tcp
EXPOSE 18080/tcp

ENTRYPOINT ["dotnet", "CasterServer.dll"]