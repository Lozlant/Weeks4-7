using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float health;
    public float maxhealth=5;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            sprite.color = Color.black;
        }
        else
        {
            Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    public void takeDamage(float damage)
    {
        health -= damage;
    }
}
