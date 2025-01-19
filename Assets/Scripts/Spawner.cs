using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public birdFly birdScript;

    public GameObject Borular;

    public float height;

    public float time;



    private void Start()
    {
        StartCoroutine(SpawnObject(time*0.75f));
    }


    public IEnumerator SpawnObject(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
