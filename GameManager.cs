using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    /*
    [Header("Scripts")]
    public Player player;
    public Swordsman swordsman;
    public Barbarian barbarian;
    public Gladiator gladiator;
    public Archer archer;
    public Sniper sniper;
    public Artillery artillery;
    */

    [Header("Buttons")]
    public Button playerButton;
    public Button swordsmanButton;
    public Button barbarianButton;
    public Button gladiatorButton;
    public Button archerButton;
    public Button sniperButton;
    public Button artilleryButton;

    [Header("ButtonImage")]
    public Image playerImg;
    public Image swordsmanImg;
    public Image barbarianImg;
    public Image gladiatorImg;
    public Image archerImg;
    public Image sniperImg;
    public Image artilleryImg;

    [Header("Lines")]
    public Image playerToSwordsman;
    public Image swordsmanToBarbarian;
    public Image swordsmanToGladiator;
    public Image playerToArcher;
    public Image archerToArtillery;
    public Image archerToSniper;

    [Header("TextDisplay")]
    public TextMeshProUGUI classTxt;
    public TextMeshProUGUI basicAttackTxt;
    public TextMeshProUGUI skillTxt;
    public TextMeshProUGUI classPathTxt;

    private void Awake()
    {

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
}
