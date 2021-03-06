﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherWeaponScript : MonoBehaviour {
    public MessageBord message;
    public GameObject player;

    private void Start()
    {
        message = FindObjectOfType<MessageBord>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.GetComponentInParent<PlayerController>().ActivateWeapon();
            message.CloseMessage();
            Destroy(gameObject);

        }
    }
}
