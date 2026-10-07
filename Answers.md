1- <Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net10.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <Nullable>enable</Nullable>
    </PropertyGroup>

</Project>.

2- Do #region / #endregion change the compiled output?
No. #region and #endregion are only used to organize and collapse code in the IDE. They do not affect the compiled output,
but they can make large files easier to navigate and understand.

3- When would you use /// XML documentation comments instead of //?
Use /// when you want to document a public class, method, property, or API. 
The compiler/IDE can use these comments to generate XML documentation and show information in IntelliSense.

4- Why does C# have no true global variables, and what's the closest equivalent?
   C# avoids true global variables to reduce global state, which can make code harder to maintain, test, and understand.
   The closest equivalent is a static field/property inside a class