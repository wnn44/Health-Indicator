using UnityEngine;
using UnityEngine.UI;

public class SliderBarSmooth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] float maxDelta = 0.1f;

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
        float value = Mathf.MoveTowards(_slider.value, _curentHealth, maxDelta);
        _slider.value = value;
    }
}
