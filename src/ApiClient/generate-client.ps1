#detect if java is installed, with Get-Command java, if not, write-host warning
if (-not (Get-Command java -ErrorAction SilentlyContinue)) {
    Write-Host "Java is not installed. Please download and install from https://www.java.com/en/download/"
    exit
}
else{
    Write-Host "Java is installed."
}

# Ensure you have OpenAPI Generator by checking if openapi-generator-cli.jar exists in the current folder, please use Invoke-WebRequest to download the jar file
if (-not (Test-Path "openapi-generator-cli.jar")) {
    Write-Host "OpenAPI Generator CLI is not installed. Start downloading the JAR file from https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/7.12.0/openapi-generator-cli-7.12.0.jar"
    Invoke-WebRequest -OutFile openapi-generator-cli.jar https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/7.12.0/openapi-generator-cli-7.12.0.jar
}
else {
    Write-Host "OpenAPI Generator CLI is already installed."
}

# Define paths
$openapiSpecPath = "../../openapi.yaml"
$outputDir = "./Generated"

# Generate the API client, by executing with java -jar
Write-Host "Generating API client from OpenAPI specification..."
java -jar openapi-generator-cli.jar generate -i $openapiSpecPath -g csharp -o $outputDir

Write-Host "API client generation complete."