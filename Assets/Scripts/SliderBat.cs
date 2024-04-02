using UnityEngine;
using UnityEngine.UI;

public class SliderBat : Bar
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.minValue = 0;
        _slider.maxValue = Health.MaxHealth;

        Display();
    }

    public override void Display()
    {
        CurentHealth = Health.CurentHealth;

        _slider.value = CurentHealth;
    }
}