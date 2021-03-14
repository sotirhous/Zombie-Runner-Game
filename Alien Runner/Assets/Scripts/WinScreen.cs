using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    
    [SerializeField] Canvas winCanvas;
    EnemyHealth health;

    void Start()
    {
        winCanvas.enabled = false;
        health = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.IsDead())
        {
            winCanvas.enabled = true;
            Time.timeScale = 0;
            FindObjectOfType<WeaponSwitcher>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
