using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;
    [SerializeField] AudioClip soundHit;
    AudioSource myAudioSource;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        myAudioSource = GetComponent<AudioSource>();
    }

    public void AttackHitEvent()
    {
        if(target == null) { return; }
        target.TakeDamage(damage);
        myAudioSource.PlayOneShot(soundHit);
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }

}