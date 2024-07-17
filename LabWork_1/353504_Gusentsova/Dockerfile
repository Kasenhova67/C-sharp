FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["353504_Gusentsova/353504_Gusentsova.csproj", "353504_Gusentsova/"]
RUN dotnet restore "353504_Gusentsova/353504_Gusentsova.csproj"
COPY . .
WORKDIR "/src/353504_Gusentsova"
RUN dotnet build "353504_Gusentsova.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "353504_Gusentsova.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "353504_Gusentsova.dll"]
