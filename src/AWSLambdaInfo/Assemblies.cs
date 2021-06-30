using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambdaInfo
{
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
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }
    }
}