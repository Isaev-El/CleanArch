namespace CleanArch.Domain.Entities;

/// <summary>
/// Class which describe person
/// </summary>
public class Person
{
    /// <summary>
    /// Конструктор для создания экземпляра объекта Person
    /// </summary>
    /// <param name="name"></param>
    /// <param name="surname"></param>
    /// <param name="email"></param>
    /// <param name="phoneNumber"></param>
    public Person(string name, string surname, string email, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}