using Health;

namespace Patterns.ChainOfResponsibility
{
    public class HandlerDamageVital : AbstractHandler<HealthEnemy, int>
    {
        public HandlerDamageVital(HealthEnemy healthEnemy) : base(healthEnemy) { }

        public override void Handle(int damage)
        {
            if (request.ScriptableObjectHealthEnemy.Vital <= 0) nextHandler.Handle(damage);
            else request.Receive(damage);
        }
    }
}