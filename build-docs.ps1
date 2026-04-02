$ErrorActionPreference = 'Stop'

dotnet tool restore
if (Test-Path 'site/.lunet/build') {
    Remove-Item 'site/.lunet/build' -Recurse -Force
}
Push-Location site
try {
    dotnet tool run lunet --stacktrace build
}
finally {
    Pop-Location
}
