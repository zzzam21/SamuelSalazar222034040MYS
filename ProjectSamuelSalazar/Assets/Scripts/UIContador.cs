using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class UIContador : MonoBehaviour
{
    public TextMeshProUGUI textoContador; // ← Este es el tipo correcto
    public static UIContador Instance;
    public int coinCount = 0;
    public TMP_Text coinText; // Arrastra aquí un Text del Canvas en el Inspector

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinCount;
        }
    }
}