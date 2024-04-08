using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artillery : Archer
{
    void Start()
    {
        playerName = "Artillery Name";
        BasicAttack();
        Skill();
    }

    public override void BasicAttack()
    {
        basicAttack = "Explosive Shell";
    }

    public override void Skill()
    {
        skill = "Rocket Barrage";
    }

    public virtual void DisplayAttributes()
    {
        GameManager.instance.classTxt.text = playerName;
        GameManager.instance.basicAttackTxt.text = basicAttack;
        GameManager.instance.skillTxt.text = skill;
        GameManager.instance.classPathTxt.text = "Player > Swordsman > Artillery";

        GameManager.instance.playerImg.color = Color.blue;
        GameManager.instance.archerImg.color = Color.blue;
        GameManager.instance.artilleryImg.color = Color.blue;

        GameManager.instance.barbarianButton.gameObject.SetActive(false);
        GameManager.instance.swordsmanButton.gameObject.SetActive(false);
        GameManager.instance.gladiatorButton.gameObject.SetActive(false);
        //GameManager.instance.sniperButton.interactable = false;
        GameManager.instance.sniperButton.gameObject.SetActive(false);

        GameManager.instance.playerToArcher.color = Color.blue;
        GameManager.instance.archerToArtillery.color = Color.blue;

        GameManager.instance.playerToSwordsman.gameObject.SetActive(false);
        GameManager.instance.swordsmanToBarbarian.gameObject.SetActive(false);
        GameManager.instance.archerToSniper.gameObject.SetActive(false);
        GameManager.instance.swordsmanToGladiator.gameObject.SetActive(false);
    }
}
