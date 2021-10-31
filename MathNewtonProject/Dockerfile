FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MathNewtonProject/MathNewtonProject.csproj", "MathNewtonProject/"]
RUN dotnet restore "MathNewtonProject/MathNewtonProject.csproj"
COPY . .
WORKDIR "/src/MathNewtonProject"
RUN dotnet build "MathNewtonProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MathNewtonProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MathNewtonProject.dll"]
