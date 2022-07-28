using UnityEngine;
using UnityEngine.UI;

public class Switching : MonoBehaviour
{
    public Image ButtonImage;
    public Sprite[] buttonsprite;

    public bool state;

    public void behaviour()
    {
        state = !state;

        if(state)
        {
            Time.timeScale = 0;
            ButtonImage.sprite = buttonsprite[0];
        }
        else
        {
            Time.timeScale = 1;
            ButtonImage.sprite = buttonsprite[1];
        }
    }
}
