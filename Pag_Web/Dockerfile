FROM asp.net:

WORKDIR /app   

RUN apt update

COPY [".","/usr/src/"]

EXPOSE 8888

CMD ["ubuntu", "Index.cshtml" ]