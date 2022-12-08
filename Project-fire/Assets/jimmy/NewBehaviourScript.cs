using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Sprite pineapple;
    public Sprite korv;

    public void Korv()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = korv;
    }

    public void Pineapple()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = pineapple;
    }
}

