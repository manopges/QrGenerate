# QR Microservice Specification

## Purpose

Create a microservice that accepts business input and returns a QR code image encoded as Base64.

## Input Contract

### Request JSON
```json
{
  "policy": "D0706600093",
  "Type": "file",
  "File": "Image"
}
```

### Fields
- policy: string, required
- Type: string, optional but recommended
- File: string, required

## Processing

The system combines the values into a single payload string:

```text
{policy}|{Type}|{File}
```

Example:

```text
D0706600093|file|Image
```

## QR Generation

- Use QRCoder library
- Generate QR code with ECC level Q
- Render PNG image
- Convert the image to Base64 string

## Output Contract

### Response JSON
```json
{
  "policy": "D0706600093",
  "base64": "iVBORw0KGgoAAAANSUhEUgAA..."
}
```

## Route

- POST /api/GenerateQR

## Error Handling

- If policy is empty: return HTTP 400 with message
- If file is empty: return HTTP 400 with message

## Technology

- ASP.NET Core 10
- C#
- QRCoder
- Swagger UI

## Validation

The service should be validated with a POST request using Postman or Swagger UI.
