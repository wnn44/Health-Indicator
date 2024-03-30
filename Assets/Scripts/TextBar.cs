using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private Health _health;

    private int _curentHealth;

    private void OnEnable()
    {
        Health.HealthChanged += DisplayTextBar;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= DisplayTextBar;
    }

    private void Start()
    {
        _health = GetComponent<Health>();

        DisplayTextBar();
    }

    public void DisplayTextBar()
    {
        _curentHealth = _health.CurentHealth;

        _text.text = _curentHealth.ToString() + "/" + _health.MaxHealth.ToString();
    }
}
