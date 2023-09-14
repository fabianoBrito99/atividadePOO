
   public class Prova
    {
    Gabarito gabarito;
    public string nomeAluno;
    double notaAluno = 0;
    public List<char> respostaAluno = new List<char>();

    public double maiorNota = -1;

    public Prova melhorProva;


    public Prova(String nome)
    {
        gabarito = new Gabarito();
        this.nomeAluno = nome;

    }
   


    public void repostaDoAluno(char resposta)
    {    
            respostaAluno.Add(resposta);
    }

    public int Acertos()
    {
        int acertos = 0;
        for (int i = 0;i < 5;i++)
        {
             if (gabarito.RespostaCorreta(i) == respostaAluno[i]) 
            {
                acertos++;
            }          
        }
        return acertos;
    }

    public double Nota()
    {
        int acertos = Acertos();
       
        notaAluno = acertos * 2;

        return notaAluno; 
    }

    /*public void melhorNota()
    {
        double nota = Nota();

       if(nota<melhorProva.notaAluno)
        {
            melhorProva.notaAluno = nota;
            melhorProva.nomeAluno = nomeAluno;

           
        }
       
    }*/
   
}

