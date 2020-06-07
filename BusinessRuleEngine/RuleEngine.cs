using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Implementation;
using Test.Ineterace;

namespace BusinessRuleEngine
{
    public class RuleEngine
    {
        public Result RunBusinessRuleEngine(PaymentType type)
        {
            switch (type)
            {
                case PaymentType.PHYSICAL_PRODUCT:
                    {
                        var generateCommissionPayment = new GenerateCommissionPayment();
                        var packingSlip = new GeneratePackingSlip(generateCommissionPayment);
                        return packingSlip.Process();
                    }
                case PaymentType.BOOK:
                    {
                        var generateCommissionPayment = new GenerateCommissionPayment();
                        var GeneratePackingSlipForRoyaltyDepartment = new GeneratePackingSlipForRoyaltyDepartment(generateCommissionPayment);
                        return GeneratePackingSlipForRoyaltyDepartment.Process();
                    }
                case PaymentType.MEMBERSHIP_ACTIVATE:
                    {
                        var sendEmailNotifification = new EMailNotification();
                        var activateMemberShip = new ActivateMemberShip(sendEmailNotifification);
                        return activateMemberShip.Process();
                    }
                case PaymentType.MEMBERSHIP_UPGRADE:
                    {
                        var sendEmailNotifification = new EMailNotification();
                        var applyUpgrade = new ApplyUpgrade(sendEmailNotifification);
                        return applyUpgrade.Process();
                    }
                case PaymentType.VIDEO:
                    {
                        var addFirstAidVideo = new AddFirstAidVideo();
                        var packingSlip = new GeneratePackingSlip(addFirstAidVideo);
                        return packingSlip.Process();
                    }
                default:
                    return new Result((int)Status.FAIL, "payment type is not found");
            }
        }
    }
}
