using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.Char
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class GmSubsurvey
    {
        public uint SurveyId { get; set; }
        public uint QuestionId { get; set; }
        public uint Answer { get; set; }
        public string AnswerComment { get; set; } = null!;
    }
}
