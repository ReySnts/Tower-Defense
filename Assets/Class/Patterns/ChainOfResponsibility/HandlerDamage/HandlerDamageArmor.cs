using Health;

namespace Patterns.ChainOfResponsibility
{
    public class HandlerDamageArmor : AbstractHandler<HealthEnemy, int>
    {
        public HandlerDamageArmor(HealthEnemy healthEnemy) : base(healthEnemy) { }

        public override void Handle(int damage)
        {
            var scriptableObjectHealthEnemy = request.ScriptableObjectHealthEnemy;
            if (scriptableObjectHealthEnemy.Armor <= 0) nextHandler.Handle(damage);
            else scriptableObjectHealthEnemy.Armor -= damage;
        }
    }
}