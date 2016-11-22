using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private int health;
    private int pip;
    private int maxHealth;
    
    public Player (int iHealth, int iPip)
    {
        health = iHealth;
        maxHealth = iHealth;
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

    public void playCard(Card card, Player target, bool heal = false) // damge (card(positive damage), opponent); drain (heal = true); heal(card, self);
    {
        int pipNeed = card.getPip();
        if (pip >= pipNeed)
        {
            double chance = card.getChance();
            int damage = card.getDamage();
            pip -= pipNeed;
            int damageMake = DoDamage.doDamage(chance, damage);
            target.takeDamage(damageMake);
            if (heal)
                health += damageMake / 2;
            health = Mathf.Min(health, maxHealth);
        }
        
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
