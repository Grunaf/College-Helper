﻿using app.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace app.Dtos.Student
{
    public class UpdateStudentRequestDto
    {
        public bool IsHeadboy { get; set; }
        public int IdChat { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public int StudentGroupId { get; set; }
    }
}