using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public class Subject : LearningEntity
    {
        public Subject(Guid learningEntityId,
            int? nzqfYear,
            int calendarYear,
            string code,
            string subjectCode) : base(learningEntityId, nzqfYear, calendarYear, code, subjectCode)
        {

        }
    }
}
