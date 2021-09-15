using System;

namespace Kapa.ApiResult
{
    public interface IApiResult<T>
    {
        T Data {get;}
        int EventId {get;}
        ResultCode ResultCode {get;}
        string ErrorText {get;}
        bool Success {get;}
    }
}