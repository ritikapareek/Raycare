using RayCare.Model;
using System.Collections.Generic;

/// <summary>
/// Initializes the various data models for Treatment Room, Treatment Machine,
/// Doctor, Patient.
/// </summary>
namespace RayCare
{
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
            this.conditionType = ConditionType.Cancer;
        }
        public TopographyType TopographyType { get; set; }
    }

    public class FluCondition : Condition
    {
        public FluCondition() {
            this.conditionType = ConditionType.Flu;
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
