﻿using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public class ClientTests :
    VerifyBase
{
    private Settings DefaultSettings => new(
        TargetFramework: "netstandard2.0",
        Namespace: "G",
        ClassName: "Api",
        NamingConvention: default,
        JsonSerializerType: default,
        UseRequiredKeyword: default,
        GenerateConstructors: false,
        GroupByTags: true,
        GenerateMethods: false,
        MethodNamingConvention: default,
        MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
        GenerateMethodsAsHttpClientExtensions: false,
        GenerateMethodsUsingSystemNetHttpJson: false,
        IncludeOperationIds: [],
        ExcludeOperationIds: [],
        IncludeTags: [],
        ExcludeTags: [],
        JsonSerializerContext: string.Empty,
        GenerateSuperTypeForJsonSerializerContext: false,
        GenerateModels: false,
        ModelStyle: default,
        IncludeModels: [],
        ExcludeModels: [],
        GenerateSdk: true
    );

    private Task VerifyAsync(
        ImmutableArray<EndPoint> endPoints,
        [CallerMemberName] string? callerName = null)
    {
        return Verify(endPoints)
                .UseDirectory($"Snapshots/Clients/{callerName}")
                .UseFileName("_")
                //.AutoVerify()
            ;
    }

    [TestMethod]
    public Task OpenAi()
    {
        var yaml = H.Resources.openai_yaml.AsString();
        var settings = DefaultSettings with
        {
            //IncludeModels = ["CreateCompletionResponse"],
        };

        var (_, methods, _) = Data.Prepare((yaml, settings));

        return VerifyAsync(methods);
    }

    [TestMethod]
    public Task Ollama()
    {
        var yaml = H.Resources.ollamacurated_yaml.AsString();
        var settings = DefaultSettings;

        var (_, methods, _) = Data.Prepare((yaml, settings));

        return VerifyAsync(methods);
    }

    [TestMethod]
    public Task Replicate()
    {
        var (_, methods, _) = Data.Prepare((H.Resources.replicate_json.AsString(), DefaultSettings with
        {
            MethodNamingConvention = MethodNamingConvention.OperationIdWithDots,
        }));

        return VerifyAsync(methods);
    }

    // [TestMethod]
    // public Task GitHub()
    // {
    //     var yaml = H.Resources.api_github_com_yaml.AsString();
    //     var settings = DefaultSettings;
    //
    //     var models = ClientGeneratorMethods.PrepareData((yaml, settings));
    //
    //     return VerifyAsync(models);
    // }

    [TestMethod]
    public Task SpecialCases()
    {
        var yaml = H.Resources.specialcases_yaml.AsString();
        var settings = DefaultSettings;

        var (_, methods, _) = Data.Prepare((yaml, settings));

        return VerifyAsync(methods);
    }
}