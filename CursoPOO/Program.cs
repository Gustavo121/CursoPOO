using CursoPOO;

//CarrinhoItem bola = new CarrinhoItem();
//bola.nome = "Bola de Futebol";
//bola.quantidade = 1;
//bola.preco = 99.00M;

//CarrinhoItem camisa = new CarrinhoItem();
//camisa.nome = "Camiseta de Frio";
//camisa.quantidade = 1;
//camisa.preco = 150M;

//CarrinhoItem bola = new CarrinhoItem();

Cesta cesta = new Cesta();

Item bola = new Item("Bola de Futebol", 99M);
bola.Quantidade = 2;
cesta.Itens.Add(bola);

Item camiseta = new Item("Camiseta do Corinthians", 150M);
camiseta.Quantidade = 3;
cesta.Itens.Add(camiseta);

foreach (var item in cesta.Itens)
{
    Console.WriteLine($"{item.Nome}; {item.Preco * item.Quantidade}");
}

Console.ReadLine();
