using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

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

        Display();
    }

    public void Display()
    {
        _curentHealth = _health.CurentHealth;

        _text.text = _curentHealth.ToString() + "/" + _health.MaxHealth.ToString();
    }
}
