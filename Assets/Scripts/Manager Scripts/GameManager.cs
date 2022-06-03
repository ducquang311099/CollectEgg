using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region ==== Fields ====

    [SerializeField] private GameObject basket;
    [SerializeField] private GameObject norEgg;
    [SerializeField] private GameObject golEgg;

    private static GameManager _instance;

    #endregion

    #region ==== Properties ====

    public GameObject Basket { get => basket; }
    public GameObject NorEgg { get => norEgg; }
    public GameObject GolEgg { get => golEgg; }

    public static GameManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.Log("Game Manager is NULL");
            return _instance;
        }
    }

    #endregion

    #region ==== Life Circle ====

    private void Awake()
    {
        _instance = this;
    }

    #endregion

}
