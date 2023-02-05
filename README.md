# AWSLambdaInfo

[![build](https://github.com/hlaueriksson/AWSLambdaInfo/actions/workflows/build.yml/badge.svg)](https://github.com/hlaueriksson/AWSLambdaInfo/actions/workflows/build.yml)

> Information gathered on AWS Lambda by executing AWS Lambda

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

The information gathered are from the `net6.0` runtime version.

This project was created with [AWS Toolkit for Visual Studio](https://aws.amazon.com/visualstudio/)

## Assemblies

> Get information about available `Assemblies` and their version

* https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Assemblies

> 38 assemblies found

```json
[
    "Amazon.Lambda.APIGatewayEvents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604",
    "Amazon.Lambda.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604",
    "Amazon.Lambda.RuntimeSupport, Version=1.7.0.0, Culture=neutral, PublicKeyToken=null",
    "Amazon.Lambda.Serialization.SystemTextJson, Version=0.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604",
    "Anonymously Hosted DynamicMethods Assembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Microsoft.Win32.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Concurrent, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Diagnostics.DiagnosticSource, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Diagnostics.Tracing, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq.Expressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Memory, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Net.Http, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.NameResolution, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Security, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Sockets, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Numerics.Vectors, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e",
    "System.Private.Uri, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Emit.ILGeneration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Emit.Lightweight, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices.RuntimeInformation, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Intrinsics, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Runtime.Loader, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Serialization.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.Encoding.Extensions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.Encodings.Web, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Text.Json, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Threading, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Thread, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.ThreadPool, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
]
```

## Type

> Get information about available `Types` and what `Assembly` they belong to

### FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

* https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Type?FullName={FullName}

Example: https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Type?FullName=Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer

> Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer was found in 1 assemblies

```json
[
    "Amazon.Lambda.Serialization.SystemTextJson, Version=0.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604"
]
```

### Name

Query by:

> The simple name of the type

* https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Type?Name={Name}

Example: https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Type?Name=ILambdaContext

> ILambdaContext matched 1 types

```json
[
    {
        "Type": "Amazon.Lambda.Core.ILambdaContext",
        "Assembly": "Amazon.Lambda.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604"
    }
]
```
