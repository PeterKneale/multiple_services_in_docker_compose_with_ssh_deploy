### Setup certs 
The nginx will perform SSL termination for `app1.com` and `app2.com`

```shell
openssl req -x509 -nodes -days 365 -newkey rsa:2048 -config app1.conf -keyout app1.key -out app1.crt
openssl req -x509 -nodes -days 365 -newkey rsa:2048 -config app2.conf -keyout app2.key -out app2.crt
openssl pkcs12 -export -out app1.pfx -inkey app1.key -in app1.crt
openssl pkcs12 -export -out app2.pfx -inkey app2.key -in app2.crt
```

### Setup hosts file
Add the domains to the hosts file for local resolution

```text
C:\Windows\System32\drivers\etc
127.0.0.1 app1.com
127.0.0.1 app2.com
```

### Build
```shell
docker compose \
 -f docker-compose.yml \
 -f docker-compose-app1.yml \
 -f docker-compose-app2.yml \
 build
```

### Up
```shell
docker compose \
 -f docker-compose.yml \
 -f docker-compose-app1.yml \
 -f docker-compose-app2.yml \
 up
```

### Down

```shell
docker compose \
 -f docker-compose.yml \
 -f docker-compose-app1.yml \
 -f docker-compose-app2.yml \
 down
```