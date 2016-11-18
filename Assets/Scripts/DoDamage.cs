using UnityEngine;
using System.Collections;

public class DoDamage : MonoBehaviour {

    public static int doDamage(double chance, int damage)
    {
        if (Random.value > chance)
            return 0;
        else
            return damage;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}