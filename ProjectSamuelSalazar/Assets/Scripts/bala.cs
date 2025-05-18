using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 15.0f;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z > 29.9f)
        {
            Destroy(this.gameObject);
        }

    }

}
