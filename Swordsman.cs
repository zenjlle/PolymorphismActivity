using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Player
{
    public void Start()
    {
        playerName = "Swordsman Name";
        BasicAttack();
        Skill();
    } 

    public override void BasicAttack()
    {
        basicAttack = "Sword Slash";
    }

    public override void Skill()
    {
        skill = "Sweeping Edge";
    }

    public override void DisplayAttributes()
    {
        GameManager.instance.classTxt.text = playerName;
        GameManager.instance.basicAttackTxt.text = basicAttack;
        GameManager.instance.skillTxt.text = skill;
        GameManager.instance.classPathTxt.text = "Player > Swordsman";

        GameManager.instance.playerImg.color = Color.blue;
        GameManager.instance.swordsmanImg.color = Color.blue;

        GameManager.instance.barbarianButton.gameObject.SetActive(false);
        GameManager.instance.gladiatorButton.gameObject.SetActive(false);
        GameManager.instance.archerButton.gameObject.SetActive(false);
        GameManager.instance.artilleryButton.gameObject.SetActive(false);
        GameManager.instance.sniperButton.gameObject.SetActive(false);

        GameManager.instance.playerToSwordsman.color = Color.blue;

        GameManager.instance.playerToArcher.gameObject.SetActive(false);
        GameManager.instance.swordsmanToBarbarian.gameObject.SetActive(false);
        GameManager.instance.swordsmanToGladiator.gameObject.SetActive(false);
        GameManager.instance.archerToArtillery.gameObject.SetActive(false);
        GameManager.instance.archerToSniper.gameObject.SetActive(false);
    }
}
