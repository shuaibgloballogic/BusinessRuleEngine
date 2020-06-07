using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Utility
{
    public class Result
    {
        #region Public Members
        public int Status { get; set; }
        public string Error { get; set; }
        #endregion

        #region Constructors
        public Result(int status, string error = "")
        {
            Status = status;
            Error = error;
        }
        public Result()
        {
        }
        #endregion
    }
}
