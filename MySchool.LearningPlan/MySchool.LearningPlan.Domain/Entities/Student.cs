using MySchool.LearningPlan.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public class Student
    {
        public List<StudentYearInfo> YearInfos { get; set; }
    }
}
