﻿namespace OpenApiGenerator.UnitTests;

public partial class NamingTests
{
    [TestMethod]
    public void ArrayItems()
    {
        var models = PrepareModels(@"openapi: 3.0.1
info:
    title: OpenAI API
    description: The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
    termsOfService: https://openai.com/policies/terms-of-use
    contact:
        name: OpenAI Support
        url: https://help.openai.com/
    license:
        name: MIT
        url: https://github.com/openai/openai-openapi/blob/master/LICENSE
    version: '2.3.0'
paths:
    /fake/fake:
        post:
            operationId: createChatCompletion
            responses:
                '200':
                    description: OK
components:
    schemas:
        CreateCompletionResponse:
            required:
                - choices
            type: object
            properties:
                choices:
                    type: array
                    items:
                        required:
                            - finish_reason
                            - index
                            - logprobs
                            - text
                        type: object
                        properties:
                            finish_reason:
                                enum:
                                    - stop
                                    - length
                                    - content_filter
                                type: string
                                description: ""The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,\n`length` if the maximum number of tokens specified in the request was reached,\nor `content_filter` if content was omitted due to a flag from our content filters.\n""
                            index:
                                type: integer
                            logprobs:
                                type: object
                                properties:
                                    text_offset:
                                        type: array
                                        items:
                                            type: integer
                                    token_logprobs:
                                        type: array
                                        items:
                                            type: number
                                    tokens:
                                        type: array
                                        items:
                                            type: string
                                    top_logprobs:
                                        type: array
                                        items:
                                            type: object
                                            additionalProperties:
                                                type: number
                                nullable: true
                            text:
                                type: string
");
        
        models.Select(x => x.ClassName).Should().BeEquivalentTo([
            "CreateCompletionResponse",
            "CreateCompletionResponseChoice",  // Optimized
            "CreateCompletionResponseChoiceFinishReason",
            "CreateCompletionResponseChoiceLogprobs",
            "CreateCompletionResponseChoiceLogprobsTopLogprob"  // Optimized
        ]);
    }
}