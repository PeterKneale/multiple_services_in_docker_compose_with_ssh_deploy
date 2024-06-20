FROM nginx:latest
COPY conf/nginx.conf /etc/nginx/nginx.conf
COPY *.key /etc/nginx/
COPY *.crt /etc/nginx/
COPY ./index.html /usr/share/nginx/html/index.html