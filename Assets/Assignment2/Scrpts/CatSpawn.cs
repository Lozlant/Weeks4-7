using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CatSpawn : MonoBehaviour
{
    public GameObject CatPrefab;

    float timer;
    float waitlist = 0;
    public float newCustomerAppearTime;
    public float waitlistLimit;
    public Transform appearposition;
    public TextMeshProUGUI text;

    public Slider foodSlider;
    public Slider drinkSlider;
    public GameObject foodPrefabs;
    public GameObject drinkPrefabs;

    public Sprite[] foods = new Sprite[4];
    public Sprite[] drinks = new Sprite[2];

    GameObject cat;
    GameObject food;
    GameObject drink;
    // Start is called before the first frame update
    void Start()
    {
        timer = newCustomerAppearTime;
    }

    // Update is called once per frame
    void Update()
    {
        //after waitlistLimit seconds, add 1 cat to waitlist
        timer += Time.deltaTime;
        if (timer > newCustomerAppearTime)
        {
            waitlist=Mathf.Min(waitlist+1, waitlistLimit);
            text.text = "Next (" + waitlist + ")";
            timer = 0;
        }

        if(cat == null)
        {
            Destroy(food);
            Destroy(drink);
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

    public void FeedCat()
    {
        if(cat != null && food == null)
        {
            food = Instantiate(foodPrefabs);
            food.GetComponent<SpriteRenderer>().sprite = foods[(int)foodSlider.value];
            drink = Instantiate(drinkPrefabs);
            drink.GetComponent<SpriteRenderer>().sprite = drinks[drinkSlider.value<0.5?0:1];
            cat.GetComponent<CatAction>().eating = true;
        }
    }
}
