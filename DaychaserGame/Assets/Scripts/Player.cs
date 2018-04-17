﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Player : MonoBehaviour {

    public int currentHealth;
    public int maxHealth;
	void Start () {
        if (maxHealth <= 0 || maxHealth > 3)
            maxHealth = 3;
        currentHealth = maxHealth;
	}

    public void TakeDamage(int amount)
    {
        Debug.Log("Player takes " + amount + " damage!");   
        currentHealth -= amount;
        GameObject.Find("UIScripts").GetComponent<UIMonitor>().internalHealth -= 1;
        if (currentHealth <= 0)
            die();

    }

    void die()
    {
        Debug.Log("You dead son");
        currentHealth = maxHealth;

    }
}
