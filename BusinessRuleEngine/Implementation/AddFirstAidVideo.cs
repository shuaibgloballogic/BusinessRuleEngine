using BusinessRuleEngine.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Ineterace;

namespace BusinessRuleEngine.Implementation
{
    public class AddFirstAidVideo:IProcess
    {
        #region Private Members
        private readonly IProcess nextSteps = null;
        #endregion

        #region Constructors
        public AddFirstAidVideo(IProcess nextStep=null)
        {
            this.nextSteps = nextStep;
        }
        #endregion

        #region Public Functions
        public Result Process(object param = default)
        {
            try
            {
                // do some stuff for adding first aid video
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

            return new Result((int)Status.FAIL, "Fail to add first ad video");
        }
        #endregion
    }
}
