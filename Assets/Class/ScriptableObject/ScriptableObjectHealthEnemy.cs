using Const;
using UnityEngine;

namespace ScriptableObject
{
    [CreateAssetMenu(fileName = NameFile.HEALTH_ENEMY, menuName = NameMenu.SCRIPTABLE_OBJECT + NameMenu.HEALTH_ENEMY)]

    public sealed class ScriptableObjectHealthEnemy : UnityEngine.ScriptableObject
    {
        [field: SerializeField, Space(height: 10f)] public int PointArmor { get; set; }

        [field: SerializeField, Space(height: 10f)] public int PointHealth { get; set; }

        [field: SerializeField, Space(height: 10f)] public int PointVital { get; set; }
    }
}