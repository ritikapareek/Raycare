using System;
using RayCare.Model;
using RayCare.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCare.Services
{
    public static class PatientConditionService
    {
        public static CancerCondition readCancerServiceFromUser()
        {
            CancerCondition condition = new CancerCondition();
            condition.TopographyType = (TopographyType)EnumHelper.ReadEnumValueFromUser(typeof(TopographyType));
            return condition;
        }
    }
}
