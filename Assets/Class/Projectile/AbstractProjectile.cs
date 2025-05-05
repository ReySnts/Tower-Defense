using Health;
using ScriptableObject;
using UnityEngine;

namespace Projectile
{
    public abstract class AbstractProjectile : MonoBehaviour
    {
        [field: SerializeField] public ScriptableObjectDamageProjectile ScriptableObjectDamageProjectile { get; private set; }

        public abstract void DealDamage(HealthEnemy healthEnemy);
    }
}