using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttoncode : MonoBehaviour
{
    public Sprite happy;
    public Sprite angry;
    public void Happy()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = happy;

    }
    public void Angry()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = angry;
    }
}
