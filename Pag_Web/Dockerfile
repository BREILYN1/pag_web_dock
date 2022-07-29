FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base

WORKDIR /app   

RUN apt update

COPY [".","/usr/src/"]

EXPOSE 8888

