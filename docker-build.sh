#!/bin/bash
set -e

echo "Building..."
docker compose --progress quiet -f docker-compose.yml build

apps=("app1" "app2")
for app in "${apps[@]}"
do
  echo "Building $app..."
  docker compose --progress quiet -f docker-compose-${app}.yml build
done