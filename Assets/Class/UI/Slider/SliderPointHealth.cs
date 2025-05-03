namespace UI.Slider
{
    public sealed class SliderPointHealth : AbstractSliderPoint
    {
        protected override int PointType => healthEnemy.ScriptableObjectHealthEnemy.PointHealth;
    }
}