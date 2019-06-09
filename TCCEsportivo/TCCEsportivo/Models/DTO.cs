using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCCEsportivo.Models
{
    public class DTO
    {
        public string CodCli { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado.!")]
        [StringLength(50, MinimumLength = 5)]
        public string NomeCli { get; set; }

        [Required(ErrorMessage = "O cpf deve ser informado.!")]
        [StringLength(50, MinimumLength = 8)]
        public string CpfCli { get; set; }

        [Required(ErrorMessage = "O email é obrigatorio!")]
        [DataType(DataType.EmailAddress)]
        public string EmailCli { get; set; }

        [Required(ErrorMessage = "O telefone deve ser informado.!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (000) 000-0000")]
        [DisplayName("Número do Telefone")]
        public string TelCli { get; set; }

        [Required(ErrorMessage = "A data de nascimento deve ser informada.!")]
        [DataType(DataType.Date, ErrorMessage = "Forneça a sua data de nascimento no formato AAAA/MM/DD")]
        [DisplayName("Data de nascimento")]
        public string DataCli { get; set; }


        [Required(ErrorMessage = "O genero deve ser informado.!")]
        [StringLength(50, MinimumLength = 5)]
        public string GeneCli { get; set; }


      


        private string CodFunc;
        private string NomeFunc;
        private string CpfFunc;
        private string TelFunc;
        private string DTFunc;
        private string CarFunc;

        

        public string CodFunc1 { get => CodFunc; set => CodFunc = value; }
        public string NomeFunc1 { get => NomeFunc; set => NomeFunc = value; }
        public string CpfFunc1 { get => CpfFunc; set => CpfFunc = value; }
        public string TelFunc1 { get => TelFunc; set => TelFunc = value; }
        public string DTFunc1 { get => DTFunc; set => DTFunc = value; }
        public string CarFunc1 { get => CarFunc; set => CarFunc = value; }
        

        private string cepEnd;
        private string lograEnd;
        private string bairroEnd;
        private string cidaEnd;
        private string numcasaEnd;
        private string compEnd;

        public string CepEnd { get => cepEnd; set => cepEnd = value; }
        public string LograEnd { get => lograEnd; set => lograEnd = value; }
        public string BairroEnd { get => bairroEnd; set => bairroEnd = value; }
        public string CidaEnd { get => cidaEnd; set => cidaEnd = value; }
        public string NumcasaEnd { get => numcasaEnd; set => numcasaEnd = value; }
        public string CompEnd { get => compEnd; set => compEnd = value; }


    }
}