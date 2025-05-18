using UnityEngine;

public class Test_class : MonoBehaviour
{

    public float posx = -0.85f;
    public float posy = 2.26f;
    public float posz = 13.69f;

    void Start()
    {
        //Debug.Log("Mi nombre es " + name);
        //Debug.Log("Posici�n en X: " + transform.position.x);

        transform.position = new Vector3(posx, posy, posz);
        Debug.Log("Posici�n Camara: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
