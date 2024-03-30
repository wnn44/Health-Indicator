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

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _curentHealth, _maxDelta);
    }

    private void DisplaySliderBar()
    {
        _curentHealth = _health.CurentHealth;
    }
}
