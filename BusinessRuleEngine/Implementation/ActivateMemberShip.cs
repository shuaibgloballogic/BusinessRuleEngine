using BusinessRuleEngine.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Ineterace;

namespace Test.Implementation
{
    public class ActivateMemberShip:IProcess
    {
        #region Private Members
        private readonly IProcess nextStep = null;
        #endregion

        #region Constructors
        public ActivateMemberShip(IProcess nextStep = null)
        {
            this.nextStep = nextStep;
        }
        #endregion

        #region Public Functions
        public Result Process(object param = default)
        {
            try
            {
                // do some stuff for activating the membership
                // and process next step
                // break the chain if process failed
                if (nextStep != null)
                {
                    string message = "Dear Customer, Your membership has been activated";
                    return nextStep.Process(message);
                }
                return new Result((int)Status.SUCCESS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Result((int)Status.FAIL, "Fail to activate membership");
        }
        #endregion
    }
}
