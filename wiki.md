**Polyverse — Learning C# for Unity (Start Here)**

This repository is a lightweight starting point for learning C# with the dotnet CLI and modern editors before moving into Unity. The goal is simple: get comfortable writing, building, and running a C# "Hello World" console app using the `dotnet` CLI, `VS Code`, and `Visual Studio Community 2026`.

**Prerequisites**
- **dotnet SDK:** Install a recent .NET SDK that supports console apps (6.0, 7.0, or later). Verify with `dotnet --version`.
- **VS Code:** Install Visual Studio Code and the C# extension by Microsoft.
- **Visual Studio Community 2026 (optional):** Full-featured IDE recommended for later Unity workflows and debugging.
- **Terminal:** This guide uses the `bash` shell commands (Windows: `bash.exe` / WSL works fine).

**Quick Verification**
- Check the dotnet SDK is installed:

```bash
dotnet --version
```

If this prints a version (e.g., `7.0.x`), you're ready.

**Create Your First HelloWorld Project (dotnet CLI)**
1. Open a terminal in the project folder and run:

```bash
dotnet new console -n HelloWorld
cd HelloWorld
```

2. (Optional) Create a solution and add the project so Visual Studio opens nicely:

```bash
dotnet new sln -n HelloWorld
dotnet sln add HelloWorld/HelloWorld.csproj
```

3. Open the project in VS Code:

```bash
code .
```

4. Build and run with the dotnet CLI:

```bash
dotnet run --project HelloWorld
```

You should see "Hello, World!" printed to the console.

**HelloWorld Example Code**
Replace the contents of `Program.cs` with the following (explicit `Main` for clarity):

```csharp
using System;

namespace HelloWorldApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}
```

Notes: Newer SDKs support top-level statements (shorter programs), but seeing the full `Main` signature helps when transitioning to Unity and larger C# projects.

**Using VS Code Effectively**
- Install the **C#** extension (by Microsoft) for IntelliSense, debugging, and project support.
- Use the Run and Debug view to create a launch configuration or simply use `dotnet run` from the terminal.
- Use `Ctrl+Shift+P` → `OmniSharp: Restart OmniSharp` if intellisense isn't working.

**Using Visual Studio Community 2026**
- Open the generated `.sln` file with Visual Studio Community 2026 for a full-featured debugger and Unity integration later.
- Visual Studio will automatically detect and restore NuGet packages and build configurations.

**Why start with dotnet CLI before Unity?**
- Unity uses C# for scripting but has its own runtime and engine API. Learning core C# concepts and dotnet tooling first (projects, building, debugging, classes, OOP) makes Unity scripting much easier.

**Next Learning Steps (suggested order)**
- **Language basics:** variables, types, operators, control flow (`if`, `switch`, loops).
- **Data structures:** arrays, lists, dictionaries.
- **Functions & methods:** parameters, return values, overloading.
- **Classes & OOP:** fields, properties, constructors, inheritance, interfaces.
- **Async basics:** `async` / `await` (useful for game tasks like loading resources).
- **Unit small projects:** simple math library, text-based game loop, input/output handling.

**Transitioning to Unity (brief)**
- Install Unity Hub and a Unity Editor version. Unity projects contain their own solution and project files; scripts are plain C# files.
- Use Visual Studio Community or VS Code as the script editor. Unity will compile scripts using its own pipeline — learning C# fundamentals first reduces friction.

**Troubleshooting Tips**
- If `dotnet` isn't found: ensure the SDK is installed and added to your PATH. Restart the terminal after installing.
- If IntelliSense fails in VS Code: ensure the C# extension is installed and OmniSharp is running.
- If you see runtime version issues: check the SDK version with `dotnet --info` and target appropriate frameworks in the `.csproj`.

**Resources & References**
- Practice small console apps until you are comfortable with classes and OOP.
- When ready, open a new Unity project and recreate small exercises (e.g., printing messages, basic input handling) inside Unity scripts.

**Contributing / Notes**
- This `wiki.md` is the initial entrypoint for learning C# in this repository. Feel free to extend it with step-by-step tutorials, links to sample projects, or a small exercises folder.

---

If you want, I can also scaffold the `HelloWorld` project inside this repo, add the `.sln`, and open a minimal VS Code launch configuration. Tell me if you'd like me to create those files now.

