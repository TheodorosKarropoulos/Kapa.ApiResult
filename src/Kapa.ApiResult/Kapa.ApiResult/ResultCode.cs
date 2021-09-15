namespace Kapa.ApiResult
{
    public enum ResultCode
    {
        Ok = 200,
        Created = 201,
        Accepted = 202,
        NoContent = 204,
        MovedPermanently = 301,
        TemporaryRedirect = 307,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        Conflict = 409,
        PreconditionFailed = 412,
        TooManyRequests = 429,
        InternalServerError = 500
    }
}