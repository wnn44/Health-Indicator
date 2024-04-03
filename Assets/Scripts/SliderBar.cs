using UnityEngine;
using UnityEngine.UI;

public class SliderBar : Bar
{
    [SerializeField] private Slider _slider;

    private float _curentHealth;

    private void Start()
    {
        Display();
    }

    public override void Display()
    {
        _curentHealth = Health.CurentValue;

        _slider.value = _curentHealth / Health.MaxValue;
    }
}