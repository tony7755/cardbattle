using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public int health;
    public int pip;
    public int maxHealth;
    public Button pipIncrease;
    public Button hitThunderShock;
    public Button useThunderShock;
    public Button hitFlamethrower;
    public Button useFlamethrower;
    public Button morningSun;
    public Button hitOblivionWing;
    public Button useOblivionWing;

    public NewBehaviourScript(int iHealth, int iPip)
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
    void Start()
    {
        Button pi = pipIncrease.GetComponent<Button>();
        pi.onClick.AddListener(TaskOnClickPip);

        Button hts = hitThunderShock.GetComponent<Button>();
        hts.onClick.AddListener(TaskOnClickHTS);
        Button uts = useThunderShock.GetComponent<Button>();
        uts.onClick.AddListener(TaskOnClickUTS);

        Button hft = hitFlamethrower.GetComponent<Button>();
        hft.onClick.AddListener(TaskOnClickHFT);
        Button uft = useFlamethrower.GetComponent<Button>();
        uft.onClick.AddListener(TaskOnClickUFT);

        Button ms = morningSun.GetComponent<Button>();
        ms.onClick.AddListener(TaskOnClickMS);

        Button how = hitOblivionWing.GetComponent<Button>();
        how.onClick.AddListener(TaskOnClickHOW);
        Button uow = useOblivionWing.GetComponent<Button>();
        uow.onClick.AddListener(TaskOnClickUOW);
    }

    void TaskOnClickPip()
    {
        gainPip(1);
    }

    void TaskOnClickHTS()
    {
        takeDamage(60);
    }
    void TaskOnClickUTS()
    {
        gainPip(-1);
    }

    void TaskOnClickHFT()
    {
        float hit = Random.value;
        if (hit <= .85)
        {
            takeDamage(140);
        }
    }
    void TaskOnClickUFT()
    {
        gainPip(-2);
    }

    void TaskOnClickMS()
    {
        float hit = Random.value;
        if (hit <= .95)
        {
            takeDamage(-125);
        }
        gainPip(-2);
    }

    void TaskOnClickHOW()
    {
        float hit = Random.value;
        if (hit <= .7)
        {
            takeDamage(150);
        }
    }
    void TaskOnClickUOW()
    {
        float hit = Random.value;
        if (hit <= .7)
        {
            takeDamage(-100);
        }
        gainPip(-3);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
