using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Site.Service
{
    public class Result
    {
        private Result(bool isSuccess, string message, IEnumerable<Error> errors)
        {
            IsSuccess = isSuccess;
            isFailure = !isSuccess;
            Message = message;
            Errors = errors;
        }
        public bool IsSuccess { get; }
        public bool isFailure { get; }
        public string Message { get; }
        public IEnumerable<Error> Errors { get; }
        public Result Fail(string message) => new Result(false, message, Enumerable.Empty<Error>());
        public Result OK() => new Result(true, "", Enumerable.Empty<Error>());

    }

    public class Error
    {
        public Error(string propertyName, string message)
        {
            Message = message;
            PropertyName = propertyName;
        }
        public string Message { get; set; }
        public string PropertyName { get; set; }
    }
}
