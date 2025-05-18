using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 12f;
    private float originalSpeed;
    
    public GameObject playerVisual; // Asigna aquí el objeto con el MeshRenderer

    private Renderer visualRenderer;
    
    private mov movementScript;
    void Start()
    {
        movementScript = GetComponentInChildren<mov>();
        originalSpeed = moveSpeed;
        visualRenderer = playerVisual.GetComponent<Renderer>();
    }

    public void ActivateSpeedBoost(float duration, float boostSpeed)
    {
        StopAllCoroutines();
        StartCoroutine(SpeedBoost(duration, boostSpeed));
    }

    public void ActivateFreeze(float duration)
    {
        StopAllCoroutines();
        StartCoroutine(Freeze(duration));
    }

    public void ActivateInvisibility(float duration)
    {
        StopAllCoroutines();
        StartCoroutine(Invisibility(duration));
    }

    private System.Collections.IEnumerator SpeedBoost(float duration, float boostSpeed)
    {
        movementScript.speed = boostSpeed;
        yield return new WaitForSeconds(duration);
        movementScript.speed = 7f;
    }

    private System.Collections.IEnumerator Freeze(float duration)
    {

        if (movementScript != null)
        {
            movementScript.enabled = false;
        }
        yield return new WaitForSeconds(duration);
        
         movementScript.enabled = true;   
    }

    private System.Collections.IEnumerator Invisibility(float duration)
    {
        visualRenderer.enabled = false;
        yield return new WaitForSeconds(duration);
        visualRenderer.enabled = true;
    }
}

