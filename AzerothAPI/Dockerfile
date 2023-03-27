#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AzerothAPI/AzerothAPI.csproj", "AzerothAPI/"]
RUN dotnet restore "AzerothAPI/AzerothAPI.csproj"
COPY . .
WORKDIR "/src/AzerothAPI"
RUN dotnet build "AzerothAPI.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "AzerothAPI.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AzerothAPI.dll"]