using FluentValidation.Results;
using ProjetoAula06a.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06a.Entities
{
    /// <summary>
    /// Classe de Entidades
    /// </summary>
    public class Contato
    {
        #region
        private Guid _idContato;
        private string? _nome;
        private string? _email;
        private string? _telefone;
        private string? _cpf;

        #endregion

        #region
        public Guid IdContato { get => _idContato; set => _idContato = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? Telefone { get => _telefone; set => _telefone = value; }
        public string? Cpf { get => _cpf; set => _cpf = value; }

        #endregion

        #region Validações

        public ValidationResult Validate => new ContatoValidator().Validate(this);

        #endregion

    }
}
