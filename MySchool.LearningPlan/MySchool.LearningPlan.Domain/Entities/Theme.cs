using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public class Theme : LearningEntity
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
