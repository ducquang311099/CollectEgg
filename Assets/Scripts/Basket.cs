using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    #region ==== Fields ====

    [SerializeField] private float _moveSpeed = 5f;

    private int score = 0;

    #endregion

    #region ==== Life Circle ====

    void Start()
    {

    }

    void Update()
    {
        Move();
        UpdateScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Egg"))
        {
            Destroy(collision.gameObject);
            score += 10;
        }
        if (collision.gameObject.CompareTag("GoldEgg"))
        {
            Destroy(collision.gameObject);
            score += 50;
        }
    }

    #endregion

    #region ==== Methods ====

    void Move()
    {
        var dir_X = Input.GetAxisRaw("Horizontal");
        GameManager.Instance.Basket.GetComponent<Rigidbody2D>().velocity = new Vector2(dir_X * _moveSpeed, 0);
        #region ==== Another Move ====
        //Vector3 _direction = new Vector3(dir_X, 0, 0).normalized;
        //transform.Translate(_direction * _moveSpeed * Time.deltaTime);
        #endregion
    }

    void UpdateScore()
    {
        UIManager.Instance.Score.text = score.ToString();
    }

    #endregion

}
