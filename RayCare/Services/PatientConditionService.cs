using RayCare.Helpers;

namespace RayCare.Services
{
    /// <summary>
    /// This class describes the Patient's condition services.
    /// </summary>
    public static class PatientConditionService
    {
        /// <summary>
        /// This reads the cancer condition from user and fetches the Topography types.
        /// </summary>
        /// <returns></returns>
        public static CancerCondition ReadCancerServiceFromUser()
        {
            CancerCondition condition = new CancerCondition();
            condition.TopographyType = (TopographyType)EnumHelper.ReadEnumValueFromUser(typeof(TopographyType));
            return condition;
        }
    }
}
