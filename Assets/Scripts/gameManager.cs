using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
    public UnityEngine.UI.Button card11;
    public UnityEngine.UI.Button card12;
    public UnityEngine.UI.Button card13;
    public UnityEngine.UI.Button card14;
    public UnityEngine.UI.Button card21;
    public UnityEngine.UI.Button card22;
    public UnityEngine.UI.Button card23;
    public UnityEngine.UI.Button card24;



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
           //deck.addCard(new global::Card("Fire Spin", ))
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

        //Button finish = finishTurnButton.GetComponent<Button>();
       // finish.onClick.AddListener(switchPlayer);
    }
	
	// Update is called once per frame
	void Update () {
        //check game ends
	    if (!player1.isAlive() || !player2.isAlive()) // one of the player die
        {
            backButton.gameObject.SetActive(true);
            replayButton.gameObject.SetActive(true);
        }
        if (currentPlayer == player1)
        {
            card11.gameObject.SetActive(true);
            card12.gameObject.SetActive(true);
            card13.gameObject.SetActive(true);
            card14.gameObject.SetActive(true);
            card21.gameObject.SetActive(false);
            card22.gameObject.SetActive(false);
            card23.gameObject.SetActive(false);
            card24.gameObject.SetActive(false);
        }
        else
        {
            card11.gameObject.SetActive(false);
            card12.gameObject.SetActive(false);
            card13.gameObject.SetActive(false);
            card14.gameObject.SetActive(false);
            card21.gameObject.SetActive(true);
            card22.gameObject.SetActive(true);
            card23.gameObject.SetActive(true);
            card24.gameObject.SetActive(true);
        }
	}
}
