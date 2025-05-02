using Health;
using UnityEngine;

namespace Projectile
{
    public abstract class AbstractProjectile : MonoBehaviour
    {
        [SerializeField] protected int damage;

        public abstract void DealDamage(HealthEnemy healthEnemy);
    }
}