using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Slider _slider1;
    [SerializeField] private Slider _slider2;
    [SerializeField] private float _maxHealth=100;
    [SerializeField] private float _damage = 10;
    [SerializeField] private float _addHealth = 20;
    [SerializeField] private float _maxDelta = 0.1f;

    private float _curentHealth;

    private void Start()
    {
        _curentHealth = _maxHealth;

        _slider1.minValue = 0;
        _slider1.maxValue = _maxHealth;

        _slider2.minValue = 0;
        _slider2.maxValue = _maxHealth;
    }

    private void Update()
    {
        DisplayTextBar();
        DisplaySliderBar1();
        DisplaySliderBar2();
    }

    private void DisplayTextBar()
    {
        _text.text = _curentHealth.ToString() + "/" + _maxHealth.ToString();
    }

    private void DisplaySliderBar1()
    {
        _slider1.value = _curentHealth;
    }

    private void DisplaySliderBar2()
    {
        float value = Mathf.MoveTowards(_slider2.value, _curentHealth, _maxDelta);
        _slider2.value = value;
    }

    public void Damage()
    {
        _curentHealth -= _damage;

        if(_curentHealth < 0 )
            _curentHealth = 0;
    }

    public void AddHealth()
    {
        _curentHealth += _addHealth;

        if(_curentHealth > _maxHealth)
            _curentHealth = _maxHealth;
    }
}
