using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;

    private void Start()
    {
        Destroy(gameObject, 4f);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * 1.5f * speed * Time.deltaTime;
    }
}
