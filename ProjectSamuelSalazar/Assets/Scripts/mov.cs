using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    [SerializeField]
    public float speed = 10f;

    public float horizontalInput;
    public float verticalInput;

    public GameObject bala;
    public GameObject bala2;

    public bool cambiaObjeto = false;



    private Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiaMiObjeto();
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime  * horizontalInput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);



        // Límite del escenario
        if (transform.position.x < -21.3f) { 
            transform.position = new Vector3(-21.3f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 14.1f) {
            transform.position = new Vector3(14.1f, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -31.07f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -31.07f);
        }

        if (transform.position.z > 29.9f) { 
            transform.position = new Vector3(transform.position.x, transform.position.y, 29.9f);
        }
    }

    private void CambiaMiObjeto()
    {
        GameObject objeto = cambiaObjeto ? bala2 : bala;
        Instantiate(objeto, transform.position, Quaternion.identity);
    }

}

