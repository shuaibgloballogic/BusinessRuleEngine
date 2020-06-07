using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRuleEngine;
using Moq;
using BusinessRuleEngine.Utility;
using System;
using Test.Ineterace;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class BusinessRuleTest
    {
        private readonly RuleEngine ruleEngine;
        private Mock<RuleEngine> mockRuleEngine;
        private Mock<Result> result;
        private Mock<IProcess> mockProcess;
        public BusinessRuleTest()
        {
            ruleEngine = new RuleEngine();
            mockRuleEngine = new Mock<RuleEngine>();
            result = new Mock<Result>();
            mockProcess = new Mock<IProcess>();
        }

        [TestInitialize]
        public void Init()
        {
            //setup
        }

        [TestMethod]
        public void Test_BOOK_Success()
        {
            mockProcess.Setup(x => x.Process(null)).Returns(result.Object);
            var ret = ruleEngine.RunBusinessRuleEngine(PaymentType.BOOK);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }

        [TestMethod]
        public void Test_PHYSICAL_PRODUCT_Success()
        {
            mockProcess.Setup(x => x.Process(null)).Returns(result.Object);
            var ret = ruleEngine.RunBusinessRuleEngine(PaymentType.PHYSICAL_PRODUCT);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }

        [TestMethod]
        public void Test_PHYSICAL_MEMBERSHIP_ACTIVATE_Success()
        {
            mockProcess.Setup(x => x.Process(null)).Returns(result.Object);
            var ret = ruleEngine.RunBusinessRuleEngine(PaymentType.MEMBERSHIP_ACTIVATE);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }

        [TestMethod]
        public void Test_PHYSICAL_MEMBERSHIP_Upgrade_Success()
        {
            mockProcess.Setup(x => x.Process(null)).Returns(result.Object);
            var ret = ruleEngine.RunBusinessRuleEngine(PaymentType.MEMBERSHIP_UPGRADE);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }

        [TestMethod]
        public void Test_PHYSICAL_MEMBERSHIP_Video_Success()
        {
            mockProcess.Setup(x => x.Process(null)).Returns(result.Object);
            var ret = ruleEngine.RunBusinessRuleEngine(PaymentType.VIDEO);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }

        [TestMethod]
        public void Test_BOOK_Failed()
        {
            mockProcess.Setup(x => x.Process(null)).Returns(result.Object);
            var ret = ruleEngine.RunBusinessRuleEngine(PaymentType.BOOK);
            Assert.IsTrue(ret.Status == (int)Status.FAIL);
        }
    }
}
