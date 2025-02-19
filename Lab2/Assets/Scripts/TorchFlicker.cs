using UnityEngine;

public class TorchFlicker : MonoBehaviour
{
    public Light torchLight;
    public float minIntensity = 1.5f;
    public float maxIntensity = 2.5f;
    public float flickerSpeed = 0.1f;

    void Update()
    {
        if (torchLight != null)
        {
            torchLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.PerlinNoise(Time.time * flickerSpeed, 0.0f));
        }
    }
}
