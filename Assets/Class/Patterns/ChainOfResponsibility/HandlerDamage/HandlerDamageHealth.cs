using Health;

namespace Patterns.ChainOfResponsibility
{
    public class HandlerDamageHealth : AbstractHandler<HealthEnemy, int>
    {
        public HandlerDamageHealth(HealthEnemy healthEnemy) : base(healthEnemy) { }

        public override void Handle(int damage)
        {
            var scriptableObjectHealthEnemy = request.ScriptableObjectHealthEnemy;
            if (scriptableObjectHealthEnemy.Health <= 0) nextHandler.Handle(damage);
            else scriptableObjectHealthEnemy.Health -= damage;
        }
    }
}