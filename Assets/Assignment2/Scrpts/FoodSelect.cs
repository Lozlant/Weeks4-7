using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSelect : MonoBehaviour
{
    public Image[] foods = new Image[4];
    Color greycolor;
    // Start is called before the first frame update
    void Start()
    {
        greycolor = foods[0].color;
        changeColor(0); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeColor(float value)
    {
        foreach(var food in foods)
        {
            food.color = greycolor;
        }
        foods[(int)value].color = Color.white;
    }
}
