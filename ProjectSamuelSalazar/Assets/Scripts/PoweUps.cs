using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUps : MonoBehaviour
{
    // Start is called before the first frame update
    public enum PowerType { Speed, Freeze, Invisibility }
    public PowerType powerType;

    public float duration = 3f;
    public float speedBoost = 10f; // Solo para SpeedBoost

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerAbilities abilities = other.GetComponent<PlayerAbilities>();

            if (abilities != null)
            {
                switch (powerType)
                {
                    case PowerType.Speed:
                        abilities.ActivateSpeedBoost(duration, speedBoost);
                        break;
                    case PowerType.Freeze:
                        abilities.ActivateFreeze(duration);
                        break;
                    case PowerType.Invisibility:
                        abilities.ActivateInvisibility(duration);
                        break;
                }

                Destroy(gameObject); // Elimina el ítem
            }
        }
    }
}
