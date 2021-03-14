using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100;
    [SerializeField] AudioClip enemyHitSFX;

    AudioSource myAudioSource;

    bool isDead = false;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        myAudioSource.PlayOneShot(enemyHitSFX);
        if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) { return; }
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
