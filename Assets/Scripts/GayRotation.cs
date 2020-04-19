using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayRotation : MonoBehaviour
{
    public float dayRotSpeed = 40.0f;
    public float rotSpeed = 150.0f;

    Vector3 vector;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            transform.Rotate(Vector3.up * dayRotSpeed * Time.deltaTime);


    }
}
