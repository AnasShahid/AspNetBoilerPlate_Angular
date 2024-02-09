FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/AspNetBoilerplate_Angular.Web.Host/AspNetBoilerplate_Angular.Web.Host.csproj", "src/AspNetBoilerplate_Angular.Web.Host/"]
COPY ["src/AspNetBoilerplate_Angular.Web.Core/AspNetBoilerplate_Angular.Web.Core.csproj", "src/AspNetBoilerplate_Angular.Web.Core/"]
COPY ["src/AspNetBoilerplate_Angular.Application/AspNetBoilerplate_Angular.Application.csproj", "src/AspNetBoilerplate_Angular.Application/"]
COPY ["src/AspNetBoilerplate_Angular.Core/AspNetBoilerplate_Angular.Core.csproj", "src/AspNetBoilerplate_Angular.Core/"]
COPY ["src/AspNetBoilerplate_Angular.EntityFrameworkCore/AspNetBoilerplate_Angular.EntityFrameworkCore.csproj", "src/AspNetBoilerplate_Angular.EntityFrameworkCore/"]
WORKDIR "/src/src/AspNetBoilerplate_Angular.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/AspNetBoilerplate_Angular.Web.Host", "src/AspNetBoilerplate_Angular.Web.Host"]
COPY ["src/AspNetBoilerplate_Angular.Web.Core", "src/AspNetBoilerplate_Angular.Web.Core"]
COPY ["src/AspNetBoilerplate_Angular.Application", "src/AspNetBoilerplate_Angular.Application"]
COPY ["src/AspNetBoilerplate_Angular.Core", "src/AspNetBoilerplate_Angular.Core"]
COPY ["src/AspNetBoilerplate_Angular.EntityFrameworkCore", "src/AspNetBoilerplate_Angular.EntityFrameworkCore"]
WORKDIR "/src/src/AspNetBoilerplate_Angular.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "AspNetBoilerplate_Angular.Web.Host.dll"]
