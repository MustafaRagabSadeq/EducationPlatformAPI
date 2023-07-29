﻿namespace GraduationProjectAPI.Dtos
{
    public class ContentDetailsWithComponentsDto
    {
        public int Id { get; set; }
        public int ClassIdfk { get; set; }
        public string Title { get; set; } = null!;
        public DateTime Date { get; set; }
        public string ClassName { get; set; }
        public string[] Images { get; set; } = null;
        public string[] Pdfs { get; set; } = null;
        public string[] Videos { get; set; } = null;
    }
}
