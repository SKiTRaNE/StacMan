// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;

namespace StackExchange.StacMan
{
    public partial class User : StacManType
    {
        internal User(FilterBehavior filterBehavior, Filter filter) : base(filterBehavior, filter, "user") { }

        private string _AboutMe;
        [Field("about_me")]
        public string AboutMe
        {
            get { EnsureFilterContainsField("about_me"); return _AboutMe; }
            internal set { _AboutMe = value; }
        }

        private int? _AcceptRate;
        [Field("accept_rate")]
        public int? AcceptRate
        {
            get { EnsureFilterContainsField("accept_rate"); return _AcceptRate; }
            internal set { _AcceptRate = value; }
        }

        private int _AccountId;
        [Field("account_id")]
        public int AccountId
        {
            get { EnsureFilterContainsField("account_id"); return _AccountId; }
            internal set { _AccountId = value; }
        }

        private int? _Age;
        [Field("age")]
        public int? Age
        {
            get { EnsureFilterContainsField("age"); return _Age; }
            internal set { _Age = value; }
        }

        private int _AnswerCount;
        [Field("answer_count")]
        public int AnswerCount
        {
            get { EnsureFilterContainsField("answer_count"); return _AnswerCount; }
            internal set { _AnswerCount = value; }
        }

        private BadgeCount _BadgeCounts;
        [Field("badge_counts")]
        public BadgeCount BadgeCounts
        {
            get { EnsureFilterContainsField("badge_counts"); return _BadgeCounts; }
            internal set { _BadgeCounts = value; }
        }

        private DateTime _CreationDate;
        [Field("creation_date")]
        public DateTime CreationDate
        {
            get { EnsureFilterContainsField("creation_date"); return _CreationDate; }
            internal set { _CreationDate = value; }
        }

        private string _DisplayName;
        [Field("display_name")]
        public string DisplayName
        {
            get { EnsureFilterContainsField("display_name"); return _DisplayName; }
            internal set { _DisplayName = value; }
        }

        private int _DownVoteCount;
        [Field("down_vote_count")]
        public int DownVoteCount
        {
            get { EnsureFilterContainsField("down_vote_count"); return _DownVoteCount; }
            internal set { _DownVoteCount = value; }
        }

        private bool _IsEmployee;
        [Field("is_employee")]
        public bool IsEmployee
        {
            get { EnsureFilterContainsField("is_employee"); return _IsEmployee; }
            internal set { _IsEmployee = value; }
        }

        private DateTime _LastAccessDate;
        [Field("last_access_date")]
        public DateTime LastAccessDate
        {
            get { EnsureFilterContainsField("last_access_date"); return _LastAccessDate; }
            internal set { _LastAccessDate = value; }
        }

        private DateTime? _LastModifiedDate;
        [Field("last_modified_date")]
        public DateTime? LastModifiedDate
        {
            get { EnsureFilterContainsField("last_modified_date"); return _LastModifiedDate; }
            internal set { _LastModifiedDate = value; }
        }

        private string _Link;
        [Field("link")]
        public string Link
        {
            get { EnsureFilterContainsField("link"); return _Link; }
            internal set { _Link = value; }
        }

        private string _Location;
        [Field("location")]
        public string Location
        {
            get { EnsureFilterContainsField("location"); return _Location; }
            internal set { _Location = value; }
        }

        private string _ProfileImage;
        [Field("profile_image")]
        public string ProfileImage
        {
            get { EnsureFilterContainsField("profile_image"); return _ProfileImage; }
            internal set { _ProfileImage = value; }
        }

        private int _QuestionCount;
        [Field("question_count")]
        public int QuestionCount
        {
            get { EnsureFilterContainsField("question_count"); return _QuestionCount; }
            internal set { _QuestionCount = value; }
        }

        private int _Reputation;
        [Field("reputation")]
        public int Reputation
        {
            get { EnsureFilterContainsField("reputation"); return _Reputation; }
            internal set { _Reputation = value; }
        }

        private int _ReputationChangeDay;
        [Field("reputation_change_day")]
        public int ReputationChangeDay
        {
            get { EnsureFilterContainsField("reputation_change_day"); return _ReputationChangeDay; }
            internal set { _ReputationChangeDay = value; }
        }

        private int _ReputationChangeMonth;
        [Field("reputation_change_month")]
        public int ReputationChangeMonth
        {
            get { EnsureFilterContainsField("reputation_change_month"); return _ReputationChangeMonth; }
            internal set { _ReputationChangeMonth = value; }
        }

        private int _ReputationChangeQuarter;
        [Field("reputation_change_quarter")]
        public int ReputationChangeQuarter
        {
            get { EnsureFilterContainsField("reputation_change_quarter"); return _ReputationChangeQuarter; }
            internal set { _ReputationChangeQuarter = value; }
        }

        private int _ReputationChangeWeek;
        [Field("reputation_change_week")]
        public int ReputationChangeWeek
        {
            get { EnsureFilterContainsField("reputation_change_week"); return _ReputationChangeWeek; }
            internal set { _ReputationChangeWeek = value; }
        }

        private int _ReputationChangeYear;
        [Field("reputation_change_year")]
        public int ReputationChangeYear
        {
            get { EnsureFilterContainsField("reputation_change_year"); return _ReputationChangeYear; }
            internal set { _ReputationChangeYear = value; }
        }

        private DateTime? _TimedPenaltyDate;
        [Field("timed_penalty_date")]
        public DateTime? TimedPenaltyDate
        {
            get { EnsureFilterContainsField("timed_penalty_date"); return _TimedPenaltyDate; }
            internal set { _TimedPenaltyDate = value; }
        }

        private int _UpVoteCount;
        [Field("up_vote_count")]
        public int UpVoteCount
        {
            get { EnsureFilterContainsField("up_vote_count"); return _UpVoteCount; }
            internal set { _UpVoteCount = value; }
        }

        private int _UserId;
        [Field("user_id")]
        public int UserId
        {
            get { EnsureFilterContainsField("user_id"); return _UserId; }
            internal set { _UserId = value; }
        }

        private Users.UserType _UserType;
        [Field("user_type")]
        public Users.UserType UserType
        {
            get { EnsureFilterContainsField("user_type"); return _UserType; }
            internal set { _UserType = value; }
        }

        private int _ViewCount;
        [Field("view_count")]
        public int ViewCount
        {
            get { EnsureFilterContainsField("view_count"); return _ViewCount; }
            internal set { _ViewCount = value; }
        }

        private string _WebsiteUrl;
        [Field("website_url")]
        public string WebsiteUrl
        {
            get { EnsureFilterContainsField("website_url"); return _WebsiteUrl; }
            internal set { _WebsiteUrl = value; }
        }
    }
}

#pragma warning restore 1591