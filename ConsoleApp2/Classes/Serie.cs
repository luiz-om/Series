using Seriess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seriess.Classes
{
    public class Serie : EntidadeBase //: faz herdar da classe a frente
    {
        //id ja esta herdando da classe EntidadeBase 
        private Genero Genero { get; set; }

        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + this.Descricao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Exclui()
        {
            this.Excluido = true;
        }

    }
}
