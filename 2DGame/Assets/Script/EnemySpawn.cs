using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject Enemy;

    [SerializeField] private GameObject appearance;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Body")
        Enemy.SetActive(true);
        appearance.SetActive(true);
    }
}
