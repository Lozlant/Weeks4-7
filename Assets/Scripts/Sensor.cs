using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Sensor : MonoBehaviour
{
    public SpriteRenderer sensor;
    public SpriteRenderer player;
    public AnimationCurve curveX;
    public AnimationCurve curveY;
    public AnimationCurve scale;
    public float startSize;
    public float endSize;

    [Range(0f, 3f)]
    public float speed;
    float timer;

    public GameObject Object;
    public Transform startPoint;
    public Transform endPoint;

    public bool loop;
    
    // Start is called before the first frame update
    void Start()
    {
        Object.transform.position = startPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (sensor.bounds.Intersects(player.bounds))
        {
            timer += Time.deltaTime*speed;
            timer = loop? timer%1:timer;
            Vector2 pos=Object.transform.position;
            pos.x = Mathf.Lerp(startPoint.position.x, endPoint.position.x, curveX.Evaluate(timer));
            pos.y = Mathf.Lerp(startPoint.position.y, endPoint.position.y, curveY.Evaluate(timer));
            Object.transform.position = pos;
            Object.transform.localScale = Vector3.one * Mathf.Lerp(startSize, endSize, scale.Evaluate(timer));
        }
    }
}
