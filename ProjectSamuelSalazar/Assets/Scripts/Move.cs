using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    public float horizontalInput;
    public float verticalInput;
    public GameObject MiObjeto;

    void Start()
    {

    }
    void cambiaMiObjeto() 
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(-(Vector3.right * Time.deltaTime * speed * horizontalInput));

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(-(Vector3.forward * Time.deltaTime * speed * verticalInput));

        //Limite del escenario
        if(transform.position.z > 15.2f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 15.2f);
        }

        if(transform.position.z < -14.1f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -14.1f);
        }

        if(transform.position.x > 8.11f){
            transform.position = new Vector3(8.11f, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -7.2f){
            transform.position = new Vector3(-7.2f, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(MiObjeto,transform.position, Quaternion.identity);
            cambiaMiObjeto();
        }
    }
    

}
