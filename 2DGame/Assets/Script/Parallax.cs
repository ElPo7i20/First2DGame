using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Transform[] lay;
    [SerializeField] private float coeff;

    private int layersCount;

    public void ChangeBackCoeff(float secondBackCoeff)
    {
        coeff = secondBackCoeff;
    }
    private void Start()
    {
        layersCount = lay.Length;
    }
    public void Update()
    {
        for(int i = 0; i < layersCount; i++)
        {
            lay[i].position = transform.position * coeff;
        }
    }
}
