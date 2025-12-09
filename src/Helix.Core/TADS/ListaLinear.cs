namespace Helix.Core.TADS
{
    public class ListaLinear
    {
        private int[] elementos; // vetor para receber os elementos da lista
        private int capacidade; // tamanho da lista 
        private int inicio; // ponteiro que aponta para o inicio da lista
        private int fim; // ponteiro que aponta para o ultimo elemento apos a lista.

        public ListaLinear(int tamanho)
        {
            capacidade = tamanho;
            elementos = new int[capacidade];
            inicio = 0;
            fim = 0;
        }

        public bool EstaVazia()
        {
            return fim == inicio;
        }

        public bool EstaCheia()
        {
            return fim == capacidade;
        }

        public int Tamanho()
        {
            return fim - inicio;
        }

        public void Inserir(int item, int posicao)
        {
            if (EstaCheia())
            {
                Console.WriteLine("Lista Cheia. Erro.");
            }

            if (posicao < 0 || posicao > Tamanho())
            {
                Console.WriteLine("Posicao Invalida. Tente novamente.");
            }

            for (int i = fim; i > inicio + posicao; i--)
            {
                elementos[i] = elementos[i - 1];
            }

            elementos[inicio + posicao] = item;
            fim++;
        }

        public int Remover(int posicao)
        {
            if (EstaVazia())
            {
                Console.WriteLine("Lista Vazia");
                return -1;
            }

            if (posicao < 0 || posicao > Tamanho())
            {
                Console.WriteLine("Posicao de Insercao Invalida");
                return -1;
            }

            int valorASerRemovido = elementos[posicao + inicio];

            for (int i = inicio + posicao; i < fim - 1; i++)
            {
                elementos[i] = elementos[i + 1];
            }

            fim--;

            return valorASerRemovido;
        }

        public int RetornarElementoPosicaoEspecifica(int posicao)
        {
            if (posicao < 0 || posicao > Tamanho())
            {
                Console.WriteLine("Posicao Invalida.");
            }

            return elementos[inicio + posicao];
        }

        public void SubstituirElementoPosicaoEspecifica(int posicao, int item)
        {
            if (posicao < 0 || posicao > Tamanho())
            {
                Console.WriteLine("Posicao Invalida.");
            }

            elementos[inicio + posicao] = item;
        }

        public void AdicionarElementoFinal(int item)
        {
            Inserir(item, Tamanho());
        }

        public int RemoverElementoFinal()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Lista Vazia.");
                return -1;
            }

            return Remover(Tamanho() - 1);
        }

        public int RetonarPrimeiraOcorrenciaElemento(int elemento)
        {
            if (EstaVazia())
            {
                Console.WriteLine("Lista VAZIA");
                return -1;
            }

            for (int i = inicio; i < Tamanho(); i++)
            {
                if (elementos[i] == elemento)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool VerificaExistenciaElemento(int elemento)
        {
            if (RetonarPrimeiraOcorrenciaElemento(elemento) != -1)
            {
                return true;
            }

            return false;
        }

        public void ImprimirLista()
        {
            Console.Write("[");
            for (int i = inicio; i < Tamanho() ; i++)
            {
                Console.Write(elementos[i]);
                if (i < fim - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        public void LimparLista()
        {
            fim = inicio = 0;
        }

        public ListaLinear CriarCopiaLista()
        {
            ListaLinear copia = new ListaLinear(this.capacidade);

            for(int i = 0; i < this.fim; i++)
            {
                copia.elementos[i] = this.elementos[i]; 
            }

            copia.fim = this.fim;

            return copia;
        }

        public void InserirInicioLista(int elemento)
        {
            Inserir(elemento, inicio);
        }

        public int RemoverInicioLista()
        {
            return Remover(inicio);
        }

        public int RetonarInicioLista()
        {
            return elementos[inicio];
        }

        public int EncontrarMaiorValor()
        {
            int maiorValor = Int16.MinValue;

            for(int i = 0; i < Tamanho(); i++)
            {
                if (elementos[i] > maiorValor)
                {
                    maiorValor = elementos[i];
                }
            }

            return maiorValor;
        }

        public int EncontrarMenorValor()
        {
            int menorValor = Int16.MaxValue;

            for (int i = 0; i < Tamanho(); i++)
            {
                if (elementos[i] < menorValor)
                {
                    menorValor = elementos[i];
                }
            }

            return menorValor;
        }

        public void ReveterOrdemElementos()
        {
            int esquerda = inicio;
            int direita = fim - 1;

            while (esquerda < direita)
            {
                int temp = elementos[esquerda];
                elementos[esquerda] = elementos[direita];
                elementos[direita] = temp;

                esquerda++;
                direita--;
            }
        }
    }
}
