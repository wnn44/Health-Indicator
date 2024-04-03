using UnityEngine;
using UnityEngine.UI;

public class SliderBarSmooth : Bar
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _maxDelta = 0.1f;

    private int _curentHealth;

    private void Start()
    {
        _slider.minValue = 0;
        _slider.maxValue = Health.MaxValue;

        Display();
    }

    private void Update()
    {
        if (_slider.value != _curentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _curentHealth, _maxDelta);
        }
    }

    public override void Display()
    {
        _curentHealth = Health.CurentValue;
    }
}
