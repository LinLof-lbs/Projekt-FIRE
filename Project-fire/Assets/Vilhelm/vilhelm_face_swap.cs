using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vilhelm_face_swap : MonoBehaviour
{
    public Sprite angry;
    public Sprite happy;

    public void Angry()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = angry;
    }

    public void Happy()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = happy;
    }
}