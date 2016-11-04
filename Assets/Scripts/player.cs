using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    private int health;
    private int pip;

    public player (int iHealth, int iPip)
    {
        health = iHealth;
        pip = iPip;
    }

    public bool isAlive()
    {
        return health > 0;
    }

    public void takeDamage(int damage)
    {
        health -= damage;
    }

    public void gainPip(int gPip)
    {
        pip += gPip;
    }

    public int healthLevel()
    {
        return health;
    }

    public int pipLevel()
    {
        return pip;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
