#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TMakesCode.Amplifund.Api/TMakesCode.Amplifund.Api.csproj", "TMakesCode.Amplifund.Api/"]
RUN dotnet restore "TMakesCode.Amplifund.Api/TMakesCode.Amplifund.Api.csproj"
COPY . .
WORKDIR "/src/TMakesCode.Amplifund.Api"
RUN dotnet build "TMakesCode.Amplifund.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TMakesCode.Amplifund.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TMakesCode.Amplifund.Api.dll"]