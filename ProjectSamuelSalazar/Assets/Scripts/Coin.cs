using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Variable estática para el contador (compartida entre todas las monedas)
    public static int contadorMonedas = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UIContador.Instance.AddCoin(); // Llama al contador
            Destroy(gameObject); // Destruye la moneda
        }
    }
}