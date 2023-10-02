using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
           Aluno aluno = new Aluno();
           aluno.nome = "Jackson";
           aluno.nota1 = 8;
           aluno.nota2 = 8;
           aluno.Mensagem();
        }
    }
}
