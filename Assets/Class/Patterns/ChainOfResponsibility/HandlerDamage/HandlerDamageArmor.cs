using Health;
using Projectile;

namespace Patterns.ChainOfResponsibility
{
    public sealed class HandlerDamageArmor : AbstractHandler<AbstractProjectile, HealthEnemy>
    {
        public override void Handle(AbstractProjectile projectile, HealthEnemy healthEnemy)
        {
            var scriptableObjectHealthEnemy = healthEnemy.ScriptableObjectHealthEnemy;
            var scriptableObjectDamageProjectile = projectile.ScriptableObjectDamageProjectile;
            var scriptableObjectHealthEnemyPointArmor = scriptableObjectHealthEnemy.PointArmor;
            if (scriptableObjectHealthEnemyPointArmor > 0) scriptableObjectHealthEnemy.PointArmor -= scriptableObjectDamageProjectile.DamageToArmor;
            else base.Handle(request: projectile, handle: healthEnemy);
        }
    }
}