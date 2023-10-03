var cliente = new Cliente // instancia
{
    Nome = "Hisllaylla",
    Idade = 19,
    Profissao = "Estudante",
    EstadoCivil = "Solteira",
    Documento = "12345678901",

    ListaEndereco = new List<Endereco> // instancia decorrente do cliente
    {
        new Endereco { Id = 1, Logradouro = "Rua Paracatu", Numero = "43", Bairro = "Parque Imperial", Cidade = "São Paulo", Estado = "SP"},
        new Endereco { Id = 2, Logradouro = "Rua Maria Luísa do Val Penteado", Numero = "2040", Bairro = "Cidade São Mateus", Cidade = "São Paulo", Estado = "SP"},
        new Endereco { Id = 3, Logradouro = "Praça da República", Numero = "456", Bairro = "República", Cidade = "São Paulo", Estado = "SP"},
        new Endereco { Id = 4, Logradouro = "QE 11 Área Especial C", Numero = "710", Bairro = "Guará I", Cidade = "Brasília", Estado = "DF"},
        new Endereco { Id = 5, Logradouro = "Avenida Almirante Maximiano Fonseca", Numero = "95", Bairro = "Zona Portuária", Cidade = "Rio Grande", Estado = "RS"},
    }
};
/* 

    - List é uma classe de lista dinânimica (System.Collecions.Generic)
    - Listas são muito úteis para armazenar coleções de elementos de acesso rápido por índice, 
    bem como para adicionar, remover e modificar elementos.

*/

// ToList converte uma coleção em um objeto do tipo List<T>
// Where serve para filtrar/consultar com base numa condição, neste caso, feito pelo lambda
// First é um método que é usado para obter o primeiro elemento de uma coleção de acordo com uma condição

var enderecosSp = cliente.ListaEndereco.Where(x => x.Estado == "SP").ToList();
var enderecosFora = cliente.ListaEndereco.Where(x => x.Estado != "SP").ToList();

var totalLista = cliente.ListaEndereco.Count; // Count é para enumerar
var totalSp = enderecosSp.Count;
var totalfora = enderecosFora.Count;

Console.WriteLine($"Total de endereços de SP: {totalSp}");

/*

    Foreach permite percorrer facilmente os elementos de uma coleção, como um array, 
uma lista, uma coleção genérica, ou qualquer objeto que implemente a interface IEnumerable.

*/

foreach (var item in enderecosSp)
{
    Console.WriteLine(item.ToString());
};

Console.WriteLine($"Total de endereços de fora de SP: {totalfora}");
foreach (var item in enderecosFora)
{
    Console.WriteLine(item.ToString());
};