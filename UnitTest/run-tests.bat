dotnet test --results-directory ./ /p:CollectCoverage=true /p:CoverletOutput=coveragereport\ /p:CoverletOutputFormat=cobertura /p:Exclude="[xunit.*]*

dotnet C:\Users\khushbupanwala\.nuget\packages\reportgenerator\4.5.0\tools\netcoreapp3.0\ReportGenerator.dll "-reports:coveragereport\coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html

start coveragereport\index.htm