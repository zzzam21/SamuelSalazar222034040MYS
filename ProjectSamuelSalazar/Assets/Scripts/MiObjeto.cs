using Unity.VisualScripting;
using UnityEngine;

public class MiObjeto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z < -14.1f)
        {
            Destroy(this.gameObject);
        }

     
    }
}
