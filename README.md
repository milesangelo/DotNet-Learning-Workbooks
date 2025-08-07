# 🔧 Zero to Hero: C# for Mechanics

> **"You've spent years diagnosing problems and using the right tool for the job. Programming is the same game with different tools."**

## 🎯 What Is This?

A hands-on, mechanic-minded approach to learning C# programming. This course is designed specifically for someone transitioning from mechanical work to software development. Every concept is explained through the lens of tools, systems, and diagnostics you already understand.

## 🏁 Quick Start

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed
- [Visual Studio Code](https://code.visualstudio.com/) with C# extension
- A willingness to break things and fix them

### Setup (30 seconds)

**Windows:**
```bash
setup.bat
```

**Mac/Linux:**
```bash
chmod +x setup.sh
./setup.sh
```

**Manual Setup:**
```bash
dotnet build ZeroToHeroCSharp.sln
```

### Run Your First Exercise

1. Open this folder in VS Code
2. Navigate to `01-VariablesAndTypes/Exercise1_Broken.cs`
3. Press `F5` to run (it will have errors - that's the point!)
4. Fix the errors one by one
5. Check your work against `Exercise1_Fixed.cs`

## 📚 Course Structure

### Phase 1: Foundation (The Basic Tools)
- **Module 01: Variables & Types** - Your storage bins for data
- **Module 02: Conditionals** - Your diagnostic flowcharts
- **Module 03: Loops** - Your torque patterns

### Phase 2: Organization (The Toolbox)
- **Module 04: Methods** - Your specialized tools
- **Module 05: DRY Refactoring** - Organizing your toolbox

### Phase 3: Structure (The System)
- **Module 06: Classes & Objects** - Blueprints and actual cars
- **Module 07: Collections** - Your parts inventory

### Phase 4: Advanced (Specialty Equipment)
- **Module 08: Enums & Switch** - Standardized codes
- **Module 09: Error Handling** - Safety protocols

## 🎓 Learning Philosophy

### The Three Rules

1. **Read the Errors** - They're diagnostic codes. Don't skip them.
2. **Start Simple** - You wouldn't rebuild an engine before changing oil.
3. **Test Often** - Run your code like you'd test-fire an engine.

### Exercise Types

Each module contains:
- 🔴 **Broken Code** - Fix compiler errors and bugs
- 🐛 **Debug Challenges** - Find and fix logic problems
- 🧹 **Refactor Practice** - Make messy code clean
- 🏗️ **Build From Scratch** - Create something new
- ✅ **Solutions** - Check your work (but try first!)

## 🛠️ Development Workflow

### VS Code Shortcuts
- `F5` - Run the current project
- `Ctrl+Shift+B` - Build without running
- `Ctrl+` ` - Open terminal
- `Ctrl+Shift+P` - Command palette

### Debugging Tips
1. **Read errors top to bottom** - Fix the first one first
2. **One change at a time** - Like diagnosing one system at a time
3. **Use breakpoints** - `F9` to set, `F5` to run, `F10` to step
4. **Print everything** - `Console.WriteLine()` is your multimeter

## 💡 Mental Models

### Variables = Storage Bins
```csharp
int boltCount = 42;        // Bin for counting
string partNumber = "AB-123";  // Bin for labels
double pressure = 32.5;    // Bin for measurements
bool engineRunning = true; // Bin for on/off states
```

### Methods = Tools
```csharp
// A tool that does one specific job
double CalculateLabor(double hours, double rate)
{
    return hours * rate;
}
```

### Classes = Service Manuals
```csharp
// Blueprint for a vehicle
class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}
```

## 📈 Progress Tracking

- [ ] Module 01: Variables & Types (2-3 hours)
- [ ] Module 02: Conditionals (3-4 hours)
- [ ] Module 03: Loops (3-4 hours)
- [ ] Module 04: Methods (4-5 hours)
- [ ] Module 05: DRY Refactoring (3-4 hours)
- [ ] Module 06: Classes & Objects (5-6 hours)
- [ ] Module 07: Collections (4-5 hours)
- [ ] Module 08: Enums & Switch (3-4 hours)
- [ ] Module 09: Error Handling (4-5 hours)
- [ ] Final Project A: Auto Shop System
- [ ] Final Project B: Diagnostic Reader

## 🔥 Common Beginner Mistakes

1. **Rushing through exercises** - Speed comes with practice
2. **Not reading error messages** - They tell you exactly what's wrong
3. **Copy-pasting without understanding** - Type it out, build muscle memory
4. **Avoiding what's hard** - The hard stuff is where growth happens
5. **Not asking "why"** - Understanding > memorization

## 📖 Additional Resources

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [C# Player's Guide](https://csharpplayersguide.com/) - Great beginner book
- [Stack Overflow](https://stackoverflow.com/questions/tagged/c%23) - Where devs help devs
- [r/learncsharp](https://www.reddit.com/r/learncsharp/) - Supportive community

## 🤝 Getting Help

When you're stuck:
1. **Read the error message** - What line? What's it saying?
2. **Check the solutions** - But only after trying
3. **Break it smaller** - Can you fix just one part?
4. **Google the error** - Someone else had this problem
5. **Take a break** - Fresh eyes see better

## 💭 Remember

> **"Every expert was once a beginner. The difference is they kept turning the wrench until it clicked."**

You're not learning to code - you're adding programming to your existing problem-solving toolkit. The systematic thinking that makes you a good mechanic will make you a great developer.

---

**Ready?** Start with [Module 01: Variables & Types](01-VariablesAndTypes/README.md) 🔧
