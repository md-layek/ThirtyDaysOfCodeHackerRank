FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Bitwise AND/Bitwise AND.csproj", "Bitwise AND/"]
RUN dotnet restore "Bitwise AND/Bitwise AND.csproj"
COPY . .
WORKDIR "/src/Bitwise AND"
RUN dotnet build "Bitwise AND.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bitwise AND.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bitwise AND.dll"]
