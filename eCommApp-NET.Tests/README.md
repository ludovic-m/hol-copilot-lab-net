# eCommApp-NET.Tests

Unit test project for the eCommApp-NET Blazor WebAssembly application.

## Test Framework

This project uses **xUnit** as the testing framework, which is a popular and modern testing framework for .NET applications.

## Test Libraries

- **xUnit** - Core testing framework
- **bUnit** - Testing library for Blazor components (enables component rendering and interaction testing)
- **Microsoft.NET.Test.Sdk** - Required for running tests

## Project Structure

```
eCommApp-NET.Tests/
├── Services/
│   └── CartServiceTests.cs    # Unit tests for CartService
└── eCommApp-NET.Tests.csproj
```

## Running Tests

### Run all tests
```bash
cd eCommApp-NET.Tests
dotnet test
```

### Run tests with detailed output
```bash
dotnet test --verbosity detailed
```

### Run tests with code coverage
```bash
dotnet test /p:CollectCoverage=true
```

Or use the convenience script:
```bash
# PowerShell
./test-coverage.ps1

# Bash
./test-coverage.sh
```

### Run tests with code coverage (specific format)
```bash
# OpenCover format
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

# lcov format
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./coverage/
```

### Run specific test
```bash
dotnet test --filter "FullyQualifiedName~CartServiceTests.AddToCart_ShouldAddNewItem_WhenProductNotInCart"
```

## Code Coverage

The project uses **Coverlet** for code coverage analysis. Coverage reports show:
- **Line Coverage**: Percentage of code lines executed during tests
- **Branch Coverage**: Percentage of decision branches (if/else) tested
- **Method Coverage**: Percentage of methods called during tests

### Current Coverage
```
| Module       | Line   | Branch | Method |
|--------------|--------|--------|--------|
| eCommApp-NET | 18.18% | 7.4%   | 31.34% |
```

**Note**: Coverage is currently focused on the CartService. As more tests are added for other services and components, coverage will increase.

## Current Test Coverage

### CartService Tests
- ✅ `CartItems_ShouldBeEmpty_WhenServiceIsCreated` - Verifies initial state
- ✅ `AddToCart_ShouldAddNewItem_WhenProductNotInCart` - Tests adding new product
- ✅ `AddToCart_ShouldIncreaseQuantity_WhenProductAlreadyInCart` - Tests quantity increment
- ✅ `ClearCart_ShouldRemoveAllItems` - Tests clearing cart
- ✅ `OnChange_ShouldTriggerEvent_WhenItemIsAdded` - Tests event notification on add
- ✅ `OnChange_ShouldTriggerEvent_WhenCartIsCleared` - Tests event notification on clear
- ✅ `AddToCart_ShouldHandleMultipleProducts` - Tests multiple products with varying quantities

## Adding New Tests

To add new tests:

1. Create a new test class in the appropriate folder (e.g., `Services/`, `Components/`)
2. Add the `using Xunit;` directive
3. Create test methods with the `[Fact]` attribute
4. Follow the Arrange-Act-Assert pattern

### Example Test Structure

```csharp
using Xunit;
using eCommApp_NET.Services;
using eCommApp_NET.Models;

namespace eCommApp_NET.Tests.Services;

public class ExampleTests
{
    [Fact]
    public void TestMethod_Should_ExpectedBehavior()
    {
        // Arrange - Set up test data and dependencies
        var service = new MyService();
        
        // Act - Execute the method being tested
        var result = service.DoSomething();
        
        // Assert - Verify the expected outcome
        Assert.NotNull(result);
    }
}
```

## Future Testing Plans

- Add component tests using bUnit for Blazor components (Cart.razor, Products.razor, etc.)
- Add tests for ProductService
- Add integration tests for complete user workflows
- Add snapshot testing for component rendering
