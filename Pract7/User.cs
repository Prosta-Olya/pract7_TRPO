using System;

public class User
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = "Имя";
    public string LastName { get; set; } = "Фамилия";
    public string Specialisation { get; set; } = "Специализация";
    public string Password { get; set; } = "Пароль";
    public User()
	{
        //Random random = new Random();

	}
}
