using System;

class Aluno 
{
    public string nome;
    public double nota1, nota2;

    public double Media()
    {
        return (nota1 + nota2) / 2;
    }

    public string Situacao(double Media) 
    {
        return Media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void Mensagem() 
    {
        double mediaAluno = Media();
        string situacaoAluno = Situacao(mediaAluno);   
        Console.WriteLine(nome + " está " + situacaoAluno + " com média de " + mediaAluno + " pontos");
    }
}