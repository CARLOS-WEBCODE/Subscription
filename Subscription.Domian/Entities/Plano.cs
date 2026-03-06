using Subscription.Domain.Enums;
using Subscription.Domian.Commons;

namespace Subscription.Domain.Entities
{
    public class Plano : BaseEntity
    {
        #region Propriedades
        public string Nome { get; set; } = string.Empty;
        public decimal ValorMensal { get; set; }
        public Periodicidade? Periodicidade { get; set; }
        public bool Ativo { get; set; }
        #endregion

        #region Relacionamentos

        public ICollection<Assinatura>? Assinaturas { get; set; }

        #endregion
    }
}
