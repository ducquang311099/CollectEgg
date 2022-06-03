using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region ==== Fields ====

    [SerializeField] private Text score;
    [SerializeField] private Text time;
    [SerializeField] private Text info;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject endGame;

    private static UIManager _instance;

    #endregion

    #region ==== Properties ====

    public static UIManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.Log("UI Manager is NULL");
            return _instance;
        }
    }
    public Text Score { get => score; }
    public GameObject Menu { get => menu; }
    public Text Time { get => time; }
    public GameObject EndGame { get => endGame; }
    public Text Info { get => info; }

    #endregion

    #region ==== Life Circle ====

    private void Awake()
    {
        _instance = this;
    }

    #endregion

}
