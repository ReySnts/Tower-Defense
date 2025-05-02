using ScriptableObject;
using UnityEngine;

namespace Health
{
    public sealed class HealthEnemy : MonoBehaviour
    {
        [field: SerializeField] public ScriptableObjectHealthEnemy ScriptableObjectHealthEnemy { get; private set; }

        public void Receive(int damage)
        {
            if (ScriptableObjectHealthEnemy.Vital > 0) ScriptableObjectHealthEnemy.Vital -= damage;
            else Destroy(obj: gameObject);
        }
    }
}