using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //This Result(Kendi bulunduğu class'tan bahsediyor)
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        //Get'ler Read Only oldukları için constructor'da set edilebilir ***
        public bool Success { get; }

        public string Message { get; }
    }
}
