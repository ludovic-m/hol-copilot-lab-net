# Bonus Exercise - Browser Testing with Playwright MCP Server

#### Duration: 30 minutes

## 🎯 Learning Objectives

By the end of this exercise, you will:
- Understand how to use the Playwright MCP Server with GitHub Copilot
- Learn to automate browser testing and screenshot capture for your React application
- Use GitHub Copilot Agent mode to interact with Playwright tools
- Validate your React UI visually using automated browser testing
- Document UI behavior with automated screenshots

## 🍎 Scenario: Visual Testing for The Daily Harvest

Your QA team at The Daily Harvest has requested visual documentation of the React application's key pages and user flows. They want screenshots of:
- The home page
- The products listing page
- The shopping cart with items
- The checkout process

Instead of manually taking screenshots every time the UI changes, you'll use the Playwright MCP Server through GitHub Copilot to automate this process. This will help with:
- 📸 Visual regression testing
- 📚 Documentation for stakeholders
- 🐛 Bug reporting with visual evidence
- ✅ QA validation of new features

## 🎭 Introduction to Playwright MCP Server

The Playwright MCP Server integrates Microsoft's Playwright browser automation framework with GitHub Copilot, allowing you to:
- Control browsers (Chrome, Firefox, Safari) through natural language
- Navigate web applications and interact with elements
- Take screenshots and capture page states
- Validate UI behavior and accessibility
- Generate test automation code

### Key Capabilities:
- 🌐 **Browser Control**: Open URLs, navigate pages, click buttons
- 📸 **Screenshot Capture**: Full page, viewport, or specific element screenshots
- 🔍 **Element Interaction**: Click, type, select, hover on elements
- 📊 **Accessibility Snapshots**: Capture page structure for accessibility testing
- 🧪 **Test Automation**: Generate Playwright test code from interactions

## 💻 Step 1: Verify Playwright MCP Server Installation

Before we begin, let's ensure the Playwright MCP Server is properly installed and running.

### Instructions:

1. Click on the **Extensions** tab in VS Code
2. At the bottom of that section, look for the "MCP Servers - Installed" tab
3. Locate the **Playwright** MCP Server in the installed list
4. Click the cogwheel next to it
5. If "Start Server" is available, click it to start the server
6. If "Stop Server" and "Restart Server" are visible, the server is already running ✅

<details>
  <summary>If Playwright MCP Server is not installed</summary>
  
  1. Open [the MCP Registry](https://github.com/mcp) in a browser
  2. Find the "Playwright" Server
  3. Click "Install" → "Install in VS Code"
  4. Follow the prompts to complete installation
  5. The server should start automatically
</details>

### Verify Browser Installation:

The Playwright MCP Server may need to install browsers on first use. Open GitHub Copilot Chat in Agent mode and ask:

```
Using the Playwright MCP Server, check if browsers are installed. If not, install them.
```

This will ensure Chromium, Firefox, and WebKit browsers are available for testing.

## 🚀 Step 2: Start Your React Application

Before we can take screenshots, we need to have the application running.

### Instructions:

1. Open a new terminal in VS Code
2. Navigate to the eCommApp directory:
   ```bash
   cd eCommApp
   ```
3. Start the development server:
   ```bash
   npm run dev
   ```
4. Wait for the application to start and note the URL (typically `http://localhost:5173`)
5. Keep this terminal running in the background

## 📸 Step 3: Capture Your First Screenshot

Now let's use GitHub Copilot with the Playwright MCP Server to capture screenshots of your running application.

### Instructions:

1. Open GitHub Copilot Chat and switch to **Agent** mode
2. Use the following prompt to capture a screenshot of the home page:

```
Using the Playwright MCP Server, navigate to http://localhost:5173 and take a full-page screenshot of the home page. Save it as "homepage.png" in a "screenshots" folder.
```

3. **Click "Allow"** when GitHub Copilot asks for permission to use the Playwright tools
4. Watch as GitHub Copilot:
   - Opens a browser
   - Navigates to your application
   - Takes a screenshot
   - Saves it to the specified location

5. Once complete, check the `screenshots` folder in your workspace to see the captured image!

### 💡 What's Happening Behind the Scenes:

When you use the Playwright MCP Server through GitHub Copilot Agent:
1. Agent interprets your natural language request
2. Calls the appropriate Playwright MCP tools (like `browser_snapshot` or `browser_take_screenshot`)
3. Playwright launches a real browser instance
4. Executes the navigation and screenshot commands
5. Saves the image file to your workspace

## 🧪 Step 4: Automate Multiple Screenshots

Let's capture screenshots of all the key pages in your application in one go.

### Instructions:

Use this comprehensive prompt in Agent mode:

```
Using the Playwright MCP Server, help me document the Daily Harvest React application by taking screenshots of the following pages. Navigate to http://localhost:5173 and:

1. Take a screenshot of the home page and save it as "screenshots/01-home-page.png"
2. Navigate to the products page (/products) and take a screenshot, save as "screenshots/02-products-page.png"
3. Click on the first product to view details and take a screenshot, save as "screenshots/03-product-details.png"
4. Navigate to the cart page (/cart) and take a screenshot, save as "screenshots/04-cart-page.png"

Wait a moment between each navigation to ensure the page loads completely. Use full-page screenshots for all captures.
```

### 📊 Observe the Process:

Watch GitHub Copilot Agent as it:
- ✅ Plans the sequence of actions
- 🌐 Opens the browser once and reuses it
- 🔄 Navigates through each page systematically
- 📸 Takes each screenshot with proper naming
- 💾 Saves all images to the screenshots folder
- 📝 Reports completion status

## 🎯 Step 5: Interactive Testing with Screenshots

Now let's use Playwright to interact with the UI and capture states during user flows.

### Instructions:

Try this advanced prompt that simulates a user journey:

```
Using the Playwright MCP Server, simulate a user shopping journey in the React app at http://localhost:5173:

1. Start at the home page and take a screenshot (screenshots/journey-01-start.png)
2. Click on the "Products" navigation link
3. Take a screenshot of the products page (screenshots/journey-02-products.png)
4. Click the "Add to Cart" button on the first product
5. Take a screenshot showing the cart with the item (screenshots/journey-03-cart-with-item.png)
6. Navigate to the cart page
7. Take a final screenshot of the cart page (screenshots/journey-04-cart-page.png)

Between each action, wait 1 second for the page to update. Capture full-page screenshots.
```

### 💭 Reflection:

After running this automation, consider:
- How long would this take to do manually?
- How easy would it be to repeat this for every code change?
- Could you use this for regression testing?

## 🔍 Step 6: Accessibility Snapshot and Analysis

Playwright can also capture accessibility information from your pages. Let's use this to analyze your React application's accessibility.

### Instructions:

```
Using the Playwright MCP Server, analyze the accessibility of the Daily Harvest React application:

1. Navigate to http://localhost:5173
2. Take an accessibility snapshot of the home page
3. Analyze the snapshot and tell me:
   - Are there any images without alt text?
   - Are headings used in proper hierarchical order?
   - Are interactive elements properly labeled?
   - Any accessibility concerns to address?

Then take a regular screenshot for reference and save it as "screenshots/accessibility-homepage.png"
```

### 🎓 Understanding Accessibility Snapshots:

Unlike regular screenshots, accessibility snapshots provide:
- Semantic structure of the page
- ARIA attributes and roles
- Heading hierarchy
- Form labels and associations
- Focus order information

This is invaluable for ensuring your React application is accessible to all users!

## 🎁 Optional Task: Create a Visual Test Suite

Now that you understand how to use Playwright through GitHub Copilot, create a comprehensive visual test suite.

### Challenge:

Ask GitHub Copilot Agent to:

```
Using the Playwright MCP Server, create a comprehensive visual documentation suite for the Daily Harvest React app. For each major page (Home, Products, Product Details, Cart, Login, Admin), take:

1. A full-page screenshot in desktop view (1920x1080)
2. A mobile viewport screenshot (375x667)
3. An accessibility snapshot analysis

Save all screenshots in organized folders: screenshots/desktop/ and screenshots/mobile/

After capturing all screenshots, create a markdown report (screenshots/README.md) that:
- Lists all captured screenshots with descriptions
- Includes the accessibility analysis findings
- Suggests UI improvements based on what you observed
```

This creates a complete visual test suite that you can run before every release!

## 🤖 Step 7: Generate Playwright Test Code

Finally, let's have GitHub Copilot generate actual Playwright test code based on the interactions.

### Instructions:

```
Based on the screenshot automation we did earlier, generate a TypeScript Playwright test file that:

1. Navigates through the main pages of the React app
2. Takes screenshots at each step
3. Validates that key elements are visible (headers, buttons, products)
4. Can be run as part of our Vitest test suite

Save the test as "eCommApp/src/test/playwright/visual.spec.ts"

Include:
- Proper async/await patterns
- Page object pattern for better maintainability
- TypeScript types for better IDE support
- Comments explaining each test step
- Screenshot capture on test failures
```

This will generate actual test code you can integrate into your CI/CD pipeline!

## 📊 Step 8: Review Your Visual Documentation

Let's review what you've created.

### Instructions:

1. Open the `screenshots` folder in VS Code Explorer
2. Review all the captured images
3. Notice how they document:
   - ✅ Current state of your UI
   - ✅ User interaction flows
   - ✅ Responsive design at different viewports
   - ✅ Visual evidence for bug reports or feature demos

4. Ask GitHub Copilot to analyze the screenshots:

```
Review the screenshots we captured in the screenshots/ folder and tell me:
- Are there any visual inconsistencies?
- Do the pages follow a consistent design pattern?
- Are there any UI elements that appear broken or misaligned?
- What improvements would you suggest for the user experience?
```

## 🏆 Exercise Wrap-up

Congratulations! You've successfully used the Playwright MCP Server through GitHub Copilot to automate browser testing and visual documentation of your React application.

### What You Accomplished:
- ✅ Set up and used the Playwright MCP Server
- ✅ Automated screenshot capture of your React application
- ✅ Created visual documentation of user journeys
- ✅ Performed accessibility analysis
- ✅ Generated Playwright test code for your test suite

### Reflection Questions:

1. How could automated visual testing help your team catch UI bugs earlier?
2. What other user flows in your application would benefit from screenshot documentation?
3. How might you integrate this into your CI/CD pipeline to capture screenshots automatically on every build?
4. What advantages does using Playwright through GitHub Copilot have over writing test code manually?
5. How could accessibility snapshots improve your application's inclusivity?

### Key Takeaways:

### 🎭 Playwright + MCP + Copilot = Powerful Automation
- **Natural language control**: Describe what you want to test in plain English, GitHub Copilot translates it to Playwright commands
- **No code required upfront**: Start testing immediately without writing Playwright code
- **Learning by doing**: Watch the automation, then generate test code to understand Playwright better

### 📸 Visual Documentation Benefits
- **Stakeholder communication**: Share visual evidence of features with non-technical team members
- **Bug reports**: Include screenshots automatically when reporting issues
- **Regression testing**: Compare screenshots over time to catch unintended visual changes
- **Onboarding**: Help new developers understand the application visually

### ♿ Accessibility First
- **Automated accessibility checks**: Catch common issues before they reach production
- **Inclusive design**: Use accessibility snapshots to ensure your React app works for everyone
- **Compliance**: Document accessibility compliance for regulatory requirements

### 🔄 Integration Possibilities
- **CI/CD integration**: Run visual tests on every commit or pull request
- **Percy/Chromatic integration**: Use screenshots with visual regression testing services
- **Documentation generation**: Automatically update documentation with current screenshots
- **E2E test generation**: Convert manual flows into automated tests

## 💡 Best Practices for Playwright MCP Server Usage

### ✅ Do:
- **Wait for page loads**: Always include appropriate waits between actions
- **Use descriptive filenames**: Name screenshots clearly (e.g., `cart-with-items.png` not `test1.png`)
- **Organize screenshots**: Use folders to organize by feature, test, or date
- **Test multiple viewports**: Capture both desktop and mobile views
- **Document your process**: Keep notes on what each screenshot represents

### ❌ Don't:
- **Don't skip waits**: Pages need time to load, especially React SPAs with async data fetching
- **Don't overwrite important screenshots**: Use unique names or timestamps
- **Don't ignore accessibility**: Always review accessibility snapshots
- **Don't forget cleanup**: Remove old screenshots periodically
- **Don't hardcode URLs**: Use environment variables for flexibility

## 🔮 Next Steps

Now that you've mastered using the Playwright MCP Server with GitHub Copilot, consider:

1. **Set up automated visual regression testing** using tools like Percy or Chromatic
2. **Create a screenshot gallery** in your project README to showcase features
3. **Integrate Playwright tests** into your CI/CD pipeline for automated testing
4. **Build a component library** with visual documentation of all UI components
5. **Implement visual testing** as part of your code review process

### Additional Resources:

- [Playwright Documentation](https://playwright.dev/)
- [Playwright MCP Server GitHub](https://github.com/mcp/playwright)
- [React Testing Best Practices](https://react.dev/reference/react/test-utils)
- [Vitest Playwright Integration](https://vitest.dev/guide/browser.html)
- [GitHub Copilot MCP Documentation](https://docs.github.com/en/copilot/using-github-copilot/using-extensions/using-mcp-servers)

## 🎉 Bonus Challenge: Build a Visual Testing Dashboard

Try this advanced challenge:

```
Using GitHub Copilot Agent with Playwright MCP Server, create a complete visual testing dashboard:

1. Take screenshots of all pages at 3 different viewport sizes (mobile, tablet, desktop)
2. Generate an HTML report page that displays all screenshots in a grid
3. Include timestamps and page metadata for each screenshot
4. Add navigation to jump between different pages
5. Highlight any accessibility issues found

Save the dashboard as "screenshots/dashboard.html" and automatically open it in the browser.
```

This creates a beautiful, self-contained visual test report you can share with your entire team!

---

#### You have successfully completed the bonus lab! 🎭📸

![](../../media/next-page.png)
