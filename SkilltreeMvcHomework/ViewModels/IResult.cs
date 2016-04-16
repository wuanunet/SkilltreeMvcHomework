using System;
using System.Collections.Generic;

namespace SkilltreeMvcHomework.ViewModels
{
    public interface IResult
    {
        Guid Id { get; }

        bool Success { get; set; }

        string Message { get; set; }

        string ResponseData { get; set; }

        Exception Exception { get; set; }

        List<IResult> InnerResults { get; }
    }
}