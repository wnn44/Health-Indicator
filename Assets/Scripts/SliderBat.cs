using UnityEngine;
using UnityEngine.UI;

public class SliderBat : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Health _health;

    private int _curentHealth;

    private void OnEnable()
    {
        Health.HealthChanged += DisplaySliderBar;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= DisplaySliderBar;
    }

    private void Start()
    {
        _health = GetComponent<Health>();

        _slider.minValue = 0;
        _slider.maxValue = _health.MaxHealth;

        DisplaySliderBar();
    }

    private void DisplaySliderBar()
    {
        _curentHealth = _health.CurentHealth;

        _slider.value = _curentHealth;
    }
}