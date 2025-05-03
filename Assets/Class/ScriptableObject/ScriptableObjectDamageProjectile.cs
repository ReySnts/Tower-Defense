using Const;
using UnityEngine;

namespace ScriptableObject
{
    [CreateAssetMenu(fileName = NameFile.DAMAGE_PROJECTILE, menuName = NameMenu.SCRIPTABLE_OBJECT + NameMenu.DAMAGE_PROJECTILE)]

    public class ScriptableObjectDamageProjectile : UnityEngine.ScriptableObject
    {
        [field: SerializeField, Space(height: 10f)] public int DamageToArmor { get; set; }

        [field: SerializeField, Space(height: 10f)] public int DamageToHealth { get; set; }

        [field: SerializeField, Space(height: 10f)] public int DamageToVital { get; set; }
    }
}