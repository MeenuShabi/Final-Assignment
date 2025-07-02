using System.ComponentModel.DataAnnotations;

public class StudentMS
{
    [Key]
    public int StudentId { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }
}
