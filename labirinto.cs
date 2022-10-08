class Labirinto{

    public int coluna;

    public int linha;

    public Labirinto(){
        Console.Clear();
    }

    public void montarLabirinto(){

        int linha, coluna;
        int ci = 1, cf = 20, li, lf;

        Console.WriteLine("Insira o inicio da linha: ");
        li = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("insira o final da linha: ");
        lf = Convert.ToInt16(Console.ReadLine());
        Console.Read();
        Console.Clear();

        for(linha = li; linha <= lf; linha++){
            Console.SetCursorPosition(ci, linha);
            Console.WriteLine("|");
            Console.SetCursorPosition(cf, linha);
            Console.WriteLine("|");
        }

    }

}