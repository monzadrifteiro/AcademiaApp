using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaApp
{
    class Academia
    {
        private string nome;
        private string endereco;
        private Esporte[] esportes;
        private int contador;
        public Academia(string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
            esportes = new Esporte[5];
        }
        public void Inserir(Esporte e)
        {
            if (contador < 5)
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
        //public double MediaMensalidade() {
        //  
        //}
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