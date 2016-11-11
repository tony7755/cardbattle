using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

    public static int do_damage(double chance, int damage)
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