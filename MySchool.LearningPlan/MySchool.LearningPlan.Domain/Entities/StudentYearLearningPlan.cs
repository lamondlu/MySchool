using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public class StudentYearLearningPlan
    {
        public int CalendarYear { get; set; }

        public Guid StudentId { get; set; }

        public List<Subject> Subjects { get; private set; }

        public List<Activity> Activities { get; private set; }

        public List<Theme> Themes { get; private set; }

        public List<Collection> Collections { get; private set; }

        public List<LearningSet> LearningSets { get; private set; }
    }
}
