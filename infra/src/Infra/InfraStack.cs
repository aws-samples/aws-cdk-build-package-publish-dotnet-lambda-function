using Amazon.CDK;
using Constructs;
using Amazon.CDK.AWS.APIGateway;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.Logs;

namespace Infra
{
    public class InfraStack : Stack
    {
        internal InfraStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {

            var lambdaFunctionOne = new Function(this, "my-funcOne", new FunctionProps
            {
                Runtime = Runtime.DOTNET_6,
                MemorySize = 128,
                LogRetention = RetentionDays.ONE_DAY,
                Handler = "FunctionOne",
                Code = Code.FromAsset("/tmp/FunctionOne.zip")
            });

            var lambdaFunctionTwo = new Function(this, "my-funcTwo", new FunctionProps
            {
                Runtime = Runtime.DOTNET_6,
                MemorySize = 128,
                LogRetention = RetentionDays.ONE_DAY,
                Handler = "FunctionTwo",
                Code = Code.FromAsset("/tmp/FunctionTwo.zip")
            });

            var lambdaFunctionThree = new Function(this, "my-funcThree", new FunctionProps
            {
                Runtime = Runtime.DOTNET_6,
                MemorySize = 128,
                LogRetention = RetentionDays.ONE_DAY,
                Handler = "FunctionThree",
                Code = Code.FromAsset("/tmp/FunctionThree.zip")
            });

            //Proxy all request from the root path "/" to Lambda Function One
            var restAPI = new LambdaRestApi(this, "Endpoint", new LambdaRestApiProps
            {
                Handler = lambdaFunctionOne,
                Proxy = true,
            });

            //Proxy all request from path "/functiontwo" to Lambda Function Two
            var apiFunctionTwo = restAPI.Root.AddResource("functiontwo", new ResourceOptions
            {
                DefaultIntegration = new LambdaIntegration(lambdaFunctionTwo)
            });
            apiFunctionTwo.AddMethod("ANY");
            apiFunctionTwo.AddProxy();

            //Proxy all request from path "/functionthree" to Lambda Function Three
            var apiFunctionThree = restAPI.Root.AddResource("functionthree", new ResourceOptions
            {
                DefaultIntegration = new LambdaIntegration(lambdaFunctionThree)
            });
            apiFunctionThree.AddMethod("ANY");
            apiFunctionThree.AddProxy();

            new CfnOutput(this, "apigwtarn", new CfnOutputProps { Value = restAPI.ArnForExecuteApi() });
        }
    }
}
