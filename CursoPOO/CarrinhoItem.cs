namespace CursoPOO
{
    internal class CarrinhoItem
    {
        public string Nome { get; set; }

        private int _quantidade;        
        public int Quantidade
        { 
            get { return _quantidade; } 
            set {
                if (value > 0)
                {
                    _quantidade = value;
                }
                _quantidade = 1;
            }
        }

        public CarrinhoItem()
        {
            _quantidade = 1;
        }

        public void Teste(string p1, int p2)
        {
            // codigo
        }

        public string Teste2()
        {
            return Nome;
        }
    }
}
