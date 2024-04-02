using UnityEngine;
using UnityEngine.UI;

public class SliderBarSmooth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _maxDelta = 0.1f;

    private Health _health;

    private int _curentHealth;

    private void OnEnable()
    {
        _health.HealthChanged += Display;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= Display;
    }

    private void Awake()
    {
        _health = GetComponent<Health>();

        _slider.minValue = 0;
        _slider.maxValue = _health.MaxHealth;

        Display();
    }

    private void Update()
    {
        if (_slider.value != _curentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _curentHealth, _maxDelta);
        }
    }

    private void Display()
    {
        _curentHealth = _health.CurentHealth;
    }
}
