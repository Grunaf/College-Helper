﻿using app.Dtos.StudentAbsence;
using app.Interfaces;
using app.Mappers;
using app.Models;

namespace app.Services
{
    public class StudentAbsenceService : IStudentAbsenceService
    {
        private readonly IStudentAbsenceRepository _studentAbsenceRepo;
        public StudentAbsenceService(IStudentAbsenceRepository studentAbsenceRepo) 
        {
            _studentAbsenceRepo = studentAbsenceRepo;
        }

        public async Task<ResultCreateOrDelete> CreateOrDeleteAsync(CreateOrDeleteStudentAbsenceRequestDto absenceDto)
        {
            if (absenceDto.AbsenceId != -1)
            {
                var deletedAbsence = await _studentAbsenceRepo.DeleteByIdAsync(absenceDto.AbsenceId.Value);
                return new ResultCreateOrDelete { 
                    StudentAbsence = deletedAbsence,
                    OperationType = OperationType.Delete
                };
            }
            var createdAbsence = await _studentAbsenceRepo.CreateAsync(absenceDto.ToStudentAbsenceFromCreateOrDeleteDto());
            return new ResultCreateOrDelete
            {
                StudentAbsence = createdAbsence,
                OperationType = OperationType.Create
            };
        }
        public async Task<List<StatStudentAbsenseRequestDto>> GetStatStudentAbsensesRequestDtosAsync(long headBoyChatId)
        {
            var statStudentAbsenses = await _studentAbsenceRepo.GetStatStudentAbsensesByHeadBoyChatIdAsync(headBoyChatId);
            var statStudentAbsensesDtos = statStudentAbsenses.
                                            GroupBy(sa => sa.StudentId).
                                            Select(group => new StatStudentAbsenseRequestDto {
                                                Name = group.First().Student.Name,
                                                Surname = group.First().Student.Surname,
                                                Patronymic = group.First().Student.Patronymic,
                                                CountAbsense = group.Count()
                                            }).ToList();
            return statStudentAbsensesDtos;
        }
    }
    public struct ResultCreateOrDelete
    {
        public StudentAbsence StudentAbsence { get; set; }
        public OperationType OperationType { get; set; }
    }
    public enum OperationType { Create, Delete }
}
