using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorChange : MonoBehaviour
{
    public float colorChangeDuration;

    IEnumerator ChangeColor(Image image)
    {
        float t = 0;
        while (t < colorChangeDuration)
        {
            t += Time.deltaTime;
            if(t < colorChangeDuration/2)
            {
                image.color = Color.Lerp(Color.white, Color.red, t / colorChangeDuration);
            }
           
            if(t > colorChangeDuration/2)
            {
                image.color = Color.Lerp(Color.red, Color.white, t / colorChangeDuration);
            }
            yield return null;
        }
    }

    public void StartHighlight(Image image)
    {
        StartCoroutine("ChangeColor", image);
    }
}
