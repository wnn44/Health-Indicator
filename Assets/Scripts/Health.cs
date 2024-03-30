using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _curentHealth;

    public static event Action HealthChanged;

    public int MaxHealth { get { return _maxHealth; } }
    public int CurentHealth { get { return _curentHealth; } }

    public void Damage(int damageValue)
    {
        _curentHealth -= damageValue;

        _curentHealth = Mathf.Clamp(_curentHealth, 0, _maxHealth);

        HealthChanged?.Invoke();
    }

    public void Heal(int healValue)
    {
        _curentHealth += healValue;

        _curentHealth = Mathf.Clamp(_curentHealth, 0, _maxHealth);

        HealthChanged?.Invoke();
    }
}
