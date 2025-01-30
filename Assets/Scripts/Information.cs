using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Information : MonoBehaviour
{
    public RectTransform[] images;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        foreach (RectTransform i in images)
        {
            if (IsMouseInRect(i))
            {
                text.text = "My name is: " + i.gameObject.name;
            }
        }
    }

    bool IsMouseInRect(RectTransform image)
    {
        Vector3[] conners = new Vector3[4];
        image.GetWorldCorners(conners);
        Vector2 mousePos = Input.mousePosition;
        return mousePos.x > conners[0].x && mousePos.y > conners[0].y
            && mousePos.x < conners[2].x && mousePos.y < conners[2].y;
    }
}
