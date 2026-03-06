using System;
using System.Collections.Generic;
using System.Text;

namespace Subscription.Domian.Commons
{
    public  abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
