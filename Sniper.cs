using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Archer
{
    void Start()
    {
        playerName = "Sniper Name";
        BasicAttack();
        Skill();
    }

    public override void BasicAttack()
    {
        basicAttack = "Bang!";
    }

    public override void Skill()
    {
        skill = "Deadeye's Shot";
    }

    public virtual void DisplayAttributes()
    {
        GameManager.instance.classTxt.text = playerName;
        GameManager.instance.basicAttackTxt.text = basicAttack;
        GameManager.instance.skillTxt.text = skill;
        GameManager.instance.classPathTxt.text = "Player > Swordsman > Sniper";

        GameManager.instance.playerImg.color = Color.blue;
        GameManager.instance.archerImg.color = Color.blue;
        GameManager.instance.sniperImg.color = Color.blue;

        GameManager.instance.barbarianButton.gameObject.SetActive(false);
        GameManager.instance.swordsmanButton.gameObject.SetActive(false);
        GameManager.instance.gladiatorButton.gameObject.SetActive(false);
        GameManager.instance.artilleryButton.gameObject.SetActive(false);

        GameManager.instance.playerToArcher.color = Color.blue;
        GameManager.instance.archerToSniper.color = Color.blue;

        GameManager.instance.playerToSwordsman.gameObject.SetActive(false);
        GameManager.instance.swordsmanToBarbarian.gameObject.SetActive(false);
        GameManager.instance.archerToArtillery.gameObject.SetActive(false);
        GameManager.instance.swordsmanToGladiator.gameObject.SetActive(false);
    }
}
