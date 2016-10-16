using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.CoreModel.Abstraction
{
    public abstract class AreaConfig
    {
        public Guid Id { get; set; }
        public int DefaultDuration { get; set; }
        public bool DefaultDurationAllDay { get; set; }
        public int MorningStarts { get; set; }
        public int MorningStartsMinutes { get; set; }
        public int EveningEnds { get; set; }
        public int EveningEndsMinutes { get; set; }
        public bool PrivateEnabled { get; set; }
        public bool PrivateDefault { get; set; }
        public bool PrivateMandatory { get; set; }
        public string PrivateOverride { get; set; }
        public bool MaxPreDayEnabled { get; set; }
        public int MaxPreDayCount { get; set; }
        public bool MaxPreWeekEnabled { get; set; }
        public int MaxPreWeeCount { get; set; }
        public bool MaxPreMonthEnabled { get; set; }
        public int MaxPreMonthCount { get; set; }
        public bool MaxPreYearEnabled { get; set; }
        public int MaxPreYearCount { get; set; }
        public bool MaxPreFutureEnabled { get; set; }
        public int MaxPreFutureCount { get; set; }
        public bool MaxDurationEnabled { get; set; }
        public int MaxDurationSecs { get; set; }
        public int MaxDurationPeriods { get; set; }
        public bool ApprovalEnabled { get; set; }
        public bool RemindersEnabled { get; set; }
        public bool EnablePeriods { get; set; }
        public bool ConfirmationEnabled { get; set; }
        public bool ConfirmedDefault { get; set; }

        public AreaConfig()
        {
            InitConfig();
        }

        public abstract void InitConfig();

    }
}
