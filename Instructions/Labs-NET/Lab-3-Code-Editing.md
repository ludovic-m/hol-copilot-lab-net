# Exercise 3 - Writing Unit Tests with GitHub Copilot Edit Mode (.NET Edition)

#### Duration: 30 minutes

## 🎯 Learning Objectives

By the end of this exercise, you will:
- Understand how to use GitHub Copilot's Autocomplete feature and Edit mode for .NET code modifications
- Learn to write comprehensive unit tests for C# services with AI assistance
- Improve existing code coverage using intelligent test generation with xUnit
- Understand best practices for AI-assisted testing in .NET applications

## 🍎 Scenario: Improving The Daily Harvest's Test Coverage

Your manager at The Daily Harvest has noticed that some critical e-commerce services lack proper test coverage. During yesterday's code review, the team identified the `CartService` and other services in the Blazor application that need comprehensive unit tests before the next release.

Your task today is to use GitHub Copilot to write high-quality xUnit tests that will:
- Verify happy path scenarios such as the cart having items
- Test edge cases like the cart being empty
- Improve overall code quality and reliability


## 📊 Step 1: Baseline Testing and Coverage Analysis

Before we start writing new tests, let's establish a baseline by running the existing test suite and checking our current code coverage. We can use what we learned in Exercise 2 about how to run tests in this .NET project.

### Instructions:
1. Navigate to the test project directory in your terminal
   ```powershell
   cd eCommApp-NET.Tests
   ```
2. Run the existing test suite to ensure everything is working:
   ```powershell
   dotnet test
   ```
3. Generate a coverage report to see which parts of the code need additional testing:
   ```powershell
   dotnet test /p:CollectCoverage=true
   ```
4. Review the coverage report output in your terminal and note:
   - Overall coverage percentage (Line, Branch, Method)
   - Which files have low coverage
   - Specific services or methods that aren't tested

### 💡 What to Look For:
- **Line Coverage**: Percentage of code lines executed during tests
- **Branch Coverage**: Percentage of conditional branches (if/else) tested
- **Method Coverage**: Percentage of methods called during tests

This baseline will help you understand exactly which test cases you need to add in the following steps.

**Pro Tip:** Keep the coverage report open in a separate terminal tab so you can re-run it after adding new tests to see your progress!


## ✏️ Step 2: Using Autocomplete to Generate One Additional Unit Test

To start off, you'd like to generate one additional unit test for the `CartService`. We can use GitHub Copilot's Autocomplete feature to make an addition to the unit test suite.

### Instructions:
1. Open the existing test file named `CartServiceTests.cs` in the `eCommApp-NET.Tests/Services` directory.
2. Place your cursor at the end of the file, after the last test method, and create a new line.
3. Add a comment (starting with '//') stating that you'd like to test a specific condition in the `CartService`. For example, you could test removing an item that doesn't exist, or test the `OnChange` event behavior in more detail.
   
   Please refer to the below sample comment if you get stuck.

   <details>
   <summary>Sample New Test Comment</summary>

     ```csharp
     // Test that attempting to remove a non-existent item from the cart doesn't throw an error
     ```

   </details>

4. After adding the comment, press `Enter` to go to the next line. GitHub Copilot will start suggesting lines of code, and you can press `Tab` to accept
   one and then press `Enter` to go to the next line, repeating this process until the test is implemented. If GitHub Copilot starts suggesting the next test, you can simply press the `Esc` key to stop the code generation process.

5. Once the test is generated, try running it to make sure that it and the existing tests pass:
   ```powershell
   dotnet test
   ```
   
   If there are any failures, try asking GitHub Copilot how to fix them.

## 💭 Step 3: Using Edit Mode to Generate Additional Unit Tests

There are many other tests that we can write for `CartService`. While we could continue using Autocomplete to generate them, that would be very slow and cumbersome. We'll instead use GitHub Copilot's Edit mode to create comprehensive unit tests.

### Why Edit Mode is Perfect for Unit Testing:
- 🎯 **Context-aware**: Understands your existing C# code structure and xUnit testing patterns
- 🔧 **Precise modifications**: Makes targeted changes without affecting unrelated code
- 📋 **Pattern recognition**: Follows your project's testing conventions and C# style
- 🚀 **Efficiency**: Generates comprehensive test suites quickly

### 🔍 Providing Context for Better Test Generation:
GitHub Copilot automatically gathers context from several sources to understand your codebase:
- **Active editor**: The currently open file and your cursor position
- **Selection**: Any highlighted/selected code in the editor
- **Open tabs**: Files you have open in VS Code tabs
- **Workspace**: Your project structure and related files

However, for generating comprehensive unit tests, you should **explicitly provide context** about the service you're testing. Here's how to improve test generation for `CartService`:

#### 📋 Best Practices for Test Context:

1. **Open the source file**: Have `CartService.cs` open in a tab alongside your test file
2. **Use file references**: Include `@CartService.cs` in your prompts to explicitly reference the service
3. **Highlight relevant code**: Select specific methods or sections you want to test
4. **Reference dependencies**: Mention related files like `Models.cs` if your tests need to use the models

**Learn More:** [VS Code Copilot Chat Context Documentation](https://code.visualstudio.com/docs/copilot/chat/copilot-chat-context)

### Instructions:
1. Open GitHub Copilot Chat and switch to Edit mode
2. Include `CartService.cs` in your context by opening it in a tab or referencing it in your prompt
3. Write prompts to generate tests for uncovered conditions in `CartService`. 

<details>
  <summary>Sample Test Generation Prompt</summary>

  ```
  Generate comprehensive unit tests for the CartService class using xUnit. Make sure to generate tests that cover negative scenarios and edge cases.
  ```

</details>

<details>
  <summary>More Specific Prompt</summary>

  ```
  Add xUnit tests for CartService that cover the following conditions if they have not already been covered:
   - Adding multiple different products to the cart
   - Verifying the cart items count
   - Testing event notifications when items are added or removed
   - Edge case: adding a product with null ID
  ```

</details>

3. **Important**: Remember that while GitHub Copilot is very powerful, it is still a best practice to always review and validate the code generated by AI tools. Make sure to:
   - Check for correctness and completeness
   - Ensure adherence to your project's C# coding standards
   - Validate that all edge cases are covered
   - Verify proper use of xUnit attributes (`[Fact]`, `[Theory]`, etc.)

4. Run the newly-generated tests to ensure they pass and verify the expected behavior:
   ```powershell
   dotnet test
   ```
   
   If any tests fail, you can always ask GitHub Copilot for help fixing them.

5. Re-run the coverage report to see your improvement:
   ```powershell
   dotnet test /p:CollectCoverage=true
   ```

### 🎁 Optional Task: Refine tests to handle an edge case that GitHub Copilot didn't cover initially

**Pro Tip:** The more specific and contextual your Edit mode prompts are, the better the generated C# code will be. Always review and iterate on AI-generated tests to ensure they meet your quality standards!

## 🎓 Step 4: Best Practices and Code Review

Now that you've generated comprehensive unit tests, it's important to ensure they follow industry best practices and maintain high quality. This step focuses on using GitHub Copilot to review and refine your testing approach.

### Why Code Review Matters for AI-Generated Tests:
- 🔍 **Quality Assurance**: Even AI-generated code benefits from systematic review
- 📏 **Standards Compliance**: Ensures tests follow your team's .NET conventions
- 🎯 **Coverage Validation**: Confirms all critical scenarios are tested
- 🛠️ **Maintainability**: Makes tests easier to understand and modify later

Let's use GitHub Copilot to review and improve our test quality.

### Instructions:

Ask GitHub Copilot to review your xUnit unit tests and make suggestions for improvement. Consider implementing its suggestions if you have time.

```
@workspace Do these xUnit tests follow .NET testing best practices? Check the following and suggest improvements if needed:
- Clear and descriptive test method names (following C# conventions)
- Single responsibility per test
- Clear Arrange-Act-Assert structure
- Single assertion per test (when appropriate)
- Appropriate use of xUnit features ([Fact], [Theory], etc.)
- Good error messages and test data setup
- Proper async/await usage if needed
- Performance considerations
- Maintainable test structure
```

### Additional Review Prompts:

```
Are there any services in the eCommApp-NET project that don't have tests yet? What should I test next?
```

```
Review the test coverage for ProductService. What scenarios are missing?
```

## 🏆 Exercise Wrap-up

Great work! You've successfully used GitHub Copilot's Edit mode to:
- ✅ Generate comprehensive xUnit unit tests for critical business logic
- ✅ Cover edge cases and error conditions in C# services
- ✅ Improve code coverage and quality
- ✅ Follow .NET testing best practices

### Reflection Questions:
1. **How did Edit mode compare to Autocomplete for .NET test generation?**
2. **What types of test scenarios did GitHub Copilot excel at generating for C# code?**
3. **Where did you need to provide additional guidance or corrections?**
4. **How might you use Edit mode differently in future .NET testing tasks?**
5. **What differences did you notice between testing in .NET/xUnit vs JavaScript/Vitest?**

### Key Takeaways:
- GitHub Copilot's Edit mode is a powerful tool for generating and refining xUnit tests
- Always review AI-generated C# code to ensure quality and correctness
- Use specific prompts to guide AI towards your desired outcomes
- Context is crucial - reference the files you're testing explicitly
- Coverage reports help you identify what needs testing

## 🚀 Next Steps

In Exercise 4, we'll explore GitHub Copilot's **Agent mode** to tackle more complex, multi-file tasks like implementing complete shopping cart features with service integration, component updates, and comprehensive testing across the Blazor application.

#### You have successfully completed the lab. Click on **Next >>** to continue to the next lab.

![](../../media/next-page.png)
