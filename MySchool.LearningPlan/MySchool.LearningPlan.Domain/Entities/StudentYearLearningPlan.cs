using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.Entities
{
    public class StudentYearLearningPlan
    {
        public int CalendarYear { get; set; }

        public Guid StudentId { get; set; }

        public List<Subject> Subjects { get; set; }

        public List<Activity> Activities { get; set; }

        public List<Theme> Themes { get; set; }

        public List<Collection> Collections { get; set; }

        public List<LearningSet> LearningSets { get; set; }
    }
}
