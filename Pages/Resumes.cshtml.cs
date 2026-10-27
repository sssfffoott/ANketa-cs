using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspnetWebApp.Models;

namespace aspnetWebApp.Pages;

public class ResumeModel : PageModel
{

    public List<Student> Students {get; set;} = new();

    public List<string> Specialities {get; set;} = new();

    public string Search {get; set;} = "";

    public string SpecialityFilter {get; set;} = "";

    public void OnGet(string? search, string? specialityFilter)
    {
        var allStudents = CreateResumeModel.Students;
        Search = search?.Trim() ?? "";
        SpecialityFilter = specialityFilter ?? "";

        Specialities = allStudents
        .Select(Students => Students.Speciality)
        .Where(speciality => !string.IsNullOrWhiteSpace(speciality))
        .Distinct()
        .OrderBy(speciality => speciality)
        .ToList();

    }

}