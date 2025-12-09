#!/bin/bash
# Run tests with code coverage and display results

echo "Running tests with code coverage..."
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

echo ""
echo "Coverage report generated!"
