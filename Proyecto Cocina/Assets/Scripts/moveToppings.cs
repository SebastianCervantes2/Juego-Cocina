using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToppings : MonoBehaviour
{
    public int occupiedSlot = 99;

    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = Gameplay.salectedSlot;
    }

    // Update is called once per frame
    void Update()
    {
        if (occupiedSlot == Gameplay.selectedDandwhich)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(objPosition.x, objPosition.y - 0.4f);

        }

    }
}
