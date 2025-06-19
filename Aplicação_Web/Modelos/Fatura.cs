using Microsoft.EntityFrameworkCore;

namespace Aplicação_Web.Models
{
    // Modelo de Fatura
    public class Fatura
    {

        // Chave Primária
        public int Id { get; set; }

        // Detalhes da Fatura
        public string Numero { get; set; } = "";
        public string Estado { get; set; } = ""; // Pago ou Pendente
        public DateOnly? DataEmissao { get; set; }
        public DateOnly? DataVencimento { get; set; }

        // Detalhes do Serviço
        public string Servico { get; set; } = "";
        [Precision(16, 2)]
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        // Detalhes do Cliente
        public string NomeCliente { get; set; } = "";
        public string EmailCliente { get; set; } = "";
        public string TelefoneCliente { get; set; } = "";
        public string EnderecoCliente { get; set; } = "";

    }
}
