using Const;
using UnityEngine;

namespace ScriptableObject
{
    [CreateAssetMenu(fileName = NameFile.HEALTH_ENEMY, menuName = NameMenu.SCRIPTABLE_OBJECT + NameMenu.HEALTH_ENEMY)]

    public sealed class ScriptableObjectHealthEnemy : UnityEngine.ScriptableObject
    {
        [field: SerializeField, Space(height: 10f)] public int Armor { get; set; }

        [field: SerializeField, Space(height: 10f)] public int Health { get; set; }

        [field: SerializeField, Space(height: 10f)] public int Vital { get; set; }
    }
}