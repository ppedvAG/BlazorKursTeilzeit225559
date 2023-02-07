#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlazorKursTeilzeit225559/BlazorKursTeilzeit225559.csproj", "BlazorKursTeilzeit225559/"]
RUN dotnet restore "BlazorKursTeilzeit225559/BlazorKursTeilzeit225559.csproj"
COPY . .
WORKDIR "/src/BlazorKursTeilzeit225559"
RUN dotnet build "BlazorKursTeilzeit225559.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorKursTeilzeit225559.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorKursTeilzeit225559.dll"]