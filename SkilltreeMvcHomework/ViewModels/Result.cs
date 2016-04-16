using System;
using System.Collections.Generic;

namespace SkilltreeMvcHomework.ViewModels
{
    public class Result : IResult
    {
        public Guid Id { get; private set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public string ResponseData { get; set; }

        public Exception Exception { get; set; }

        public List<IResult> InnerResults { get; protected set; }

        public Result()
            : this(false)
        {
        }

        public Result(bool success)
        {
            Id = Guid.NewGuid();
            Success = success;
            InnerResults = new List<IResult>();
        }
    }
}