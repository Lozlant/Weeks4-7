using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEToInteract : MonoBehaviour
{
    public float speed;
    public GameObject item;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(direction * speed *Time.deltaTime);
        print(Vector2.Distance(item.transform.position, transform.position));
        text.SetActive(Vector2.Distance(item.transform.position,transform.position)<1f);

    }
}
