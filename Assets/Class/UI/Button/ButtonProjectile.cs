using UnityEngine;

namespace UI.Button
{
    public sealed class ButtonProjectile : AbstractButton
    {
        [SerializeField] private GameObject original;

        [SerializeField] private Transform parent;

        protected override void OnClick() => Instantiate(original, parent);
    }
}