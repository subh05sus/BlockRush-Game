using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Material redMaterial; // The red material to start with
    public Material GoldMaterial; 

    void Update()
    {
        if (transform.position.z > 3000f) // Check if the z-axis position is greater than 1000
        {
            GetComponent<Renderer>().material = GoldMaterial; // Change the material to white
        }
        
        else
        {
            GetComponent<Renderer>().material = redMaterial; // Keep the material red
        }
    }
}
