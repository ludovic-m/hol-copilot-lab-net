#!/usr/bin/env pwsh
# Run tests with code coverage and display results

Write-Host "Running tests with code coverage..." -ForegroundColor Cyan
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

Write-Host "`nCoverage report generated!" -ForegroundColor Green
