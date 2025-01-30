using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wiggle : MonoBehaviour
{
    public RectTransform image;
    float time=0;
    public float speed;
    public AnimationCurve wiggle;
    [Range(1f, 10f)]
    public float amplit;

    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] conners = new Vector3[4];
        image.GetWorldCorners(conners);
        Vector2 mousePos = Input.mousePosition;
        if (mousePos.x > conners[0].x && mousePos.y > conners[0].y
            && mousePos.x < conners[2].x && mousePos.y < conners[2].y ){
            time = (time + Time.deltaTime * speed) % 1;
            Vector2 pos = transform.position;
            pos.x = Mathf.Lerp(startPos.x - amplit, startPos.x + amplit, wiggle.Evaluate(time));
            transform.position = pos;

        }


    }
}
