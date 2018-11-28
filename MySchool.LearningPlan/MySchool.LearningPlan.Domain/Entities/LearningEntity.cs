using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            else if (this is Subject && studentYearLearningPlan.Subjects.Any(p => p.LearningEntityId == this.LearningEntityId))
            {

            }
            else if (this is Activity && studentYearLearningPlan.Activities.Any(p => p.LearningEntityId == this.LearningEntityId))
            {

            }
            else if (this is Theme && studentYearLearningPlan.Themes.Any(p => p.LearningEntityId == this.LearningEntityId))
            {

            }
            else
            {

            }
        }
    }
}
