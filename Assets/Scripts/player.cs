using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    private int health;
    private int mana;

    public player (int iHealth, int iMana)
    {
        health = iHealth;
        mana = iMana;
    }

    public bool isAlive()
    {
        return health > 0;
    }

    public void takeDamage(int damage)
    {
        health -= damage;
    }

    public void gainMana(int gMana)
    {
        mana += gMana;
    }

    public int healthLevel()
    {
        return health;
    }

    public int manaLevel()
    {
        return mana;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
