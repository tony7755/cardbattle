using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    Player player1;
    Player player2;

    Player currentPlayer;
    Player currentOpponent;

    Hand hand1;
    Hand hand2;
    Deck deck1;
    Deck deck2;

    const int numCards = 6;

    public int initialHealth = 500;
    public int initialPip = 0;
    public UnityEngine.UI.Button backButton;
    public UnityEngine.UI.Button replayButton;
    public UnityEngine.UI.Button finishTurnButton;


    void switchPlayer()
    {
        if (currentPlayer = player1)
        {
            currentPlayer = player2;
            currentOpponent = player1;
        }
        else
        {
            currentPlayer = player1;
            currentOpponent = player2;
        }
            
    }

    void addCardsToDeck(Deck deck)
    {
        for (int i = 0; i < 2; ++i)
        {
            deck.addCard(new global::Card("Maga Drain", 0.85, 50, 2, true));
            deck.addCard(new global::Card("Thunder", 0.1, 300, 1, false));
            deck.addCard(new global::Card("Super Potion", 1, -400, 2, false));
            deck.addCard(new global::Card("Fire Spin", ))
        }
    }

    // Use this for initialization
    void Start () {
        player1 = new global::Player(initialHealth, initialPip);
        player2 = new global::Player(initialHealth, initialPip);
        backButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);
        hand1 = new Hand(6, deck1);
        hand2 = new Hand(6, deck2);
	}
	
	// Update is called once per frame
	void Update () {
        //check game ends
	    if (!player1.isAlive() || !player2.isAlive()) // one of the player die
        {
            backButton.gameObject.SetActive(true);
            replayButton.gameObject.SetActive(true);
        }
	}
}
