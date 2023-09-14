
Gabarito gabarito = new Gabarito();
string nome;
int escolha = 0;

Prova melhorProva = null;


do {

    Console.WriteLine("digite o nome do aluno");
    nome = Console.ReadLine();

    Prova prova = new Prova(nome);

    for (int i = 0; i < 5; i++)
    {
   Console.WriteLine($"digite a resposta da {i+1}ª questão do aluno {prova.nomeAluno}");
   char resposta =  Convert.ToChar( Console.ReadLine().ToUpper() );

        prova.repostaDoAluno( resposta );
    
    }
    Console.WriteLine($@" 
Aluno: {prova.nomeAluno.ToUpper()}
ACERTOS = {prova.Acertos()}
NOTA = {prova.Nota()}");
    
   

    double notaProva = prova.Nota();

    if (melhorProva == null || notaProva > melhorProva.Nota())
    {
    melhorProva = prova;
    }

    Console.WriteLine(@"deseja executar um novo aluno?
digite 1 para Sim 
digite 2 para ver a maior NOTA
digite 0 para Sair");
    escolha = Convert.ToInt32(Console.ReadLine());

    if (escolha == 2)
    {

        Console.WriteLine($@"melhor Nota:  
aluno: {melhorProva.nomeAluno}
nota: {melhorProva.Nota()}
acertos: {melhorProva.Acertos()}");

    }


} while(escolha !=0);









