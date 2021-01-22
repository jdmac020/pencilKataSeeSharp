# Solution Details

This is a simple "class library/test project" solution to allow anyone to immediately start the [Pencil Durability Kata](./PencilDurabilityKata.md)

## Stack Details

Both projects are .NET Core class libraries targeting .NET 5.

`Desk.Tests` has the NuGet packages for xUnit and Shouldly installed.

## Structure

Production code goes into the `Desk` project. Tests go into `Desk.Tests`.

No pre-defined classes are provided to allow the most flexible thinking.

## Running

The solution was created using the [dotnet CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/) and VS Code.

`dotnet build` from `<repositoryRoot>/PencilKataSeeSharp/` should build and restore the project.

If preferred, Visual Studio or Rider should handle this with zero complaints.
