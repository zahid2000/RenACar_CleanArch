using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ProblemDetailsExtension
{
    public static string AsJson<TProblemDetails>(this TProblemDetails problemDetails)
        where TProblemDetails : ProblemDetails=>JsonSerializer.Serialize(problemDetails);
}
