using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Astronaut : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float forceToAddY = 100.0f;
    public AudioSource oofSound;

    public GameObject[] hearts;
    public int numOfHearts = 3;
    public bool dead;

    // adding animation
    public Animator animator;


    //private Vector2 initialPosition = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        numOfHearts = hearts.Length;
        //initialPosition.x = transform.position.x;
        //initialPosition.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJump", true);
            // Vector
            Vector2 forceToAdd = new Vector2();
            forceToAdd.x = 0.0f;
            forceToAdd.y = forceToAddY;
            rigidbody2d.AddForce(forceToAdd);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isJump", false);

        }
            

        if ((rigidbody2d.transform.position.y < -5.0f || rigidbody2d.transform.position.y > 3.2f))
        {
            SceneManager.LoadScene("LoseScene");
        }

        //if (dead == true)
        //{
        //    SceneManager.LoadScene("LoseScene");
        //}
    }

    void FixedUpdate()
    {  
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isJump", false);

        }
    }


    // This function will be called when the two collider touching each other, and one of them isTrigger == true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        numOfHearts--;
        Destroy(hearts[numOfHearts].gameObject);
        if (numOfHearts < 1)
           dead = true;
        if(dead == true)
            SceneManager.LoadScene("LoseScene");
        Debug.Log("Trigger Entered!");
        oofSound.Play();
        animator.SetBool("isHurt", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("isHurt", false);
    }
}
