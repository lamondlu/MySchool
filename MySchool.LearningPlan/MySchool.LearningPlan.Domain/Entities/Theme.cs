using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public class Theme : LearningEntity
    {
        public Theme(Guid learningEntityId,
            int? nzqfYear,
            int calendarYear,
            string code,
            string subjectCode) : base(learningEntityId, nzqfYear, calendarYear, code, subjectCode)
        {

        }
    }
}
