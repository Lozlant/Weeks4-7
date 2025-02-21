using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAction : MonoBehaviour
{
    public AnimationCurve appear;
    [Range(0f, 3f)]
    public float appearSpeed;

    public bool eating;

    float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eating)
        {
            timer -= appearSpeed*Time.deltaTime;
            if(timer < 0f)
            {
                Destroy(gameObject);
            }
        }
        else if (timer < 1)
        {
            //a cat spawn animation after created
            timer += appearSpeed * Time.deltaTime;
        }
        Vector3 scale = transform.localScale;
        scale.y = Mathf.Lerp(0, 1.5f, appear.Evaluate(timer));
        transform.localScale = scale;
    }
}
