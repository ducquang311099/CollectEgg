using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    #region ==== Methods ====

    public void PlayBtnClick()
    {
        UIManager.Instance.Menu.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void RePlayBtnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion
}
