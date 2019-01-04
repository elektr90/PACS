using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private Color32 colorRed;
    [SerializeField]
    private Color32 colorBlue;
    [SerializeField]
    private Color32 colorPurple;
    [SerializeField]
    private Color32 colorYellow;

    private Rigidbody2D playerRigidbody;
    private PLAYER_COLORS currentPlayerColor;
    private SpriteRenderer playerSprite;

    private void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        currentPlayerColor = PLAYER_COLORS.RED;

    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRigidbody.velocity = playerSpeed * Vector2.up;



        }


    }
    // wybor w zaleznosci jaki kolor ma gracz i w jaki kolor udezyl 
    // porownujemy tag elementu kolizji z tagiem zapisanym w game properties
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == GameProperties.BLUE_TAG)
        {

            Debug.Log("i'm blue");
        }
        else if (collision.transform.tag == GameProperties.YELLOW_TAG)
        {

            Debug.Log("i'm yellow");
        }
        else if (collision.transform.tag == GameProperties.RED_TAG)
        {

            Debug.Log("i'm red");
        }
        else if (collision.transform.tag == GameProperties.PURPLE_TAG)
        {

            Debug.Log("i'm purple");
        }

    }

    public enum PLAYER_COLORS { RED = 1, BLUE, YELLOW, PURPLE }
}
