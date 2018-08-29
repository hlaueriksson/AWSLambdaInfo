# AWSLambdaInfo

[![Build Status](https://img.shields.io/appveyor/ci/hlaueriksson/awslambdainfo.svg?style=flat-square)](https://ci.appveyor.com/project/hlaueriksson/awslambdainfo)

> Information gathered on AWS Lambda by executing AWS Lambda

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

The information gathered are from the `dotnetcore2.1` runtime version.

This project was created with [AWS Toolkit for Visual Studio](https://aws.amazon.com/visualstudio/)

## Assemblies

> Get information about available `Assemblies` and their version

* https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Assemblies

> 30 assemblies found

```json
[
    "Amazon.Lambda.APIGatewayEvents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604",
    "Amazon.Lambda.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604",
    "Amazon.Lambda.Serialization.Json, Version=1.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604",
    "Anonymously Hosted DynamicMethods Assembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Bootstrap, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
    "Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed",
    "System.Collections, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Console, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Dynamic.Runtime, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Globalization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IO, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IO.FileSystem, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Linq.Expressions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e",
    "System.Private.Uri, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Private.Xml, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Private.Xml.Linq, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Reflection, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Extensions, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Loader, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Serialization.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.RegularExpressions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Xml.XDocument, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
]
```

## Type

> Get information about available `Types` and what `Assembly` they belong to

### FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

* https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Type?FullName={FullName}

Example: https://j3uf3rsgd4.execute-api.eu-central-1.amazonaws.com/Prod/Type?FullName=Amazon.Lambda.Serialization.Json.JsonSerializer

> Amazon.Lambda.Serialization.Json.JsonSerializer was found in 1 assemblies

```json
[
    "Amazon.Lambda.Serialization.Json, Version=1.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604"
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
