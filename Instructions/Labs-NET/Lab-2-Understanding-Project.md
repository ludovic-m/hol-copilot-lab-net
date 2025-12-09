# Exercise 2 - Exploring the .NET Codebase with GitHub Copilot

#### Duration: 30 minutes

## 🎯 Learning Objectives

By the end of this exercise, you will:
- Use GitHub Copilot Chat in "Ask" mode to understand unfamiliar .NET codebases
- Learn how to efficiently navigate and analyze Blazor WebAssembly project structure with AI assistance
- Understand how to identify build processes, testing frameworks, and dependencies in .NET
- Develop strategies for onboarding to new .NET projects using GitHub Copilot

## 🍎 Scenario: Your First Day at The Daily Harvest

Welcome to your first day as a developer at The Daily Harvest! Your manager has just given you access to the .NET Blazor WebAssembly e-commerce repository, but like any new team member, you need to understand:
- What does this application actually do?
- How is the code organized and structured?
- What technologies and frameworks are being used?
- How do I build, run, and test the application?

As a modern developer, you'll leverage GitHub Copilot Chat to accelerate your onboarding process and get productive quickly.

## 🤖 Introduction to GitHub Copilot Chat

GitHub Copilot Chat is an AI-powered conversational interface that helps you understand code, generate implementations, and solve development challenges. There are several modes to interact with GitHub Copilot:

| Mode | Purpose | Best For |
|------|---------|----------|
| **Ask** | Get explanations and answers about code | Understanding existing code, learning new concepts |
| **Edit** | Modify existing code with AI assistance | Refactoring, bug fixes, feature additions |
| **Agent** | Delegate complex tasks to AI | Multi-file changes, architectural decisions |

For exploring an unfamiliar codebase, **Ask mode** is ideal because it allows you to:
- Query specific files or code patterns without making changes
- Get high-level explanations of project structure and purpose
- Understand dependencies, build processes, and testing strategies
- Ask follow-up questions to deepen your understanding

## 🧠 Choosing the Right AI Model

GitHub Copilot Chat offers access to multiple AI models, each with different strengths and capabilities. Understanding when to use each model can significantly improve your development experience.

### Available Models

GitHub Copilot provides access to several AI models from leading providers such as OpenAI, Anthropic, Google, and others. The available options are constantly evolving. For the most up-to-date information about supported models and their capabilities, see the official documentation: [GitHub Copilot Supported Models](https://docs.github.com/copilot/reference/ai-models/supported-models)

Different models excel at different types of tasks. For detailed information about each model's strengths and ideal use cases, see the [AI Models Comparison Guide](https://docs.github.com/copilot/reference/ai-models/model-comparison):
- Some are optimized for **code understanding and analysis**
- Others excel at **complex reasoning and problem-solving**
- Some prioritize **speed for quick responses**
- Others focus on **detailed explanations and accuracy**

GitHub is now also offering a new auto model selection feature within Visual Studio Code that automatically chooses the best model for your specific task based on context and requirements. This can help streamline your workflow by ensuring you're always using the most suitable AI model without manual selection. More information can be found here: [Auto Model Selection](https://docs.github.com/copilot/concepts/auto-model-selection).  

### 💰 Model Pricing and Usage Limits

**Important**: Different AI models have different pricing structures and usage limits:

- **0x Models**: Unlimited usage within your Copilot subscription
- **Other Models**: Have different cost multipliers and usage limits
- **Auto Model Selection**: Will automatically choose from a variety of models with different multipliers at a 10% discount
- **Usage Allowances**: 
    - Copilot Business: 300 requests per user per month
    - Copilot Enterprise: 1,000 requests per user per month
- **Additional Requests**: Available at $0.04 each when you exceed your monthly allowance

For complete details on model pricing and billing, see: [GitHub Copilot Billing Documentation](https://docs.github.com/copilot/concepts/billing/copilot-requests)


### 🔄 Experimenting with Different Models

Try asking the same question to different models to compare their responses! Each model may provide unique insights or different perspectives on the same problem.

**How to Switch Models:**
1. In GitHub Copilot Chat, look for the model selector (usually below the text area in which prompts can be submitted)
2. Click on the current model name to see available options
3. Select a different model and ask your question


## 🔍 Step 1: Understanding the Project Purpose

Let's start by getting a high-level understanding of what this .NET application does.

### Instructions:
1. Switch to "Ask" mode within GitHub Copilot Chat if you are not already in that mode.
2. Ask GitHub Copilot some questions to help you understand the application as it is currently working. 
3. **Try different models**: Start with the default model, then experiment with others to see how their explanations differ

If you get stuck, try using these sample prompts to explore the project:

<details>
  <summary>Sample Prompts</summary>
  
  ```
  What is the main purpose of the eCommApp-NET application? What does it do?
  ```

  ```
  Can you give me a high-level overview of this Blazor WebAssembly project's features and functionality?
  ```

  ```
  What type of application is this? How does Blazor WebAssembly differ from other web frameworks?
  ```

</details>

### 💡 What to Expect from GitHub Copilot

When you ask these questions, GitHub Copilot will analyze your workspace and provide insights such as:
- **Application Type**: Whether it's an e-commerce site, API, Blazor WebAssembly SPA, etc.
- **Core Features**: Key functionality like user authentication, product catalogs, shopping cart
- **Technology Stack**: .NET version, Blazor components, C# patterns, and architectural patterns in use
- **Business Domain**: The industry or use case the application serves

GitHub Copilot's responses will be based on analyzing your codebase structure, `.csproj` files, Razor components, and code patterns. The more specific your questions, the more targeted and useful the responses will be.

## 🏗️ Step 2: Analyzing Project Structure

Now let's understand how the .NET code is organized and what the folder structure tells us.

### Instructions:
Ask GitHub Copilot some questions to help you understand the organization of the Blazor WebAssembly codebase. **Experiment**: Try asking the same structural question to different models - you might get varying levels of detail or different organizational perspectives! If you get stuck, try using these sample prompts to explore the project:

<details>
  <summary>Sample Prompts</summary>

  ```
  How is the eCommApp-NET project structured? Can you explain the main folders and their purposes?
  ```

  ```
  What are the most important files I should understand as a new developer on this Blazor WebAssembly project?
  ```

  ```
  What does the .csproj file tell me about this project? What are the key dependencies?
  ```

  ```
  How are Razor components organized in this project?
  ```

</details>

### 💡 What to Expect from GitHub Copilot

When you ask these questions, GitHub Copilot will analyze the files and folders in your workspace and provide a structural breakdown, including:
- **Folder Roles**: Explanations of what code lives in directories like `Components/`, `Services/`, `Models/`, `wwwroot/`, etc.
- **Key Files**: Identification of critical files such as `Program.cs`, `_Imports.razor`, `.csproj`, or main entry points.
- **Architectural Patterns**: Insights into how the project is organized (e.g., component-based architecture, service layer pattern, dependency injection).
- **Configuration Details**: Information about configuration in `Program.cs`, static assets in `wwwroot/`, or component lifecycle.

GitHub Copilot's response helps new developers quickly orient themselves by providing a map of the Blazor WebAssembly codebase organization.

## 💻 Step 3: Identifying Technologies and Frameworks

Understanding the .NET tech stack is crucial for knowing what skills you'll need and how to work effectively.

### Instructions:
Ask GitHub Copilot some questions to help you understand the technologies and frameworks used within the .NET codebase. 

If you get stuck, try using these sample prompts to explore the project

<details>
  <summary>Sample Prompts</summary>

  ```
  What version of .NET is this project using? What are the key frameworks and packages?
  ```

  ```
  What NuGet packages does this project depend on? Can you explain what each major one does?
  ```

  ```
  How does Blazor WebAssembly work? What makes it different from server-side Blazor?
  ```

  ```
  What's the .csproj file telling me about the project configuration and dependencies?
  ```

</details>

If GitHub Copilot mentions any technologies you're unfamiliar with, don't hesitate to ask follow-up questions! Remember, GitHub Copilot Chat isn't just for understanding your specific codebase—it's your **onboarding buddy**, **technical sounding board**, and **intelligent search engine** all rolled into one.

<details>
  <summary>Sample Follow-up Prompts</summary>

  ```
  Can you explain what Blazor WebAssembly is and why it might be used instead of traditional JavaScript frameworks?
  ``` 

  ```
  What are the key benefits of using Razor components over other component models?
  ``` 

  ```
  How does dependency injection work in Blazor WebAssembly?
  ```
</details>

### 🎁 Optional Model Experimentation Challenge

Technical framework questions are great for comparing models - try asking about Blazor WebAssembly or .NET features with different available models to see different explanation styles! 

**Try This**: Pick one technology or framework from the project and ask about it using different available models. Try each of these three prompts and compare the responses.

1. "What is [technology] and how does it work?"
2. "Explain [technology] and its role in this Blazor project"
3. "Analyze the architectural benefits of using [technology] in this context"

**Questions to Consider:**
- Which model gave the most comprehensive explanation?
- Did any model provide unique insights the others missed?
- Which explanation style did you prefer and why?
- How did the depth of technical detail vary between models?


## 🔨 Step 4: Understanding the Build Process

Now let's figure out how to actually build and run this Blazor WebAssembly application.

### Instructions:

Ask GitHub Copilot how to build your .NET codebase. If you get stuck you can use the below sample prompts:

<details>
  <summary>Sample Prompts</summary>

  ```
  How do I build and run the eCommApp-NET project? What are the dotnet commands I need?
  ```

  ```
  What do I need to install or set up before I can run this Blazor WebAssembly project locally?
  ```

  ```
  Are there any environment variables or configuration I need to set up for this .NET project?
  ```

  ```
  How do I start the development server for this Blazor WebAssembly application?
  ```

</details>

### ⚙️ Try It Yourself:
1. Follow the build instructions GitHub Copilot provided
2. Try to start the development server
3. If you encounter errors, ask GitHub Copilot for help troubleshooting

<details>
  <summary>Hints</summary>

  You can build and run the project by [opening a terminal](https://code.visualstudio.com/docs/terminal/getting-started) in Visual Studio Code and running the following commands:

  ```powershell
  cd eCommApp-NET
  dotnet restore
  dotnet run
  ```

  Or simply:
  ```powershell
  cd eCommApp-NET
  dotnet watch
  ```
</details>

Once you have the application running locally, you can explore its functionality in your web browser at the URL shown in the terminal (typically `http://localhost:5000` or `https://localhost:5001`). See how the Blazor website compares to the high-level description GitHub Copilot provided earlier! You can test basic features like browsing products, adding items to the cart, and checking out.

## 🧪 Step 5: Understanding the Testing Strategy

Testing is crucial for maintaining code quality in .NET applications. Let's explore what testing frameworks and practices are in place.

### Instructions:

Ask GitHub Copilot how the .NET codebase is being tested. If you get stuck you can use the below sample prompts:

<details>
  <summary>Sample Prompts</summary>

  ```
  How do I run the tests for this .NET project? What testing frameworks are being used?
  ```

  ```
  What types of tests exist in this codebase? How is xUnit being used?
  ```

  ```
  Can you analyze the test coverage? How do I generate a coverage report?
  ```

  ```
  How are tests organized in the eCommApp-NET.Tests project? Where should I put new tests?
  ```

</details>

### 📈 Extension: Test Coverage Deep Dive
**Advanced Prompts:**

```
Can you identify which services or components have low or missing test coverage?
```

```
What would be good candidates for adding more tests to improve coverage in this Blazor application?
```

```
How does the test coverage reporting work with Coverlet?
```

## 🎁 Optional Task: Building a Better README

Now that you understand the .NET project structure and setup process, let's use GitHub Copilot to improve the project documentation for future developers.

### Instructions:
1. Use GitHub Copilot to analyze the current README in the eCommApp-NET folder (if it exists) and suggest improvements. See the below sample prompts if you get stuck.
2. Create or enhance documentation based on your exploration.

<details>
  <summary>Sample Prompts</summary>

  ```
  Does the eCommApp-NET project have a README? If so, what's missing that would help new .NET developers?
  ```

  ```
  Based on our conversation about this Blazor project, can you help me create a comprehensive "Quick Start Guide" for new developers? Include setup steps, key dotnet commands, and important files to know about.
  ```

  ```
  Can you suggest a better project description and feature list for the README based on the actual Blazor WebAssembly codebase?
  ```

</details>

### 💡 Pro Tips for README Enhancement:
- Include actual `dotnet` commands you've tested
- Add troubleshooting sections for common .NET/Blazor issues
- Document .NET SDK version requirements and dependencies
- Include links to important Razor components, services, and models
- Add examples of common development tasks (build, test, coverage)

### 🔄 Iterative Improvement:
After GitHub Copilot generates documentation, you can refine it:

```
Can you make this setup guide more beginner-friendly for developers new to Blazor?
```

```
Add a troubleshooting section for common .NET build and runtime issues.
```

```
Include examples of how to run tests and generate coverage reports.
```

## 💡 Tips and Tricks

### 🤝 GitHub Copilot as Your .NET Learning Partner

Think of GitHub Copilot Chat as having a knowledgeable senior .NET developer sitting next to you who's always available to answer questions. You can ask about:

**Technology Fundamentals:**

```
What is Blazor WebAssembly and why is it popular for .NET web development?
```

```
Explain the difference between Blazor Server and Blazor WebAssembly.
```

```
What are the pros and cons of using C# for front-end development with Blazor?
```

**Best Practices & Patterns:**

```
What's the service layer pattern and how does it apply to Blazor applications?
```

```
When should I use async/await in C# Blazor components?
```

```
What are some common security considerations for Blazor WebAssembly applications?
```

**Troubleshooting & Problem Solving:**

```
I'm getting this error: [paste error message]. What does it mean and how can I fix it?
```

```
Why might my Blazor component not be rendering updates?
```

```
Why are my tests failing when using bUnit?
```

### 💡 Pro Tips for Effective Learning with GitHub Copilot

1. **Ask "Why" Questions**: Don't just ask what something does—ask why it's used

    ```
    Why would a team choose Blazor WebAssembly over React or Angular?
    ```

2. **Request Comparisons**: Understanding alternatives helps you make better decisions

    ```
    Compare Blazor WebAssembly vs Blazor Server - when would I use each?
    ```

3. **Get Context**: Ask how technologies fit into the bigger picture

    ```
    How does dependency injection work in a Blazor WebAssembly application lifecycle?
    ```

4. **Seek Examples**: Request practical demonstrations

    ```
    Can you show me a simple example of how event handling works in Razor components?
    ```

### 🔍 Making the Most of Your AI Learning Buddy

**Start Broad, Then Go Deep:**
- Begin with general concepts: "What is component-based architecture?"
- Then get specific: "How do I implement state management in a Blazor component?"

**Don't Be Afraid to Ask "Dumb" Questions:**
- "What's the difference between a Razor component and a Razor page?"
- "Why do .NET developers use NuGet?"
- "What does 'full-stack C#' actually mean?"

**Use It as a Sanity Check:**
- "Does this approach make sense for solving [problem] in Blazor?"
- "Am I overthinking this, or is there a simpler way in .NET?"
- "What are the potential downsides of this solution?"

Remember: Every expert was once a beginner. GitHub Copilot Chat gives you a judgment-free space to ask questions, explore .NET concepts, and build your understanding at your own pace!


## 🏆 Exercise Wrap-up

Congratulations! You've successfully used GitHub Copilot Chat in Ask mode to:
- ✅ Understand the purpose and functionality of an unfamiliar Blazor WebAssembly codebase
- ✅ Analyze .NET project structure and organization
- ✅ Identify technologies, frameworks, and NuGet dependencies
- ✅ Learn how to build, run, and test the .NET application

### Reflection Questions:
1. How did using GitHub Copilot Chat change your approach to exploring a new .NET codebase compared to manual exploration?
2. What types of questions were most effective for getting useful information about Blazor?
3. Were there any areas where GitHub Copilot's explanations needed clarification or weren't accurate?
4. **Model Comparison**: Which AI models did you try, and what differences did you notice in their responses?
5. **Model Preferences**: Did you develop preferences for certain models for specific types of questions? Why?

### Key Takeaways:
- GitHub Copilot Chat can dramatically accelerate .NET codebase onboarding
- Starting with high-level questions and drilling down works well for understanding Blazor projects
- Always verify critical build/setup instructions by actually trying them with `dotnet` commands
- Use follow-up questions to deepen understanding of unfamiliar .NET technologies
- **Different AI models excel at different tasks** - experimenting with multiple models gives you a more complete picture
- **Model selection strategy** can improve both the quality and speed of your development workflow

## 🚀 Next Steps

In the next exercise, we'll use what we've learned about the .NET codebase to start improving test coverage and implementing new features for The Daily Harvest's Blazor e-commerce platform!

#### You have successfully completed the lab. Click on **Next >>** to continue to the next lab.

![](../../media/next-page.png)
