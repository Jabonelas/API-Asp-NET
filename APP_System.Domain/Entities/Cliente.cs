using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_System.Domain.Validation;

namespace APP_System.Domain.Entities
{
    public class Cliente
    {
        public int idAtor { get; private set; }

        public string atCnpj { get; private set; }

        public string atCpf { get; private set; }

        public string atRgRne { get; private set; }

        public string atRazSoc { get; private set; }

        public string atNomeFant { get; private set; }

        public Cliente(int _idAtor, string _atCnpj, string _atCpf, string _atRgRne, string _atRazSoc, string _atNomeFant)
        {
            DomainExcepitionValidation.When(_atNomeFant.Length < 0, "O id nao pode ser menor que zero!");
            idAtor = _idAtor;
            ValidateDomain(_atCnpj, _atCpf, _atRgRne, _atRazSoc, _atNomeFant);
        }

        public Cliente(string _atCnpj, string _atCpf, string _atRgRne, string _atRazSoc, string _atNomeFant)
        {
            ValidateDomain(_atCnpj, _atCpf, _atRgRne, _atRazSoc, _atNomeFant);
        }

        public void Update(string _atCnpj, string _atCpf, string _atRgRne, string _atRazSoc, string _atNomeFant)
        {
            ValidateDomain(_atCnpj, _atCpf, _atRgRne, _atRazSoc, _atNomeFant);
        }

        public void ValidateDomain(string _atCnpj, string _atCpf, string _atRgRne, string _atRazSoc, string _atNomeFant)
        {
            DomainExcepitionValidation.When(_atNomeFant.Length <= 10, "O nome tem que ter no minimo 10 caracteres!!");

            atCnpj = _atCnpj;
            atCpf = _atCpf;
            atRgRne = _atRgRne;
            atRazSoc = _atRazSoc;
            atNomeFant = _atNomeFant;
        }
    }
}