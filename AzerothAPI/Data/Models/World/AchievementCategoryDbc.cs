﻿using System;
using System.Collections.Generic;

namespace AzerothAPI.Data.Models.World
{
    public partial class AchievementCategoryDbc
    {
        public int Id { get; set; }
        public int Parent { get; set; }
        public string? NameLangEnUs { get; set; }
        public string? NameLangEnGb { get; set; }
        public string? NameLangKoKr { get; set; }
        public string? NameLangFrFr { get; set; }
        public string? NameLangDeDe { get; set; }
        public string? NameLangEnCn { get; set; }
        public string? NameLangZhCn { get; set; }
        public string? NameLangEnTw { get; set; }
        public string? NameLangZhTw { get; set; }
        public string? NameLangEsEs { get; set; }
        public string? NameLangEsMx { get; set; }
        public string? NameLangRuRu { get; set; }
        public string? NameLangPtPt { get; set; }
        public string? NameLangPtBr { get; set; }
        public string? NameLangItIt { get; set; }
        public string? NameLangUnk { get; set; }
        public uint NameLangMask { get; set; }
        public int UiOrder { get; set; }
    }
}
