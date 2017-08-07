using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager InstanseGameManager = null;

    public Weapons GameWeapons;

    public Wears GameWears;

    public Consumables GameConsumables;

    public GameObject BackPackGameObject;

    public BackPack BackPackInstance;

    public GameObject PlayerHero;
    void Awake()
    {
        if (InstanseGameManager == null)
        {
            InstanseGameManager = this;
        }else if (InstanseGameManager != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        Init();
    }

    void Init()
    {
        //BackPack = Instantiate(BackPack, CanvasTransform);
        BackPackInstance = BackPackGameObject.GetComponentInChildren<BackPack>();
    }

    void Start()
    {
        //BackPackInstance = BackPackGameObject.GetComponentInChildren<BackPack>();
    }
    void GameStart()
    {
        
    }

    void GameOver()
    {
        
    }
}
