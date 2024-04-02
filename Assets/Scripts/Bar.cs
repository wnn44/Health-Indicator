using UnityEngine;

public class Bar : MonoBehaviour
{
    protected Health Health;
    protected int CurentHealth;

    private void OnEnable()
    {
        Health.HealthChanged += Display;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= Display;
    }

    private void Awake()
    {
        Health = GetComponent<Health>();
    }

    public virtual void Display() { }
}
