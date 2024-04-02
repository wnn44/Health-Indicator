using UnityEngine;
using UnityEngine.UI;

public class SliderBat : MonoBehaviour
{
    [SerializeField] private Slider _slider;

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

    private void Display()
    {
        _curentHealth = _health.CurentHealth;

        _slider.value = _curentHealth;
    }
}