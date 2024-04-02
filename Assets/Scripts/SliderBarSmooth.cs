using UnityEngine;
using UnityEngine.UI;

public class SliderBarSmooth : Bar
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _maxDelta = 0.1f;

    private void Start()
    {
        _slider.minValue = 0;
        _slider.maxValue = Health.MaxHealth;

        Display();
    }

    private void Update()
    {
        if (_slider.value != CurentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, CurentHealth, _maxDelta);
        }
    }

    public override void Display()
    {
        CurentHealth = Health.CurentHealth;
    }
}
