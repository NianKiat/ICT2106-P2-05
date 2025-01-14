﻿using PainAssessment.Models;
using System;

namespace PainAssessment.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Account> AccountRepository { get; }
        IGenericRepository<Administrator> AdministratorRepository { get; }
        IGenericRepository<Department> DepartmentRepository { get; }
        IGenericRepository<Practitioner> PractitionerRepository { get; }
        IGenericRepository<Patient> PatientRepository { get; }
        IGenericRepository<TemplateChecklist> TemplateChecklistRepository { get; }
        void Save();

    }
}
