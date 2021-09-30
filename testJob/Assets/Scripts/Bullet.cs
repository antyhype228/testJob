﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    
    private Transform player;
    private Vector3 target;

    public GameObject hitVfx;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.z == target.z)
            DestroyBullet();

        
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(hitVfx,transform.position,Quaternion.identity);

        if(other.CompareTag("Player"))
            DestroyBullet();
        
    }
    void OnCollisionEnter(Collision  co)
    {
        speed = 0;
        
        ContactPoint contact = co.contacts [0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;

        if(hitVfx!=null)
        {
            var hitEffect = Instantiate(hitVfx, pos,  rot);
            var psHit = hitEffect.GetComponent<ParticleSystem>();
            if(psHit!=null)
                Destroy(hitEffect,psHit.main.duration);
            else
            {
                var psChild = hitEffect.transform.GetChild(0).GetComponent<ParticleSystem>();
                Destroy(hitEffect, psChild.main.duration);
            }
        }
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
