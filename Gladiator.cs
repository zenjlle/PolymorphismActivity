using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator : Swordsman
{
    void Start()
    {
        playerName = "Gladiator Name";
        BasicAttack();
        Skill();
    }

    public override void BasicAttack()
    {
        basicAttack = "Jab";
    }

    public override void Skill()
    {
        skill = "Shield Bash";
    }

    public virtual void DisplayAttributes()
    {
        GameManager.instance.classTxt.text = playerName;
        GameManager.instance.basicAttackTxt.text = basicAttack;
        GameManager.instance.skillTxt.text = skill;
        GameManager.instance.classPathTxt.text = "Player > Swordsman > Gladiator";

        GameManager.instance.playerImg.color = Color.blue;
        GameManager.instance.swordsmanImg.color = Color.blue;
        GameManager.instance.gladiatorImg.color = Color.blue;

        GameManager.instance.barbarianButton.gameObject.SetActive(false);
        GameManager.instance.archerButton.gameObject.SetActive(false);
        GameManager.instance.artilleryButton.gameObject.SetActive(false);
        GameManager.instance.sniperButton.gameObject.SetActive(false);

        GameManager.instance.playerToSwordsman.color = Color.blue;
        GameManager.instance.swordsmanToGladiator.color = Color.blue;

        GameManager.instance.playerToArcher.gameObject.SetActive(false);
        GameManager.instance.swordsmanToBarbarian.gameObject.SetActive(false);
        GameManager.instance.archerToArtillery.gameObject.SetActive(false);
        GameManager.instance.archerToSniper.gameObject.SetActive(false);
    }
}
