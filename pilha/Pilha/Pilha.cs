using System.Diagnostics.Contracts;

public class Pilha{
    public No topo;
    public Pilha(){
        this.topo = null;
    }
    public Boolean estavazia(){
        if(this.topo == null){
            return(true);
        }
        return(false);
    }
    // public void push(int valor){ //Exercício 1A

    //     No novoNo = new No(valor);
        
    //     if(this.estavazia() == true){
    //         this.topo = novoNo;
    //     }
    //     else{
    //         novoNo.prox = this.topo;
    //         this.topo = novoNo;
    //     }
    // }
    public void push(string valor){ //Exercício 1A

        No novoNo = new No(valor);
        
        if(this.estavazia() == true){
            this.topo = novoNo;
        }
        else{
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }
    public No pop(){ //Exercício 1B

        No aux = null;

        if(this.estavazia()){
            return(null);
        }
        else{
            aux = this.topo;
            this.topo = this.topo.prox;
            aux.prox = null;
            return(aux);
        }
    }
    public Boolean consulta(string valor, ref No noAtual){ //Exercício 1C
        noAtual = this.topo; //Copia da lista
        while(noAtual != null){ //Percorrer lista
            if(noAtual.valor == valor){
                return(true);
            }
            noAtual = noAtual.prox;
        }
        return(false);
    }
 
    public void imprimir(){ //percorrer a lista...
 
        No aux = this.topo; //Copia do inicio da lista
       
        Console.WriteLine("Elementos: ");
       
        while(aux != null){
            Console.Write(aux.valor + " -> ");
            aux = aux.prox;
        }
    }
    public void percurso(){ //Exercício 2

        No noAtual = this.topo;
        int qtde = 0;

        while(noAtual != null){
            noAtual = noAtual.prox;
            qtde++;
        }
        Console.WriteLine("valores: " + qtde);
    }
    public void NumerosImpares() //EXERCÍCIO 3
    {
        No aux = this.topo;
        int contadorImpares = 0;

        while (aux != null)
        {
            // Converter o valor do nó para inteiro
            int numero;
            if (int.TryParse(aux.valor, out numero))
            {
                // Verificar se o número é ímpar
                if (numero % 2 != 0)
                {
                    contadorImpares++;
                }
            }

            // Avançar para o próximo nó
            aux = aux.prox;
        }

        // Exibir o total de números ímpares encontrados
        Console.WriteLine("Quantidade de números ímpares na pilha: " + contadorImpares);
    }
    // public void separaPositivosNegativos(Pilha pilha2, Pilha pilha3) { //EXERCÍCIO 4
    // No noAtual = this.topo;  
 
    // while (noAtual != null) {
    //     if (noAtual.valor >= 0) {
    //         pilha2.push(noAtual.valor);  
    //         } else {
    //             pilha3.push(noAtual.valor);  
    //     }
    //     noAtual = noAtual.prox;
    // }
    // }
    public void inverter() { //EXERCÍCIO 5
    Pilha pilhaAux = new();  
 
    while (!this.estavazia()) {
        pilhaAux.push(this.pop().valor);  
    }
 
    this.topo = pilhaAux.topo;  
    }
    public bool Palindromo() { //EXERCÍCIO 6
    Pilha pilhaAux = new();  
    No noAtual = this.topo;
    string palavraOriginal = "";
    string palavraInvertida = "";
 
    
    while (noAtual != null) {
        pilhaAux.push(noAtual.valor);     
        palavraOriginal += noAtual.valor; 
        noAtual = noAtual.prox;
    }
 
    
    while (!pilhaAux.estavazia()) {
        palavraInvertida += pilhaAux.pop().valor;  
    }
 
    return palavraOriginal == palavraInvertida;
}
 
public void transferirPilha(Pilha pilhaDestino) { //EXERCÍCIO 7
    Pilha pilhaAux = new();  // Pilha auxiliar para inverter os elementos
 
    
    while (!this.estavazia()) {
        pilhaAux.push(this.pop().valor);  
    }
 
    
    while (!pilhaAux.estavazia()) {
        pilhaDestino.push(pilhaAux.pop().valor); 
    }
}


}


