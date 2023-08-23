FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/PaymentApplication.API/PaymentApplication.API.csproj", "PaymentApplication.API/"]
RUN dotnet restore "src/PaymentApplication.API/PaymentApplication.API.csproj"
COPY . .
WORKDIR "/src/PaymentApplication.API"
RUN dotnet build "PaymentApplication.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaymentApplication.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaymentApplication.API.dll"]
