using Subscription.Domain.Enums;
using Subscription.Domian.Commons;

namespace Subscription.Domain.Entities
{
    public class Assinatura : BaseEntity
    {
        #region Propriedades

        public Guid ClienteId { get; set; }
        public Guid PlanoId { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; }
        public decimal Valor { get; set; }
        public StatusAssinatura Status { get; set; } = StatusAssinatura.Ativa;

        #endregion

        #region Relacionamentos
        public Cliente? Cliente { get; set; }
        public Plano? Plano { get; set; }
        #endregion
    }
}
