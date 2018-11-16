using UnityEngine;
using System.Collections;

public class BouncerScript : MonoBehaviour
{

    public float bounceFactor = 10f;

    public GameObject spawner;
    bool hasSpawned = false;


    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            other.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceFactor, ForceMode2D.Impulse);
        }
            if (!hasSpawned)
        
{
            spawner.SendMessage("Spawn");
            hasSpawned = true;
        }

        GetComponent<AudioSource>().Play();
    }
}
