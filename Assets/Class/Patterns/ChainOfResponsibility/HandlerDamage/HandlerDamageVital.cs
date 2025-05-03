using Health;
using Projectile;

namespace Patterns.ChainOfResponsibility
{
    public sealed class HandlerDamageVital : AbstractHandler<AbstractProjectile, HealthEnemy>
    {
        public override void Handle(AbstractProjectile projectile, HealthEnemy healthEnemy) => healthEnemy.Receive(damage: projectile.ScriptableObjectDamageProjectile.DamageToVital);
    }
}