using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    /* Customizable */
    [SerializeField]
    private float maxHealth = 100f;
    [SerializeField]
    private HealthBar healthBar;

    /* Variables */
    private float currentHealth;
    [SerializeField]
    private int currentCoins = 0;

    private void Start()
    {
        SetPlayerHealth();
    }

    private void Update()
    {
        healthBar.SetActive(currentHealth, maxHealth);
    }

    private void SetPlayerHealth()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void AddCoins(int coinValue)
    {
        currentCoins += coinValue;
    }

    public int GetCoins()
    {
        return currentCoins;
    }
}
