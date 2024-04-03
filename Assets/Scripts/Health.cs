using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxValue;
    [SerializeField] private int _curentValue;

    public event Action Changed;

    public int MaxValue => _maxValue;
    public int CurentValue => _curentValue;

    public void TakeDamage(int damageValue)
    {
        _curentValue -= damageValue;

        _curentValue = Mathf.Clamp(_curentValue, 0, _maxValue);

        Changed?.Invoke();
    }

    public void TakeHeal(int healValue)
    {
        _curentValue += healValue;

        _curentValue = Mathf.Clamp(_curentValue, 0, _maxValue);

        Changed?.Invoke();
    }
}
