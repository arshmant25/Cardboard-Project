using UnityEngine;

// Inherit from Interactive
public class CubeColorChange : Interactive
{
    private Renderer rend;
    private Color originalColor;

    void Start()
    {
        // Get the cube's renderer and original color
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    // This is called by CameraInteract when interaction happens
    public new void Interact()
    {
        // Change color to parrot green
        rend.material.color = new Color(0.3f, 1f, 0.2f); // RGB values for bright green

        // Optional: reset color after 1 second
        Invoke("ResetColor", 1f);

        // Optional: log interaction
        Debug.Log("Cube interacted!");
    }

    void ResetColor()
    {
        rend.material.color = originalColor;
    }
}
