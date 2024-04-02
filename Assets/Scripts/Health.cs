using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _curentHealth;

    public event Action HealthChanged;

    public int MaxHealth => _maxHealth;
    public int CurentHealth => _curentHealth;

    public void TakeDamage(int damageValue)
    {
        _curentHealth -= damageValue;

        _curentHealth = Mathf.Clamp(_curentHealth, 0, _maxHealth);

        HealthChanged?.Invoke();
    }

    public void TakeHeal(int healValue)
    {
        _curentHealth += healValue;

        _curentHealth = Mathf.Clamp(_curentHealth, 0, _maxHealth);

        HealthChanged?.Invoke();
    }
}
