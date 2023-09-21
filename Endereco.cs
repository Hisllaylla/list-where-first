namespace ListWhereFirst;

public class Endereco
{
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Logradouro: {Logradouro}, Número: {Numero}, Bairro: {Bairro}, Cidade: {Cidade}, Estado: {Estado}";
    }
}