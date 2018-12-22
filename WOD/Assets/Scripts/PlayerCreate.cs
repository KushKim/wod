using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreate : MonoBehaviour
{
    [SerializeField]
    Sprite sprite;

    [SerializeField]
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = sprite;
        Debug.Log("asdfasdf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
