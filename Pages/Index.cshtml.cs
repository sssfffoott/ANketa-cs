using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using aspnetWebApp.Models;
=======
using aspnetWebApp.models
>>>>>>> fa86a7ecb14eb292dc7378b9a753125bca06be08

namespace aspnetWebApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]

    public required string Name { get; set; }
    [BindProperty]
    public required string Phone { get; set; }
    [BindProperty]
    public required string Email { get; set; }
    [BindProperty]
    public required string Speciality { get; set; }
    [BindProperty]
    public required string Course { get; set; }
    [BindProperty]
    public required string BirthDate { get; set; }
=======
    public string Name { get; set; }
    [BindProperty]
    public string Phone { get; set; }
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Speciality { get; set; }
    [BindProperty]
    public string Course { get; set; }
    [BindProperty]
    public string BirthDate { get; set; }
>>>>>>> fa86a7ecb14eb292dc7378b9a753125bca06be08
    [BindProperty]
    public string[] Technologies { get; set; } = Array.Empty<string>();
    public static List<Student> Students {get; set;} = new();



    public string Message { get; set; }
=======
    // public string Message { get; set; }
>>>>>>> fa86a7ecb14eb292dc7378b9a753125bca06be08
    public void OnGet()
    {
        // Message = "Привет! Сообщение от C#";
    }
    public IActionResult OnPost() {

        string technologies = Technologies.Length > 0
            ? string.Join(", ", Technologies)
            : "Не выбраны";

        // string message = $"Анкета студента\n\n" +
        //         $"Имя: {Name}\n" + 
        //         $"Телефон: {Phone}\n" +
        //         $"Email: {Email}\n" +
        //         $"Специальность: {Speciality}\n" +
        //         $"Курс: {Course}\n" +
        //         $"Дата рождения: {BirthDate}\n" +
        //         $"Технологии: {technologies}";

        var student = new Student
        {
<<<<<<< HEAD
            Id = Student.Any()? Student.Max(x=>x.Id)+1:1,
=======
>>>>>>> fa86a7ecb14eb292dc7378b9a753125bca06be08
            Name = Name,
            Phone = Phone,
            Email = Email,
            Speciality = Speciality,
            Course = Course,
            BirthDate = BirthDate,
            Technologies = Technologies
        };
<<<<<<< HEAD
        Students.Add(student);
=======

        Student.add(student);
>>>>>>> fa86a7ecb14eb292dc7378b9a753125bca06be08

        return new JsonResult(student);
    }

    public IActionResult onGetStudent(int Id){

        var student = Students.FirstOrDefault(x => x.Id == Id);
        if (student == null){


        return new JsonResult(new
        {
            succes = false,
            message = "Студент не найден"
        });
        }

        Students.Remove(student);
        return new JsonResult(new{
            succes = true
        });
    }
}
