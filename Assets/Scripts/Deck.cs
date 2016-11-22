using UnityEngine;
using System.Collections;

public class Deck : MonoBehaviour {

	private ArrayList deck;

	public Deck (){
		deck = new ArrayList ();
	}
	public void addCard (Card card){
		deck.Add (card);
	}
	public Card draw ()
	{
		int i = (int) Random.value * deck.Count;
		Card card = (Card) deck [i];
		deck.RemoveAt (i);
		return card;
	}
	public int cardsLeft ()
	{
		int i = deck.Count;
		return i;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
