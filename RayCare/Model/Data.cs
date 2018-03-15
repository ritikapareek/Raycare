using RayCare.Model;
using System.Collections.Generic;

/// <summary>
/// Initializes the various data models for Treatment Room, Treatment Machine,
/// Doctor, Patient.
/// </summary>
namespace RayCare
{
    /// <summary>
    /// Describes Treatment room with unique name.
    /// Room is equiped with a Treatment Machine.
    /// Calendar is associated witth the Treatment Room to
    /// check its availability.
    /// </summary>
    public class TreatmentRoom
    {
        public TreatmentRoom()
        {
            calender = new Calendar();
        }
        public string Name { get; set; }
        public string TreatmentMachine { get; set; }
        public Calendar calender { get; set; }
    }

    /// <summary>
    /// Describes Treatment Machine with a unique name.
    /// Each treatment machine has a capabiltiy.
    /// </summary>
    public class TreatmentMachine
    {
        public string Name { get; set; }
        public Capability Capability { get; set; }
    }

    public enum Capability
    {
        Advanced,
        Simple
    }

    /// <summary>
    /// Describes Doctor who has a name,id  and set of roles.
    /// calendar is associated with a doctor to check his availability.
    /// Doctor also has a unique Id.
    /// </summary>
    public class Doctor
    {
        public Doctor()
        {
            calender = new Calendar();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
        public Calendar calender { get; set; }
    }

    public enum Role
    {
        Oncologist,
        GeneralPractitioner
    }

    /// <summary>
    /// Describes a Patient with name and Condition.
    /// Patient has a unique Id.
    /// </summary>
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Condition Condition { get; set; }
    }
    public abstract class Condition
    {
        public ConditionType conditionType;
    }

    public class Topography
    {
        public TopographyType Type { get; set; }
    }

    public class CancerCondition: Condition
    {
        public CancerCondition()
        {
            conditionType = ConditionType.Cancer;
        }
        public TopographyType TopographyType { get; set; }
    }

    public class FluCondition : Condition
    {
        public FluCondition()
        {
            conditionType = ConditionType.Flu;
        }
    }

    public enum ConditionType
    {
        Cancer,
        Flu
    }

    public enum TopographyType
    {
        HeadAndNeck,
        Breast
    }
    
}
