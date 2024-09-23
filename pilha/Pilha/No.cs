public class No{

    public string valor;
    //public int valor;

    public No prox;

    // public No(int valor){ 
    //     this.valor = valor;
    //     this.prox = null;
    // }
    public No(string valor){
        this.valor = valor;
        this.prox = null;
    }

    public string imprimir(){
        // Console.WriteLine("Valor: " + this.valor);
        return "Valor: " + this.valor;
    }
}