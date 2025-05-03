using Health;
using Patterns.ChainOfResponsibility;
using UnityEngine;

namespace Projectile
{
    public sealed class ProjectileSpecial : AbstractProjectile
    {
        [SerializeField] private AbstractHandler<AbstractProjectile, HealthEnemy> handlerDamageArmor;

        [SerializeField] private AbstractHandler<AbstractProjectile, HealthEnemy> handlerDamageVital;

        public override void DealDamage(HealthEnemy healthEnemy)
        {
            handlerDamageArmor.Chain(handlerNext: handlerDamageVital);
            handlerDamageArmor.Handle(request: this, handle: healthEnemy);
        }
    }
}