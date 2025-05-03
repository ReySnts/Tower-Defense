using Health;
using ScriptableObject;
using UnityEngine;

namespace Projectile
{
    [RequireComponent(requiredComponent: typeof(Rigidbody))]

    public abstract class AbstractProjectile : MonoBehaviour
    {
        [field: SerializeField] public ScriptableObjectDamageProjectile ScriptableObjectDamageProjectile { get; private set; }

        [SerializeField] private float speed = 100f;

        private Rigidbody rigidBody;

        public abstract void DealDamage(HealthEnemy healthEnemy);

        private void Start() => rigidBody = GetComponent<Rigidbody>();

        private void FixedUpdate() => rigidBody.velocity = Vector3.right * speed * Time.deltaTime;
    }
}