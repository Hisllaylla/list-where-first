Cliente cliente = new Cliente
{
    Nome = "Hisllaylla",
    Idade = 19,
    Profissao = "Estudante",
    EstadoCivil = "Solteira",
    Documento = 12345678901,

    ListaEndereco = new List<Endereco>
    {
        new Endereco { Id = 1, Logradouro = "Rua Paracatu", Numero = "43", Bairro = "Parque Imperial", Cidade = "São Paulo", Estado = "SP"},
        new Endereco { Id = 2, Logradouro = "Rua Maria Luísa do Val Penteado", Numero = "2040", Bairro = "Cidade São Mateus", Cidade = "São Paulo", Estado = "SP"},
        new Endereco { Id = 3, Logradouro = "Praça da República", Numero = "456", Bairro = "República", Cidade = "São Paulo", Estado = "SP"},
        new Endereco { Id = 4, Logradouro = "QE 11 Área Especial C", Numero = "710", Bairro = "Guará I", Cidade = "Brasília", Estado = "DF"},
        new Endereco { Id = 5, Logradouro = "Avenida Almirante Maximiano Fonseca", Numero = "95", Bairro = "Zona Portuária", Cidade = "Rio Grande", Estado = "RS"},
    }
};


List<Endereco> totalEnderecos = cliente.ListaEndereco.ToList();

// revelar total de endereços
foreach (var endereco in totalEnderecos)
{
    // filtrar endereços por SP
    totalEnderecos.RemoveAll(endereco => endereco.Estado != "SP");

    Console.WriteLine($"ID: {endereco.Id}, LOGRADOURO: {endereco.Logradouro}, NÚMERO: {endereco.Numero}, BAIRRO: {endereco.Bairro}, CIDADE: {endereco.Cidade}, ESTADO: {endereco.Estado}");

};


foreach (var endereco in totalEnderecos)
{
    // filtrar endereços diferentes de SP
    if (endereco.Estado != "SP")
    {
        Console.WriteLine($"ID: {endereco.Id}, Logradouro: {endereco.Logradouro}, Número: {endereco.Numero}, Bairro: {endereco.Bairro}, Cidade: {endereco.Cidade}, Estado: {endereco.Estado}");
    }
};