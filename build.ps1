# param (
#     [switch]$Force
# )


# Set-Location $PSScriptRoot

# docker compose build --no-cache
# docker compose up



# # Check existing images
# $Images = (docker images) -split [Environment]::NewLine | Select-Object -Skip 1 | ForEach-Object {
#     $Value = $_
#     $Columns = (($Value -split ' ')  | Where-Object { $_ -ne $null -and $_ -ne '' })
#     return @{
#         Repository = $Columns[0].Trim();
#         Version = $Columns[1].Trim()
#     }
# }

# # Install Postgres if not existing
# if ($Images.Repository -notcontains 'postgres' -or $Images.Version -notcontains 'latest') {
#     docker pull postgres:latest
# }

# # Get Running Containers
# $Containers = (docker container ls --format "{{json . }}") | ConvertFrom-Json 

# if ($Containers.Names -notcontains 'MyData') {
#     docker run --name MyData -e POSTGRES_PASSWORD=Kg<j>aie48934!245jf -d postgres
# }


Set-Location "$PSScriptRoot\database\src\MyData"

dotnet build

Set-Location $PSScriptRoot

sqlpackage `
    /Action:Publish `
    /SourceFile:"./database/src/MyData/bin/Debug/MyData.dacpac" `
    /TargetServerName:"localhost" `
    /TargetDatabaseName:"MyData" `
    /TargetUser:"sa" `
    /TargetPassword:"Kg<j>aie48934!245jf" `
    /TargetEncryptConnection:Optional