using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsWindow : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start() {
        transform.localScale = Vector2.zero;
        // resize to zero
    }
    public void Open() {
        transform.LeanScale(Vector2.one, 0.8f);
        // x and y values set to one
        //0.8 seconds
    }
    // Update is called once per frame
    public void Close() {
        transform.LeanScale(Vector2.zero, 1f).setEaseInBack();

    }
}
