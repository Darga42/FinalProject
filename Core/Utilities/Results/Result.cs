using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message;
            Success = success;
        }

        public Result(bool success)
        {
            Success = success;
        }

        //Getler Constructorlar içinde Set edilebilir!!
        public bool Success { get; }

        public string Message { get; }
    }
}
