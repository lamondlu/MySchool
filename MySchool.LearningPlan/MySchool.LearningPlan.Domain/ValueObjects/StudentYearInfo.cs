using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.LearningPlan.Domain.ValueObjects
{
    public struct StudentYearInfo
    {
        public int CalendarYear { get; set; }

        public int CurrentYearLevel { get; set; }

        public int FundingYearLevel { get; set; }
    }
}
