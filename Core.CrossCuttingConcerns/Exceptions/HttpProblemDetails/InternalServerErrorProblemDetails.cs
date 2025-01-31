﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class InternalServerErrorProblemDetails : ProblemDetails
{
    public InternalServerErrorProblemDetails(string detail)
    {
        Title = "Internal Server Error";
        Detail = "Internal Server Error";
        Status = StatusCodes.Status500InternalServerError;
        Type = "Https://example.com/probs/internal";
    }
}
