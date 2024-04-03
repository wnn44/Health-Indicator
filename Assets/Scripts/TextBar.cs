using TMPro;
using UnityEngine;

public class TextBar : Bar
{
    [SerializeField] private TextMeshProUGUI _text;

    private float _curentHealth;

    private void Start()
    {
        Display();
    }

    public override void Display()
    {
        _curentHealth = Health.CurentValue;

        _text.text = _curentHealth.ToString() + "/" + Health.MaxValue.ToString();
    }
}
