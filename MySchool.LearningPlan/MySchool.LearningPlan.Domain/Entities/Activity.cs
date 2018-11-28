using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public class Activity : LearningEntity
    {
        public Activity(Guid learningEntityId,
            int? nzqfYear,
            int calendarYear,
            string code,
            string subjectCode) : base(learningEntityId, nzqfYear, calendarYear, code, subjectCode)
        {

        }
    }
}
