FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base

WORKDIR /usr/src  

RUN touch /usr/src/pag_web

COPY [".","/usr/src/Index.cshtml.cs"]

EXPOSE 8888 
 
