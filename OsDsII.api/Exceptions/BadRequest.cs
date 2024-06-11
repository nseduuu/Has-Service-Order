using System.Net;

namespace OsDsII.api.Exceptions
{
    public class BadRequest : BaseException
    {
        public BadRequest(string message) :
        base
            (
                "HSO-001", // código identificador de erros // 0 - 400 , 1 - 500, 2 - 200
                message,
                HttpStatusCode.Conflict,
                StatusCodes.Status400BadRequest,
                null,
                DateTimeOffset.UtcNow,
                null
            )
        { }

    }
}
