FROM node:14

COPY . ./

WORKDIR /usr/src/

RUN npm install

COPY [".", "/usr/src/"]

EXPOSE 8080

CMD ["node", "."]