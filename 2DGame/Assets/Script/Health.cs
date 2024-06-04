using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float currentHealth;
    private bool alive;
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject firstHeart;
    [SerializeField] private GameObject secondHeart;
    [SerializeField] private GameObject endPannel;
    private void Awake()
    {
        currentHealth = maxHealth;
        alive = true;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        CheckHealth();
    }
    public void CheckHealth()
    {
        if(currentHealth > 0)
        {
            alive = true;
        }
        else
        {
            alive = false;
        }
        if (currentHealth <= 50)
        {
            secondHeart.SetActive(false);
        }
        CheckAlive();
    }
    public void CheckAlive()
    {
        if (alive == false)
        {
            character.SetActive(false);
            firstHeart.SetActive(false);
            endPannel.SetActive(true);
        }
    }
}
