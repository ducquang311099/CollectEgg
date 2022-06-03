using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenarateEgg : MonoBehaviour
{
    #region ==== Fields ====

    [SerializeField] private float _nextDrop = 1f;
    [SerializeField] private float _dropRate = 2f;
    [SerializeField] private float _maxTime = 20f;

    private float currentTime = 0f;

    #endregion

    #region ==== Life Circle ====

    private void Start()
    {
        SetupScene();
    }

    void Update()
    {
        DropEgg();
        RemainingTime();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Egg"))
            GameOver();
    }

    #endregion

    #region ==== Methods ====

    void DropEgg()
    {
        if (UIManager.Instance.Menu.activeSelf)
            return;
        if (Time.time > _nextDrop)
        {
            _nextDrop = Time.time + _dropRate;
            if (Random.Range(0, 10) < 8)
                Instantiate(GameManager.Instance.NorEgg, new Vector3(Random.Range(-5f, 5f), 4, 0), Quaternion.identity);
            else
                Instantiate(GameManager.Instance.GolEgg, new Vector3(Random.Range(-5f, 5f), 4, 0), Quaternion.identity);
        }
    }

    void SetupScene()
    {
        Time.timeScale = 0;
        currentTime = _maxTime;
        UIManager.Instance.EndGame.SetActive(false);
        UIManager.Instance.Menu.SetActive(true);
    }

    void RemainingTime()
    {
        if (UIManager.Instance.Menu.activeSelf)
            return;
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UIManager.Instance.Time.text = ((int)currentTime).ToString();
        }
        else
            GameOver();
    }

    void GameOver()
    {
        Time.timeScale = 0;
        UIManager.Instance.EndGame.SetActive(true);
        UIManager.Instance.Info.text = "Your Score: " + UIManager.Instance.Score.text;
    }

    #endregion

}
