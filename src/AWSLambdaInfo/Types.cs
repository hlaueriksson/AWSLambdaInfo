using Amazon.Lambda.Annotations.APIGateway;
using Amazon.Lambda.Annotations;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

namespace AWSLambdaInfo;

public class Types
{
    [LambdaFunction(Policies = "AWSLambdaBasicExecutionRole", MemorySize = 256, Timeout = 30)]
    [RestApi(LambdaHttpMethod.Get, "/Types")]
    public IHttpResult Get(APIGatewayProxyRequest request, ILambdaContext context)
    {
        var fullName = request.QueryStringParameters.FirstOrDefault(q => string.Compare(q.Key, "FullName", StringComparison.OrdinalIgnoreCase) == 0).Value;
        var name = request.QueryStringParameters.FirstOrDefault(q => string.Compare(q.Key, "Name", StringComparison.OrdinalIgnoreCase) == 0).Value;

        if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, context);

        if (!string.IsNullOrEmpty(name)) return ByName(name, context);

        return HttpResults.BadRequest();
    }

    private static IHttpResult ByFullName(string fullName, ILambdaContext context)
    {
        var result = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .SkipExceptions()
            .Where(x => x.FullName == fullName)
            .OrderBy(x => x.Assembly.FullName)
            .Select(x => x.Assembly.ToString())
            .ToList();

        context.Logger.LogLine($"{fullName} was found in {result.Count} assemblies");

        if (result.Any()) return HttpResults.Ok(result);

        return HttpResults.NotFound();
    }

    private static IHttpResult ByName(string name, ILambdaContext context)
    {
        var result = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .SkipExceptions()
            .Where(x => x.Name == name)
            .OrderBy(x => x.Assembly.FullName)
            .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
            .ToList();

        context.Logger.LogLine($"{name} matched {result.Count} types");

        if (result.Any()) return HttpResults.Ok(result);

        return HttpResults.NotFound();
    }
}

internal static class Extensions
{
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
