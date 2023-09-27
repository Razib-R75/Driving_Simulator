using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapobj : MonoBehaviour
{
    public GameObject[] Animel;
    private float swrange = 20;
    private float Zsrange = 20;
    private float dilye = 2.0f;
    private float interval = 1.5f;
    void Start()
    {
        InvokeRepeating("swaprandom", dilye, interval);

    }
    void Update()
    {
       
    }
    void swaprandom()
    {
        int Animelintex = Random.Range(0, Animel.Length);
        
        Vector3 Swapobj = new Vector3(Random.Range(-swrange, swrange), 0, Zsrange);

        Instantiate(Animel[Animelintex], Swapobj, Animel[Animelintex].transform.rotation);
    }
}
