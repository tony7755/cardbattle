using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Hand : MonoBehaviour {
    private int maxNumCards;
    private ArrayList hand;

    public Hand(int maxCards, Deck deck)
    {
        maxNumCards = maxCards;
        hand = new ArrayList();
        for (int i = 0; i < maxCards; ++i)
        {
            draw(deck);
        }
    }

    public void draw(Deck deck)
    {
        Card card = deck.draw();
        hand.Add(card);
    }

    public ArrayList showHand()
    {
        return hand;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
