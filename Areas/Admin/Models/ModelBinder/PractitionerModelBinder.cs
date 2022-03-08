﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using PainAssessment.Areas.Admin.Models.Factory;
using System;
using System.Threading.Tasks;

namespace PainAssessment.Areas.Admin.Models.ModelBinder
{
    public class PractitionerModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            IPersonFactory personFactory = new PersonFactory();
            IPractitioner practitioner;

            Microsoft.AspNetCore.Http.IFormCollection data = bindingContext.HttpContext.Request.Form;
            bool nameResult = data.TryGetValue("Name", out Microsoft.Extensions.Primitives.StringValues name);
            bool idResult = data.TryGetValue("Id", out Microsoft.Extensions.Primitives.StringValues id);
            data.TryGetValue("Experience", out Microsoft.Extensions.Primitives.StringValues experience);
            data.TryGetValue("PracticeType", out Microsoft.Extensions.Primitives.StringValues practiceType);
            data.TryGetValue("PriorPainEducation", out Microsoft.Extensions.Primitives.StringValues priorPainEducation);
            data.TryGetValue("ClinicalAreaID", out Microsoft.Extensions.Primitives.StringValues clinicalAreaID);

            if (nameResult)
            {
                if (idResult)
                {
                    practitioner = personFactory.CreatePractitioner(name.ToString(), experience.ToString(), practiceType.ToString(), priorPainEducation.ToString(), Int32.Parse(clinicalAreaID), Guid.Parse(id.ToString()));
                }
                else
                {
                    practitioner = personFactory.CreatePractitioner(name.ToString(), experience.ToString(), practiceType.ToString(), priorPainEducation.ToString(), Int32.Parse(clinicalAreaID));
                }
                bindingContext.Result = ModelBindingResult.Success(practitioner);
            }
            return Task.CompletedTask;
        }
    }
}
