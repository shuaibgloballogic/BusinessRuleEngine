using BusinessRuleEngine.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Ineterace
{
    public interface IProcess
    {
        Result Process(object param = default);
    }
}
