using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System.Net;
using System.Text.Json;

namespace AWSLambdaInfo;

public class Type
{
    public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
    {
        var fullName = request.QueryStringParameters.FirstOrDefault(q => string.Compare(q.Key, "FullName", StringComparison.OrdinalIgnoreCase) == 0).Value;
        var name = request.QueryStringParameters.FirstOrDefault(q => string.Compare(q.Key, "Name", StringComparison.OrdinalIgnoreCase) == 0).Value;

        if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, context);

        if (!string.IsNullOrEmpty(name)) return ByName(name, context);

        return HttpStatusCode.BadRequest.ToResponse();
    }

    private static APIGatewayProxyResponse ByFullName(string fullName, ILambdaContext context)
    {
        var result = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .SkipExceptions()
            .Where(x => x.FullName == fullName)
            .OrderBy(x => x.Assembly.FullName)
            .Select(x => x.Assembly.ToString())
            .ToList();

        context.Logger.LogLine($"{fullName} was found in {result.Count} assemblies");

        if (result.Any()) return result.ToOkResponse();

        return HttpStatusCode.NotFound.ToResponse();
    }

    private static APIGatewayProxyResponse ByName(string name, ILambdaContext context)
    {
        var result = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .SkipExceptions()
            .Where(x => x.Name == name)
            .OrderBy(x => x.Assembly.FullName)
            .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
            .ToList();

        context.Logger.LogLine($"{name} matched {result.Count} types");

        if (result.Any()) return result.ToOkResponse();

        return HttpStatusCode.NotFound.ToResponse();
    }
}

internal static class Extensions
{
    internal static APIGatewayProxyResponse ToOkResponse(this object result)
    {
        return new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = JsonSerializer.Serialize(result),
            Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
        };
    }

    internal static APIGatewayProxyResponse ToResponse(this HttpStatusCode statusCode)
    {
        return new APIGatewayProxyResponse { StatusCode = (int)statusCode };
    }

    internal static IEnumerable<T> SkipExceptions<T>(this IEnumerable<T> values)
    {
        using (var enumerator = values.GetEnumerator())
        {
            var next = true;
            while (next)
            {
                try
                {
                    next = enumerator.MoveNext();
                }
                catch
                {
                    continue;
                }

                if (next) yield return enumerator.Current;
            }
        }
    }
}