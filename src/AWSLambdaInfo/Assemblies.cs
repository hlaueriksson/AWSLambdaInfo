using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System.Net;
using System.Text.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaInfo;

public class Assemblies
{
    public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var result = assemblies.Except(new[] { typeof(Assemblies).Assembly }).OrderBy(x => x.FullName).Select(x => x.ToString()).ToList();

        context.Logger.LogLine($"{assemblies.Length} assemblies found");

        return new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = JsonSerializer.Serialize(result),
            Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
        };
    }
}