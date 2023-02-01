FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NinthAgeLeague.Api/NinthAgeLeague.Api.csproj", "NinthAgeLeague.Api/"]
RUN dotnet restore "NinthAgeLeague.Api/NinthAgeLeague.Api.csproj"
COPY . .
WORKDIR "/src/NinthAgeLeague.Api"
RUN dotnet build "NinthAgeLeague.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NinthAgeLeague.Api.csproj" -c Release -o /app/publish

FROM base AS final

COPY setup-tex-live.sh .
RUN chmod +x ./setup-tex-live.sh
RUN ./setup-tex-live.sh

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NinthAgeLeague.Api.dll"]
