
    public class Gabarito
    {
    public List<char> AlternativaCerta = new List<char>();
  
    public Gabarito()
    {
     
        AlternativaCerta.Add('A');
        AlternativaCerta.Add('C');
        AlternativaCerta.Add('E');
        AlternativaCerta.Add('A');
        AlternativaCerta.Add('B');
    }
    

    public char RespostaCorreta(int numeroQuestao)
    {
        return AlternativaCerta[numeroQuestao];
    }

    }

