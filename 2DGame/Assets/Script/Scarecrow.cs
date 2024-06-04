using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarecrow : MonoBehaviour
{
    [SerializeField] private GameObject scareCrow;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Body")
        {
            scareCrow.GetComponent<PointEffector2D>().forceMagnitude = 150;
        }
    }
}
