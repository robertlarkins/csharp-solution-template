# csharp-solution-template
Base template for a C# solution.


# Root Level Files
The following are descriptions of the files found at the root of the solution.

## .editorconfig
Enforces consistent coding styles for the solution, and takes precedence over the Visual Studio editor settings.

## .gitignore
Specifies which files should be untracked by Git version control.

## Directory.Build.props
Base settings that are automatically applied to all projects in the solution.

Recommended settings include:
```xml
<!-- The default framework targeted for this solution. -->
<TargetFramework>net5.0</TargetFramework>

<!-- Turns on Nullable Reference Types, available from C#8. -->
<Nullable>enable</Nullable>

<!-- Warnings are treated as errors so solution will only compile once they are fixed. -->
<TreatWarningsAsErrors>true</TreatWarningsAsErrors>

<!-- Global ruleset shared by all projects. -->
<CodeAnalysisRuleSet>$(MSBuildThisFileDirectory)global.ruleset</CodeAnalysisRuleSet>

<!-- Each project will generate a documentation file, which is necessary for some analyzers. -->
<GenerateDocumentationFile>true</GenerateDocumentationFile>
```

Other possible options:
```xml
<!-- The version of the C# language to use. -->
<LangVersion>9.0</LangVersion>
```

__Variables__:
 - `$(MSBuildThisFileDirectory)` references the directory containing the current MSBuild file.
 - `$(MSBuildProjectDirectory)` references the directory containing the project being built.

__Further Reading__:
 - [Build Customisation](https://docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build)
 - [Framework Targetting](https://docs.microsoft.com/en-us/dotnet/standard/frameworks)
 - [Nullable Contexts](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references#nullable-contexts)
 - [Compiler Options](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options)
 - [Language Versioning](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version)

### StyleCop Analyzer ItemGroup
Specifies the build settings for the [StyleCop Analyzer](https://github.com/DotNetAnalyzers/StyleCopAnalyzers).

__Further Reading__:
 - [Documentation](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/DotNetCli.md)
 - [Dependency Assets](https://docs.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files#controlling-dependency-assets)

## global.ruleset
Specifies the analyzer rules to apply to the solution at a global level, including their severity.

## README.md
This file.

Describe what should go in this file.

## stylecop.json
StyleCop configuration file. These configurations allow the behaviour of certain rules to be fine-tuned.

__Further Reading__:
 - [Documentation](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/Configuration.md#getting-started-with-stylecopjson)

