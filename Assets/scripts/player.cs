using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpPower = 10f;
    public SpriteRenderer sr;

    public string CurrentColor;        // o anda topun hangi renk olduðunu öðrenmek için 
    public Color blue;
    public Color pink;
    public Color purple;
    public Color yellow;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Colorer();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0)))
        {
            rb.velocity = Vector2.up * jumpPower;
        }       
    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ColorChanger")
        {
            Colorer();
            Destroy(collision.gameObject);
            return;
        }

        if(collision.tag != CurrentColor)
        {
            Debug.Log("Yandýn yavrum yandýn");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Colorer()   // Renk atamalarýný bu kod bloðunda yapacaðýz.
    {
        int index = Random.Range(0, 4);
        
        switch (index)
        {
            case 0:
                CurrentColor = "blue";
                //sr.color = blue;
                break;

            case 1:
                CurrentColor = "pink";
                //sr.color = pink;
                break;

            case 2:
                CurrentColor = "yellow";
                //sr.color = yellow;
                break;

            case 3:
                CurrentColor = "purple";
               // sr.color = purple;
                break;
        }

    }

}
