using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotation;

public class ClienteViewModel
{
    [Key]
	public Guid ClienteId { get; set; } // Guarda o id em formato hidden para ser usado posteriormente. Não guarda via campo.

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
    [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo E-mail")]
    [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
    [EmailAddresses(ErrorMessage = "Preencha um e-mail válido")]
    [DisplayName("E-mail")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Preencha o campo CPF")]
    [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
    [DisplayName("CPF")]
    public string CPF { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
    [DisplayName("Data de Nascimento")]
    public DateTime DataNascimento { get; set; }

    [ScaffoldColumn(false)]
    public DateTime DataCadastro { get; set; }

    [ScaffoldColumn(false)]
    public bool Ativo { get; set; }
}
