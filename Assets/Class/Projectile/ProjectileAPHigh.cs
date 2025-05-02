using Health;
using Patterns.ChainOfResponsibility;

namespace Projectile
{
    public sealed class ProjectileAPHigh : AbstractProjectile
    {
        public override void DealDamage(HealthEnemy healthEnemy)
        {
            var damageHandler = new HandlerDamageHealth(healthEnemy).Chain(new HandlerDamageVital(healthEnemy));
            damageHandler.Handle(damage);
        }
    }
}