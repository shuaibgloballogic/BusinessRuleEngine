﻿using BusinessRuleEngine.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Ineterace;

namespace BusinessRuleEngine.Implementation
{
    public class ApplyUpgrade: IProcess
    {
        #region Private Members
        private readonly IProcess nextSteps = null;
        #endregion

        #region Constructors
        public ApplyUpgrade(IProcess nextStep=null)
        {
            this.nextSteps = nextStep;
        }
        #endregion

        #region Public Functions
        public Result Process(object param = default)
        {
            try
            {
                // do some stuff for upgrading membership
                // and process next step
                // break the chain if process failed
                if (nextSteps != null)
                {
                    string message = "Dear Customer, Your membership has been upgrade";
                    return nextSteps.Process(message);
                }
                return new Result((int)Status.SUCCESS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Result((int)Status.FAIL, "Fail to upgrade membership");
        }
        #endregion
    }
}