using UnityEngine;
using UnityEngine.UI;

public class SliderBar : Bar
{
    [SerializeField] private Slider _slider;

    private int _curentHealth;

    private void Start()
    {
        _slider.minValue = 0;
        _slider.maxValue = Health.MaxValue;

        Display();
    }

    public override void Display()
    {
        _curentHealth = Health.CurentValue;

        _slider.value = _curentHealth;
    }
}