# Use a imagem base do ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

# Defina o diret�rio de trabalho dentro do cont�iner
WORKDIR /app

# Exponha a porta da Api
EXPOSE 80

# Use a imagem de build para compilar a aplica��o
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

# Defina o diret�rio de trabalho
WORKDIR /src

# Copie o arquivo .csproj da Api e restaure as depend�ncias
COPY Ecommerce.Api/Ecommerce.Api.csproj ./Ecommerce.Api/
COPY Ecommerce.Application/Ecommerce.Application.csproj ./Ecommerce.Application/
COPY Ecommerce.Communication/Ecommerce.Communication.csproj ./Ecommerce.Communication/
COPY Ecommerce.Domain/Ecommerce.Domain.csproj ./Ecommerce.Domain/
COPY Ecommerce.Exception/Ecommerce.Exception.csproj ./Ecommerce.Exception/
COPY Ecommerce.Infrastructure/Ecommerce.Infrastructure.csproj ./Ecommerce.Infrastructure/
RUN dotnet restore Ecommerce.Api/Ecommerce.Api.csproj

# Copie o restante do c�digo da Api
COPY Ecommerce.Api/ . /src/Ecommerce.Api/

# Defina o diret�rio de trabalho para a build
WORKDIR /src/Ecommerce.Api

# Compile a aplica��o
RUN dotnet build Ecommerce.Api.csproj -c Release -o /app/build

# Publique a aplica��o
FROM base AS final
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT ["dotnet", "Ecommerce.Api.dll"]