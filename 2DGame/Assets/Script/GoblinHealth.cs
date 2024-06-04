using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoblinHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    [SerializeField] private GameObject killsCounter;

    private float currentHealth;

    [SerializeField] private Animator anim;

    private bool alive;

    [SerializeField] private GameObject goblin;

    private int killsCount;

    private void Awake()
    {
        currentHealth = maxHealth;
        alive = true;
        killsCount = 0;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        anim.SetBool("Damage", true);
        CheckHealth();
    }
    public void CheckHealth()
    {
        if (currentHealth > 0)
        {
            alive = true;
        }
        else
        {
            alive = false;
        }
        CheckAlive();
    }
    public void CheckAlive()
    {
        if (alive == false)
        {
            goblin.SetActive(false);
            killsCount += 1;
            killsCounter.GetComponent<KillsCount>().UpdateKillsCountText(killsCount);
        }
    }
}
