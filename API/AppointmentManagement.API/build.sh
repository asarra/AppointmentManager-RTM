#!/usr/bin/env bash
#
# Generated by: https://openapi-generator.tech
#

dotnet restore src/AppointmentManagement.API/ && \
    dotnet build src/AppointmentManagement.API/ && \
    echo "Now, run the following to start the project: dotnet run -p src/AppointmentManagement.API/AppointmentManagement.API.csproj --launch-profile web"
