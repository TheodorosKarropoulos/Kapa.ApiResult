namespace Kapa.ApiResult
{
    public class ApiResult<T> : IApiResult<T>
    {
        public T Data {get;set;}

        public int EventId {get;set;}

        public ResultCode ResultCode {get;set;}

        public string ErrorText {get;set;}

        public bool Success => ResultCode == ResultCode.Ok;

        public static IApiResult<T> CreateFailed(ResultCode resultCode, string errorText, int eventId)
        {
            return new ApiResult<T>
            {
                ResultCode = resultCode,
                EventId = eventId,
                ErrorText = errorText
            };
        }

        public static IApiResult<T> CreateFailed(ResultCode resultCode, string errorText)
        {
            return CreateFailed(resultCode, errorText, 0);
        }

        public static IApiResult<T> CreateFailed(IApiResult<T> result)
        {
            return CreateFailed(result.ResultCode, result.ErrorText);
        }

        public static IApiResult<T> CreateFailed<TResult>(IApiResult<TResult> result)
        {
            return CreateFailed(result.ResultCode, result.ErrorText, result.EventId);
        }

        public static IApiResult<T> CreateSuccesful(T data)
        {
            return new ApiResult<T>
            {
                Data = data,
                ResultCode = ResultCode.Ok
            };
        }
    }
}