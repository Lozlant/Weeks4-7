using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawn : MonoBehaviour
{
    public GameObject CatPrefab;

    float timer = 0;
    float waitlist = 0;
    public float newCustomerAppearTime;
    public float waitlistLimit;
    public Transform appearposition;

    GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //after waitlistLimit seconds, add 1 cat to waitlist
        timer += Time.deltaTime;
        if (timer > waitlistLimit)
        {
            waitlist=Mathf.Max(waitlist, waitlistLimit);
            timer = 0;
        }
    }
    public void NextCat()
    {
        //there's at least one cat in waitlist, and last cat has gone, spawn a cat.
        if (waitlist > 0 && cat == null)
        {
            cat = Instantiate(CatPrefab,appearposition);
            waitlist--;
        }
    }
}
