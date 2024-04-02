using TMPro;
using UnityEngine;

public class TextBar : Bar
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        Display();
    }

    public override void Display()
    {
        CurentHealth = Health.CurentHealth;

        _text.text = CurentHealth.ToString() + "/" + Health.MaxHealth.ToString();
    }
}
