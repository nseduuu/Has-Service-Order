using System.Net;

namespace OsDsII.api.Exceptions
{
    public class NoContentException : BaseException
    {
        public NoContentException(string message) :
        base
            (
                "HSO-200", // código identificador de erros // 0 - 400 , 1 - 500, 2 - 200
                message,
                HttpStatusCode.NoContent,
                StatusCodes.Status204NoContent,
                null,
                DateTimeOffset.UtcNow,
                null
            )
        { }
    }
}
