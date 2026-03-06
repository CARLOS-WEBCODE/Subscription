using Subscription.Domain.Enums;
using Subscription.Domian.Commons;
using Subscription.Domian.ValueObjects;

namespace Subscription.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        #region Propriedades
        public string Nome { get; set; } = string.Empty;
        public Email? Email { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public StatusCliente Status { get; set; } = StatusCliente.Ativo;
        #endregion

        #region Relacionamentos
        public ICollection<Assinatura>? Assinaturas { get; set; }
        #endregion

    }

}
