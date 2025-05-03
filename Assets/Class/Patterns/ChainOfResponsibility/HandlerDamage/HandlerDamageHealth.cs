using Health;
using Projectile;

namespace Patterns.ChainOfResponsibility
{
    public sealed class HandlerDamageHealth : AbstractHandler<AbstractProjectile, HealthEnemy>
    {
        public override void Handle(AbstractProjectile projectile, HealthEnemy healthEnemy)
        {
            var scriptableObjectHealthEnemy = healthEnemy.ScriptableObjectHealthEnemy;
            var scriptableObjectDamageProjectile = projectile.ScriptableObjectDamageProjectile;
            var scriptableObjectHealthEnemyPointHealth = scriptableObjectHealthEnemy.PointHealth;
            if (scriptableObjectHealthEnemyPointHealth > 0) scriptableObjectHealthEnemy.PointHealth -= scriptableObjectDamageProjectile.DamageToHealth;
            else base.Handle(request: projectile, handle: healthEnemy);
        }
    }
}