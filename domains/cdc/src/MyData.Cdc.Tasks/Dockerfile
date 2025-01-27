FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the project files to the container
COPY . ./

# Restore dependencies
RUN dotnet restore ./domains/cdc/src/MyData.Cdc.Tasks/MyData.Cdc.Tasks.csproj

# Build the app
RUN dotnet publish ./domains/cdc/src/MyData.Cdc.Tasks/MyData.Cdc.Tasks.csproj -c Release -o out

# Use the official runtime image for the final stage
FROM mcr.microsoft.com/dotnet/runtime:9.0

# Set the working directory for the runtime image
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/out .

# Specify the entry point for the application
ENTRYPOINT ["dotnet", "MyData.Cdc.Tasks.dll"]
