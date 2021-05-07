using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSandwich : MonoBehaviour
{
    public string mouseControlled = "n";
    public int occupiedSlot = 0;

    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = Gameplay.salectedSlot;
        Debug.Log(occupiedSlot);
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseControlled == "y")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;

        }


    }

    private void OnMouseDown()
    {
        mouseControlled = "y";
        Gameplay.selectedDandwhich = occupiedSlot;


    }

}
