namespace SmartSchool_WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }

        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
           this.AlunoId = alunoId;
           this.DisciplinaId = disciplinaId;     
        }

        public int AlunoId { get; set; }
        public Aluno aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina disciplina { get; set; }

    }
}
