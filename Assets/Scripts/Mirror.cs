using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public SpriteRenderer sensor;
    public SpriteRenderer playerSprite;
    public GameObject gsPrefab;
    GameObject gs;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sensor.bounds.Intersects(playerSprite.bounds))
        {
            if (gs == null) gs = Instantiate(gsPrefab);
            Vector2 pos= gs.transform.position;
            pos.x=player.position.x;
            pos.y=2*transform.position.y-player.position.y;
            gs.transform.position=pos;
        }
        else if(gs!=null) 
        {
            GameObject.Destroy(gs);
        }
    }
}
