# Summary

This guide content the step-by-step to help you re-create similar project structure like this one.

## Prerequisite Tools

## How does these project got created?

To recreate this same project structure, make sure you've all the prerequisite tools installed and execute the following commands

1. Create the Minimal API ASP.NET6 C# Lambda Function

    ```bash
    mkdir apps
    cd apps
    dotnet new serverless.AspNetCoreMinimalAPI -o ./ --name FunctionOne
    dotnet new serverless.AspNetCoreMinimalAPI -o ./ --name FunctionTwo
    dotnet new serverless.AspNetCoreMinimalAPI -o ./ --name FunctionThree
    cd ..
    ```

1. Create the .NET CDK project for Infrastructure as Code

    ```bash
    cd infra
    cdk init app --language=csharp
    cd ..
    ```

1. Create the Visual Studio Solution file and add the Apps and Infra projects to the Solution

    ```bash
    dotnet new sln --name DemoSolution
    dotnet sln add DemoSolution.sln ./apps/src/FunctionOne/FunctionOne.csproj 
    dotnet sln add DemoSolution.sln ./apps/src/FunctionTwo/FunctionTwo.csproj
    dotnet sln add DemoSolution.sln ./apps/src/FunctionThree/FunctionThree.csproj
    dotnet sln add DemoSolution.sln ./infra/src/Infra/Infra.csproj
    ```
