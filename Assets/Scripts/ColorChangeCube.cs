using UnityEngine;

public class ColorChangeCube : Interactive
{
    private Renderer rend;
    private Color originalColor;
    private bool isChanged = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    public new void Interact()
    {
        if (isChanged)
        {
            // Go back to original color
            rend.material.color = originalColor;
            isChanged = false;
        }
        else
        {
            // Change to random color
            rend.material.color = Random.ColorHSV();
            isChanged = true;
        }

        Debug.Log("Cube interacted: color changed!");
    }
}
