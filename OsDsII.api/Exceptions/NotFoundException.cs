﻿using System.Net;

namespace OsDsII.api.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message) :
        base
            (
                "HSO-002", // código identificador de erros // 0 - 400 , 1 - 500, 2 - 200
                message,
                HttpStatusCode.Conflict,
                StatusCodes.Status404NotFound,
                null,
                DateTimeOffset.UtcNow,
                null
            )
        { }

    }
}
