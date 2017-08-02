using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Base
{
    public class ResultBase<T>
    {
        /// <summary>
        /// The Status of the Result
        /// </summary>
        public T Status { get; set; }

        /// <summary>
        /// The friendly message fire out
        /// </summary>
        public string Message { get; set; }
    }
}
