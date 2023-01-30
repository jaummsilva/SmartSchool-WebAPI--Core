namespace SmartSchool_WebAPI.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int  ProfessorId { get; set; }
        public Professor professor { get; set; }

    }
}
