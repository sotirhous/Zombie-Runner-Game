using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] TextMeshProUGUI healthText;

    private void Start()
    {
        healthText.text = "Health: " + hitPoints.ToString();
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        healthText.text = "Health: " + hitPoints.ToString();
        if(hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
