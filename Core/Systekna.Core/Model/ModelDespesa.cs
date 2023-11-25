using Systekna.Core.Entities.Base;

namespace Systekna.Core.Model
{
    public class ModelDespesa : EntityBase
    {
        public double VlrDespesa { get; set; }
        public string DsDespesa { get; set; } = string.Empty;

        private StatusPagamento _statusPagamento = StatusPagamento.Aberto;
        private DateTime _dataVencimento = DateTime.Now;

        public DateTime DtVencimento { get { return _dataVencimento; } set { _dataVencimento = value; } }
        public StatusPagamento IdStatusPagamento { get { return _statusPagamento; } set { _statusPagamento = value; } }
    }
}