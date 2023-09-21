namespace ListWhereFirst;

public class Endereco
{
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public short Estado { get; set; }
    public override string ToString()
    {
        return $"{Id}, {Logradouro}, {Numero}, {Bairro}, {Cidade}, {Estado}";
    }

}