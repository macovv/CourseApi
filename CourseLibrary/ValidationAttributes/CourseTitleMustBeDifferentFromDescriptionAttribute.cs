﻿using CourseLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = (CourseForManipulationDto)validationContext.ObjectInstance;
            if(course.Title == course.Description)
            {
                return new ValidationResult("The provided description should be different from title", new[] { nameof(CourseForManipulationDto) });
            }
            return ValidationResult.Success;
        }
    }
}
