# Build, package, and publish .NET C# Lambda functions with the AWS CDK

This Repository contents sample source code that shows how to streamline building, packaging, and publishing .NET Lambda functions using AWS CDK with C#.

## Implementation and Deployment

**Prerequisites:**

1. [Visual Studio Code](https://code.visualstudio.com/download) (or your preferred IDE).
1. [AWS account](aws.amazon.com/).
1. [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet)
1. AWS Cloud Development Kit (CDK) (<https://docs.aws.amazon.com/cdk/v2/guide/getting_started.html>).
1. GIT (<https://git-scm.com/download>).
1. Docker

To learn how to implement CDK C# to build, package and publish lambda code follow the implementation on the file [infra/src/Infra/InfraStack.cs](infra/src/Infra/InfraStack.cs).

Execute the following commands to deploy and test the solution

**Deploy:**

```bash
cd /infra
cdk deploy --profile <your AWS account profile alias>
```

**Test:**

Once the deployment is complete, copy the endpoint from the terminal output and make HTTP GET Request. The format of the endpoint should be similar to https://xxxyyyzzz.execute-api.us-east-1.amazonaws.com/prod/.

```bash
curl https://xxxyyyzzz.execute-api.us-west-2.amazonaws.com/prod/
curl https://xxxyyyzzz.execute-api.us-west-2.amazonaws.com/prod/functiontwo
curl https://xxxyyyzzz.execute-api.us-west-2.amazonaws.com/prod/functionthree                                                             
```

## References

To learn more about the implementation read the blog post [Build, package, and publish .NET C# Lambda functions with the AWS CDK](https://aws-blogs-prod.amazon.com/modernizing-with-aws/build-package-pu…unctions-aws-cdk)

## Security

See [CONTRIBUTING](CONTRIBUTING.md#security-issue-notifications) for more information.

## License

This library is licensed under the MIT-0 License. See the LICENSE file.
