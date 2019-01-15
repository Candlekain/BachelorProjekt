﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour {
    public int health;
    public int startHealth;
    public EventController ec;
    public AudioManager audioManager;
    public GameObject healthPickUp;
    public bool alive;
    public AchievmentDisplay achievmentDisplay;
    
	// Use this for initialization
	void Start () {
        achievmentDisplay = FindObjectOfType<AchievmentDisplay>();
        alive = true;
        health = startHealth;
        ec = FindObjectOfType<EventController>();
        audioManager = FindObjectOfType<AudioManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0 && alive)
        {
            achievmentDisplay.OnTomatoKill();

            alive = false;
            var rng = Random.Range(0, 25);

            if (rng <= 1)
            {
                if (gameObject != null)
                {
                    Instantiate(healthPickUp, transform.position, transform.rotation);

                }
            }
            Destroy(gameObject);           
        }
    }
    public void TakeDamage(int damage)
    {
        audioManager.Play("sound_tomato_death");
        health -= damage;  
        
    }   
}
