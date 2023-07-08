using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyable : MonoBehaviour
{
    public int ID;
    private LevelEditorManager editor;

    void Start()
    {
        editor = GameObject.FindGameObjectWithTag("LevelEditorManager").GetComponent<LevelEditorManager>();

    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Destroy(this.gameObject);
            editor.itemButtons[ID].quantity++;
            editor.itemButtons[ID].quantityText.text = editor.itemButtons[ID].quantity.ToString();
        }
    }
}
