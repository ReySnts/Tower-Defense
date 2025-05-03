using Health;
using Patterns.ChainOfResponsibility;
using UnityEngine;

namespace Projectile
{
    public sealed class ProjectileAPHigh : AbstractProjectile
    {
        [SerializeField] private AbstractHandler<AbstractProjectile, HealthEnemy> handlerDamageHealth;

        [SerializeField] private AbstractHandler<AbstractProjectile, HealthEnemy> handlerDamageVital;

        public override void DealDamage(HealthEnemy healthEnemy)
        {
            handlerDamageHealth.Chain(handlerNext: handlerDamageVital);
            handlerDamageHealth.Handle(request: this, handle: healthEnemy);
        }
    }
}