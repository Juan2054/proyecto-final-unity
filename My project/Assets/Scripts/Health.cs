using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int lifePoints = 100;

    private int MAX_HEALTH = 100;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Damage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(10);
        }

    }

    public void SetHealth(int maxHealth, int lifePoints)
    {
        this.MAX_HEALTH = maxHealth;
        this.lifePoints = lifePoints;
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.lifePoints -= amount;

        if(lifePoints <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Healing");
        }

        bool OverMaxHealth = lifePoints + amount > MAX_HEALTH;

        if (OverMaxHealth)
        {
            this.lifePoints = MAX_HEALTH;
        }
        else
        {
            this.lifePoints += amount;
        }
    }

    public void Die()
    {
        Debug.Log("I am Dead");
        Destroy(gameObject);
    }
}
