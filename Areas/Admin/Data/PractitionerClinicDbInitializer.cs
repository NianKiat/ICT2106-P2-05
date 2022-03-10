﻿using PainAssessment.Areas.Admin.Models;
using PainAssessment.Data;
using System;
using System.Linq;


namespace PainAssessment.Areas.Admin.Data
{
    public static class PractitionerClinicDbInitializer
    {
        public static void Initialize(HospitalContext context)
        {

            //context.Database.EnsureCreated();
            // Look for any practitioner
            if (context.Practitioners.Any())
            {
                return;   // DB has been seeded
            }
            ClinicalArea[] clinicalArea = new ClinicalArea[]
            {
            new ClinicalArea("Musculoskeletal"),
            new ClinicalArea("Neurology/Neurosurgery"),
            new ClinicalArea("Older People/Falls"),
            new ClinicalArea("Cardiorespiratory"),
            new ClinicalArea("Women’s Health/Pelvic Floor"),
            new ClinicalArea("General Medicine"),
            new ClinicalArea("Orthopaedic"),
            new ClinicalArea("Pain Management"),
            new ClinicalArea("Intensive Care"),
            new ClinicalArea("Hand Therapy"),
            };
            context.ClinicalAreas.AddRange(clinicalArea);

            context.SaveChanges();

            PracticeType[] practiceTypes = new PracticeType[]
            {
            new PracticeType("Hospital Inpatient"),
            new PracticeType("Hospital Outpatient"),
            new PracticeType("Community Health"),
            new PracticeType("Rehabilitation Clinic"),
            new PracticeType("Private Clinic"),

            };
            context.PracticeTypes.AddRange(practiceTypes);


            context.SaveChanges();

            PainEducation[] painEducations = new PainEducation[]
            {
            new PainEducation("None"),
            new PainEducation("Pre-registration training - pain topics"),
            new PainEducation("Private provider course or workshop"),
            new PainEducation("Inservice"),
            new PainEducation("Professional Body"),
            new PainEducation("Postgraduate qualification (not pain-specific)"),
            new PainEducation("Postgraduate qualification (pain-specific)"),
            new PainEducation("Conference (pain specific)"),
            };

            context.PainEducations.AddRange(painEducations);


            context.SaveChanges();


            Practitioner[] practitioners = new Practitioner[]
            {
            new Practitioner("Alexander", "2 years ",  "1",1,1),
            new Practitioner( "Meredith", "2 years ",  "1",1,1),
            new Practitioner( "Carson", "4 years ",   "2",2,1),
            new Practitioner( "Arturo", "4 years ",   "2",2,1),
            new Practitioner( "Gytis", "6 years ",  "2",3,2),
            new Practitioner( "Yan", "6 years ",  "3",3,2),
            new Practitioner( "Li", "6 years ",  "3",4,2),
            new Practitioner( "Alonso", "None",  "3",4,2),
            new Practitioner( "Anand", "1 year",  "4",5,2),
            new Practitioner( "Barzdukas", "2 years ",  "4",5,3),
            new Practitioner( "Olivetto", "2 years ",  "4",6,3),
            new Practitioner( "Nino", "3 years ",  "5",6,3),
            new Practitioner( "Peggy", "3 years ",  "5",4,3),
            new Practitioner( "Laura", "3 years ",  "5",7,3),
            new Practitioner( "Norman", "6 years ",   "6",7,3),
            new Practitioner( "Justice", "6 years ",   "6",8,4),
            new Practitioner( "Liam", "8 years ",   "6",8,4),
            new Practitioner( "Oliver", "8 years ",   "6",3,4),
            new Practitioner( "Elijah", "9 years ",   "7",9,4),
            new Practitioner( "William", "9 years ",  "8",9,4),
            new Practitioner( "James", "3 years ",   "1,2",10,1),
            new Practitioner( "Benjamin", "1 years ",  "1,2",10,1),
            new Practitioner( "Lucas", "1 years ",  "3,4",10,1),
            };
            context.Practitioners.AddRange(practitioners);
            context.SaveChanges();

            Patient[] patients = new Patient[]
            {
                new Patient(  "Stone","Female",DateTime.UtcNow,    "Unknown",  "Unknown" ),
                new Patient(  "John", "Female",DateTime.UtcNow,  "Unknown",  "Unknown" ),
                new Patient(  "Wong", "Male",DateTime.UtcNow,  "Unknown",  "Unknown" ),
                new Patient(  "Mia", "Female",DateTime.UtcNow,  "Unknown",  "Unknown" ),
                new Patient(  "Nguta",  "Male",DateTime.UtcNow,  "Unknown",  "Unknown" ),
                new Patient(  "Ilya",  "Female", DateTime.UtcNow, "Unknown",  "Unknown" ),
                new Patient(  "Ellawala",  "Female",DateTime.UtcNow,  "Unknown",  "Unknown" ),
                new Patient(  "Ruveni",  "Female",DateTime.UtcNow,  "Unknown",  "Unknown" ),
                new Patient(  "Ponnappa",  "Male",  DateTime.UtcNow,"Unknown",  "Unknown" ),
                new Patient(  "Priya",  "Female", DateTime.UtcNow, "Unknown",  "Unknown" ),
                new Patient(  "Peter",  "Female",  DateTime.UtcNow,"Unknown",  "Unknown" ),
                new Patient(  "Stanbridge",  "Female", DateTime.UtcNow, "Unknown",  "Unknown" ),
                new Patient(  "Ruveni",  "Female", DateTime.UtcNow, "Unknown",  "Unknown" ),
                new Patient(  "Andrews",  "Male",DateTime.UtcNow,  "Unknown",  "Unknown" ),
                new Patient(  "Daly",  "Female", DateTime.UtcNow, "Unknown",  "Unknown" )

            };


            context.Patients.AddRange(patients);
            context.SaveChanges();

        }
    }
}