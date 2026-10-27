# QR Microservice

This project provides a simple ASP.NET Core microservice for generating QR code images from input data.

## Overview

The service accepts a JSON payload containing:
- policy
- Type
- File

It generates a QR code based on the combined value:

policy|Type|File

Then it returns the QR image as a Base64 string.

## API Endpoint

POST /api/GenerateQR

### Request body
```json
{
  "policy": "D0706600093",
  "Type": "file",
  "File": "Image"
}
```

### Response body
```json
{
  "policy": "D0706600093",
  "base64": "iVBORw0KGgoAAAANSUhEUgAA..."
}
```

## Run locally

```bash
dotnet run --project QrMicroservice.csproj
```

Then open:
- http://localhost:5000/swagger

## Project structure

- Controllers/
- Models/
- Services/
- Program.cs

## Notes

- This API is intended for internal QR generation use.
- Generated output is returned as Base64 PNG data.
