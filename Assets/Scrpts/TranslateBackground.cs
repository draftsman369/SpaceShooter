using UnityEngine;

public class TranslateBackground : MonoBehaviour
{

    public Vector3 translationVector;
    public float minYPosition = -10f; // Minimum Y position to stop translation
    public float translationSpeed;
    public Vector3 initialTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialTransform = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < minYPosition)
        {
            // Reset position to initial transform if below minimum Y position
            this.transform.position = initialTransform;
        }
        this.transform.Translate(translationVector * translationSpeed * Time.deltaTime);

    }
}
