using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public SpriteRenderer hazard;
    public SpriteRenderer playerSprite;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Intersects(playerSprite.bounds))
        {
            player.takeDamage(5);
        }
    }
}
