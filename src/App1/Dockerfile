FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/App1/App1.csproj", "src/App1/"]
RUN dotnet restore "src/App1/App1.csproj"
COPY . .
WORKDIR "/src/src/App1"
RUN dotnet build "App1.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS test

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "App1.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "App1.dll"]
