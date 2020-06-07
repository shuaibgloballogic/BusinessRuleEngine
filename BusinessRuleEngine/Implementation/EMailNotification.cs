using BusinessRuleEngine.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Ineterace;

namespace BusinessRuleEngine.Implementation
{
    public class EMailNotification:IProcess
    {
        #region Private Members
        private readonly IProcess nextSteps = null;
        #endregion

        #region Constructors
        public EMailNotification(IProcess nextStep=null)
        {
            this.nextSteps = nextStep;
        }
        #endregion

        #region Public Functions
        public Result Process(object param = default)
        {
            try
            {
                Console.WriteLine(param?.ToString());

                // and process next step
                // break the chain if process failed
                if (nextSteps != null)
                {
                    return nextSteps.Process();
                }
                return new Result((int)Status.SUCCESS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Result((int)Status.FAIL, "Fail to send email notification");
        }
        #endregion
    }
}
