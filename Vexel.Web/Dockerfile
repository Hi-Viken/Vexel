#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Vexel.Web/Vexel.Web.csproj", "Vexel.Web/"]
COPY ["Vexel.Code/Vexel.Code.csproj", "Vexel.Code/"]
COPY ["Vexel.Service/Vexel.Service.csproj", "Vexel.Service/"]
COPY ["Vexel.CodeGenerator/Vexel.CodeGenerator.csproj", "Vexel.CodeGenerator/"]
COPY ["Vexel.Data/Vexel.DataBase.csproj", "Vexel.Data/"]
COPY ["Vexel.Domain/Vexel.Domain.csproj", "Vexel.Domain/"]
RUN dotnet restore "Vexel.Web/Vexel.Web.csproj"
COPY . .
WORKDIR "/src/Vexel.Web"
RUN dotnet build "Vexel.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vexel.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vexel.Web.dll"]