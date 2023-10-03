namespace ListWhereFirst; // pasta

public class Cliente // reference type
{
    // propriedades da classe
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Profissao { get; set; }
    public string EstadoCivil { get; set; }
    public string Documento { get; set; }
    public List<Endereco> ListaEndereco { get; set; } // propriedade List
}

/*

// E N C A P S U L A M E N T O (métodos)

Getter (get) = acessor:

- O método get é usado para obter o valor de uma propriedade (ou campo) privado de um objeto.
- Ele geralmente retorna o valor armazenado no campo correspondente.
- Um método get é definido como uma função sem parâmetros que retorna o valor desejado.
- Ele permite a leitura do valor da propriedade, permitindo que outras partes do código acessem o valor, mas não modifiquem diretamente.


Setter (set) = modificador:

- O método set é usado para definir (ou modificar) o valor de uma propriedade privada de um objeto.
- Ele geralmente recebe um parâmetro que é o novo valor a ser atribuído à propriedade.
- Um método set é definido como uma função com um parâmetro, que atribui o valor recebido ao campo correspondente.
- Ele permite a modificação do valor da propriedade, garantindo que o novo valor atenda a critérios de validação, se necessário.

*/