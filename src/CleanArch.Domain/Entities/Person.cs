namespace CleanArch.Domain.Entities;

/// <summary>
/// Class which describe person
/// </summary>
public class Person
{
    /// <summary>
    /// Конструктор для создания экземпляра объекта Person
    /// </summary>
    /// <param name="lastName"></param>
    /// <param name="surname"></param>
    /// <param name="email"></param>
    /// <param name="phoneNumber"></param>
    public Person(string lastName, string surname, string email, string phoneNumber)
    {
        LastName = lastName;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public int Id { get; set; }
    public string LastName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}