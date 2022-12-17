using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaApp
{
    class Academia
    {
        private int aux = 1;
        private string nome;
        private string endereco;
        private Esporte[] esportes;
        private int contador;
        public double media;
        public int quantidade;
        public Academia(string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
            esportes = new Esporte[aux];
        }
        public void Inserir(Esporte e)
        {
            if (contador == aux)
            {
                Array.Resize(ref esportes, esportes.Length + 1);
                aux++;

            }
            if (contador < aux)
            {
                esportes[contador] = e;
                contador++;

            }
        }
        public Esporte[] Listar()
        {
            Esporte[] i = new Esporte[contador];
            Array.Copy(esportes, i, contador);
            return i;
        }
        public double MediaMensalidade() {
            return media/quantidade;
        }
        public override string ToString()
        {
            return $"{nome} - {endereco}";
        }
    }
    class Esporte
    {
        private string nome;
        private string horarios;
        private double mensalidade;
        public Esporte(string nome, string horarios, double mensalidade)
        {
            this.nome = nome;
            this.horarios = horarios;
            this.mensalidade = mensalidade;
        }
        public override string ToString()
        {
            return $"{nome} / {horarios} / {mensalidade} R$";
        }
    }
}
