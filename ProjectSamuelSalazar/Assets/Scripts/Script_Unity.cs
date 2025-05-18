using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Unity : MonoBehaviour
{
    public float posx = -21.3f;
    public float posy = 0.7449418f;
    public float posz = 29.9f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(posx,posy,posz);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello world Unity Engine");
    }
}
