using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private HealthSystem healthSystem;

    private int _curentHealth;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
    }

    private void Update()
    {
        _curentHealth = healthSystem.CurentHealth;

        DisplayTextBar();
    }

    public void DisplayTextBar()
    {
        _text.text = _curentHealth.ToString() + "/" + healthSystem.MaxHealth.ToString();
    }
}
