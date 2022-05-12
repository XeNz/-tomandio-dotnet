FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TomAndIO.Web/TomAndIO.Web.csproj", "TomAndIO.Web/"]
RUN dotnet restore "TomAndIO.Web/TomAndIO.Web.csproj"
COPY . .
WORKDIR "/src/TomAndIO.Web"
RUN dotnet build "TomAndIO.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TomAndIO.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TomAndIO.Web.dll"]
