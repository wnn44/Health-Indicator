using UnityEngine;
using UnityEngine.UI;

public class SliderBat : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private HealthSystem healthSystem;

    private int _curentHealth;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();

        _slider.minValue = 0;
        _slider.maxValue = healthSystem.MaxHealth;
    }

    private void Update()
    {
        _curentHealth = healthSystem.CurentHealth;

        DisplaySliderBar();
    }

    private void DisplaySliderBar()
    {
        _slider.value = _curentHealth;
    }
}