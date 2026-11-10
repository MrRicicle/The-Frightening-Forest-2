using UnityEngine;

public class TorchToggle : MonoBehaviour
{
    public Light torchLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        torchLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (torchLight.intensity == 1)
            {
                torchLight.intensity = 0;
            }
            else
            {
                torchLight.intensity = 1;
            }
        }
    }
}
