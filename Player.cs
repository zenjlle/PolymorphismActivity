using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public string playerName;
    public string basicAttack;
    public string skill;

    public void Start()
    {
        playerName = "Player Name";
        BasicAttack();
        Skill();
    }

    public virtual void BasicAttack()
    {
        basicAttack = "Basic Attack";
    }

    public virtual void Skill()
    {
        skill = "Skill";
    }

    public virtual void DisplayAttributes()
    {
        GameManager.instance.classTxt.text = playerName;
        GameManager.instance.basicAttackTxt.text = basicAttack;
        GameManager.instance.skillTxt.text = skill;
        GameManager.instance.classPathTxt.text = "Player";

        GameManager.instance.playerImg.color = Color.blue;

        GameManager.instance.swordsmanButton.gameObject.SetActive(false);
        GameManager.instance.barbarianButton.gameObject.SetActive(false);
        GameManager.instance.gladiatorButton.gameObject.SetActive(false);
        GameManager.instance.archerButton.gameObject.SetActive(false);
        GameManager.instance.artilleryButton.gameObject.SetActive(false);
        GameManager.instance.sniperButton.gameObject.SetActive(false);

        GameManager.instance.playerToSwordsman.gameObject.SetActive(false);
        GameManager.instance.playerToArcher.gameObject.SetActive(false);
        GameManager.instance.swordsmanToBarbarian.gameObject.SetActive(false);
        GameManager.instance.swordsmanToGladiator.gameObject.SetActive(false);
        GameManager.instance.archerToArtillery.gameObject.SetActive(false);
        GameManager.instance.archerToSniper.gameObject.SetActive(false);
    }
}
