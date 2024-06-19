#!/bin/bash
set -e

apps=("app1" "app2")
for app in "${apps[@]}"
do
  echo "Unit Testing $app..."
  docker compose --progress quiet -f docker-compose-${app}-unit.yml build
  docker compose --progress quiet -f docker-compose-${app}-unit.yml up \
    --force-recreate \
    --remove-orphans \
    --no-log-prefix \
    --abort-on-container-exit \
    --exit-code-from ${app}-unit-tests
done

for app in "${apps[@]}"
do
  echo "Integration Testing $app..."
  docker compose --progress quiet -f docker-compose-${app}-integration.yml build
  docker compose --progress quiet -f docker-compose-${app}-integration.yml up \
    --force-recreate \
    --remove-orphans \
    --no-log-prefix \
    --abort-on-container-exit \
    --exit-code-from ${app}-integration-tests
done