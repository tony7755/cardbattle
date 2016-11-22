using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	private string cardName;
	private double chance;
	private int damage;
	private int pip;
    private bool heal;


	/* Constructor */
	public Card (string name1, double chance1, int damage1, int pip1, bool heal1 = false) //heal1 ony true if drain
	{
		cardName = name1;
		chance = chance1;
		damage = damage1;
		pip = pip1;
        heal = heal1;
	}
	/* Command returns name */
	public string getName ()
	{
		return name;
	}
	/* Command returns chance */
	public double getChance()
	{
		return chance;
	}
	/* Command returns Damage */
	public int getDamage()
	{
		return damage;
	}
	/* Command returns pip cost */
	public int getPip()
	{
		return pip;
	}

    public bool isHeal()
    {
        return heal;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
