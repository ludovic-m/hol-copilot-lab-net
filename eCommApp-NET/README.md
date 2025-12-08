# eCommApp-NET

A Blazor WebAssembly e-commerce application for "The Daily Harvest" - a fruit shopping website.

## Description

This is a .NET 9.0 Blazor WebAssembly application migrated from the original React/TypeScript eCommApp. It provides the same functionality with a modern .NET stack:

- Browse products
- View product details and reviews
- Add products to cart
- Checkout process
- Admin portal for managing sales
- User authentication

## Technology Stack

- **.NET 9.0** - Latest .NET version
- **Blazor WebAssembly** - Client-side web UI framework
- **C#** - Programming language
- **CSS3** - Styling

## Project Structure

```
eCommApp-NET/
├── Components/
│   ├── Pages/              # Routable pages
│   │   ├── Home.razor
│   │   ├── Products.razor
│   │   ├── Cart.razor
│   │   ├── Login.razor
│   │   └── Admin.razor
│   ├── Header.razor        # Shared header component
│   ├── Footer.razor        # Shared footer component
│   ├── ReviewModal.razor   # Product review modal
│   ├── CheckoutModal.razor # Checkout confirmation modal
│   └── MainLayout.razor    # Main layout wrapper
├── Models/
│   └── Models.cs          # Product, Review, User, Address, CartItem models
├── Services/
│   ├── CartService.cs     # Shopping cart state management
│   └── ProductService.cs  # Product data loading
├── wwwroot/
│   ├── css/
│   │   └── app.css       # Application styles
│   ├── products/         # Product JSON data
│   │   └── productImages/ # Product images
│   └── index.html        # HTML shell
├── App.razor             # Root component with routing
├── Program.cs            # Application entry point
└── eCommApp-NET.csproj   # Project file
```

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later

## Getting Started

### Installation

1. Navigate to the project directory:
   ```powershell
   cd eCommApp-NET
   ```

2. Restore dependencies:
   ```powershell
   dotnet restore
   ```

### Running the Application

1. Run the application:
   ```powershell
   dotnet run
   ```

2. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

Alternatively, you can use the watch mode for development (with hot reload):
```powershell
dotnet watch
```

### Building for Production

To build the application for production:

```powershell
dotnet build --configuration Release
```

To publish the application:

```powershell
dotnet publish --configuration Release
```

The published files will be in `bin/Release/net9.0/publish/wwwroot/` and can be hosted on any static web server.

## Features

### Pages

- **Home** (`/`) - Welcome page with information about The Daily Harvest
- **Products** (`/products`) - Browse all available products, add to cart, view reviews
- **Cart** (`/cart`) - View cart items and proceed to checkout
- **Login** (`/login`) - Admin authentication (default credentials: admin/admin)
- **Admin** (`/admin`) - Admin portal to set sales percentages

### Components

- **Header** - Navigation bar with links to all pages
- **Footer** - Footer with copyright information
- **ReviewModal** - Modal for viewing and submitting product reviews
- **CheckoutModal** - Confirmation dialog for checkout

### Services

- **CartService** - Manages shopping cart state across the application
- **ProductService** - Loads product data from JSON files

## Default Admin Credentials

- **Username**: admin
- **Password**: admin

⚠️ **Note**: Change these credentials for production use!

## Development Notes

### Key Differences from React Version

1. **Component Model**: Uses Blazor components (`.razor` files) instead of React components (`.tsx`)
2. **State Management**: Uses C# services with events instead of React Context
3. **Routing**: Uses Blazor's built-in routing instead of React Router
4. **Lifecycle**: Uses Blazor lifecycle methods (`OnInitialized`, `OnInitializedAsync`) instead of React hooks
5. **Language**: C# instead of TypeScript

### Architecture

The application follows a component-based architecture:

- **Components** handle UI rendering and user interaction
- **Services** manage application state and data loading
- **Models** define data structures
- **Dependency Injection** provides services to components

## Testing

To run tests (if added in the future):

```powershell
dotnet test
```

## Contributing

This project is part of a GitHub Copilot hands-on lab for learning purposes.

## License

Copyright © 2025 The Daily Harvest. All rights reserved.
