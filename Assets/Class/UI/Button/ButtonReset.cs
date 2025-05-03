using Health;
using ScriptableObject;
using UnityEngine;

namespace UI.Button
{
    public sealed class ButtonReset : AbstractButton
    {
        [SerializeField] private HealthEnemy healthEnemy;

        private ScriptableObjectHealthEnemy scriptableObjectHealthEnemy;

        private int pointArmor;

        private int pointHealth;

        private int pointVital;

        protected override void Start()
        {
            base.Start();
            scriptableObjectHealthEnemy = healthEnemy.ScriptableObjectHealthEnemy;
            pointArmor = scriptableObjectHealthEnemy.PointArmor;
            pointHealth = scriptableObjectHealthEnemy.PointHealth;
            pointVital = scriptableObjectHealthEnemy.PointVital;
        }

        protected override void OnClick()
        {
            scriptableObjectHealthEnemy.PointArmor = pointArmor;
            scriptableObjectHealthEnemy.PointHealth = pointHealth;
            scriptableObjectHealthEnemy.PointVital = pointVital;
        }
    }
}