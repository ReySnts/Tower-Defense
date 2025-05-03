using Const;
using Projectile;
using ScriptableObject;
using UnityEngine;

namespace Health
{
    [RequireComponent(requiredComponent: typeof(Rigidbody))]

    public sealed class HealthEnemy : MonoBehaviour
    {
        [field: SerializeField] public ScriptableObjectHealthEnemy ScriptableObjectHealthEnemy { get; private set; }

        public void Receive(int damage)
        {
            if (ScriptableObjectHealthEnemy.PointVital > 0) ScriptableObjectHealthEnemy.PointVital -= damage;
            //else Destroy(obj: gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(tag: Tag.PROJECTILE))
            {
                var projectile = other.GetComponent<AbstractProjectile>();
                projectile.DealDamage(healthEnemy: this);
                Destroy(obj: other.gameObject);
            }
        }
    }
}