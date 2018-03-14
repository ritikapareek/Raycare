using System;
using System.Collections.Generic;

namespace RayCare
{
    public class TreatmentRoom
    {
        public string Name { get; set; }
        public string TreatmentMachineName { get; set; }
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
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
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
        public string Name;
    }

    public class Topography
    {
        public TopographyType Type { get; set; }
    }

    public class Cancer: Condition
    {
        public TopographyType TopographyType { get; set; }
    }

    public class Flu : Condition
    {
        
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

    public class Consultation
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string DoctorId { get; set; }
        public string RoomName { get; set; }
        public DateTime ConsultationDate { get; set; }
    }
}
