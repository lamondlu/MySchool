using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public abstract class LearningEntity
    {
        public LearningEntity(Guid learningEntityId,
            int? nzqfYear,
            int calendarYear,
            string code,
            string subjectCode)
        {

        }

        public Guid LearningEntityId { get; private set; }

        public int? NZQFYear { get; set; }

        public int CalenderYear { get; set; }

        public string Code { get; set; }

        public string SubjectCode { get; set; }

        public void AssignTo(StudentYearLearningPlan studentYearLearningPlan)
        {
            if (studentYearLearningPlan.CalendarYear != CalenderYear)
            {

            }
            else
            {

            }
        }
    }
}
