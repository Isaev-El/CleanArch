namespace CleanArch.Domain.Entities;

/// <summary>
/// Class which describe person
/// </summary>
public class Person
{
    /// <summary>
    /// Конструктор для создания экземпляра объекта Person
    /// </summary>
    /// <param name="middleName"></param>
    /// <param name="surname"></param>
    /// <param name="email"></param>
    /// <param name="phoneNumber"></param>
    public Person(string middleName, string surname, string email, string phoneNumber)
    {
        MiddleName = middleName;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public int Id { get; set; }
    public string MiddleName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}