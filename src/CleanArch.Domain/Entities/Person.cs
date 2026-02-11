namespace CleanArch.Domain.Entities;

/// <summary>
/// Class which describe person
/// </summary>
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }