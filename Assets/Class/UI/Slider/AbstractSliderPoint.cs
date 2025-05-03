using Health;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Slider
{
    [RequireComponent(requiredComponent: typeof(UnityEngine.UI.Slider))]

    public abstract class AbstractSliderPoint : MonoBehaviour
    {
        [SerializeField] protected HealthEnemy healthEnemy;

        [SerializeField] private Color fillImageColor;

        [SerializeField] private Image fillImage;

        protected abstract int PointType { get; }

        private UnityEngine.UI.Slider slider;

        protected void Start()
        {
            slider = GetComponent<UnityEngine.UI.Slider>();
            fillImage.color = fillImageColor;
            slider.minValue = 0;
            slider.maxValue = PointType;
        }

        protected void Update() => slider.value = PointType;
    }
}