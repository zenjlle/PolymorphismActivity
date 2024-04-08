using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Player
{
    public void Start()
    {
        playerName = "Archer Name";
        BasicAttack();
        Skill();
    }

    public override void BasicAttack()
    {
        basicAttack = "Piercing Dart";
    }

    public override void Skill()
    {
        skill = "Reign of arrows";
    }

    public override void DisplayAttributes()
    {
        GameManager.instance.classTxt.text = playerName;
        GameManager.instance.basicAttackTxt.text = basicAttack;
        GameManager.instance.skillTxt.text = skill;
        GameManager.instance.classPathTxt.text = "Player > Archer";

        GameManager.instance.playerImg.color = Color.blue;
        GameManager.instance.archerImg.color = Color.blue;

        GameManager.instance.barbarianButton.gameObject.SetActive(false);
        GameManager.instance.gladiatorButton.gameObject.SetActive(false);
        GameManager.instance.swordsmanButton.gameObject.SetActive(false);
        GameManager.instance.artilleryButton.gameObject.SetActive(false);
        GameManager.instance.sniperButton.gameObject.SetActive(false);

        GameManager.instance.playerToArcher.color = Color.blue;

        GameManager.instance.playerToSwordsman.gameObject.SetActive(false);
        GameManager.instance.swordsmanToBarbarian.gameObject.SetActive(false);
        GameManager.instance.swordsmanToGladiator.gameObject.SetActive(false);
        GameManager.instance.archerToArtillery.gameObject.SetActive(false);
        GameManager.instance.archerToSniper.gameObject.SetActive(false);
    }
}
