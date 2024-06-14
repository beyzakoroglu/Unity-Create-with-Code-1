using UnityEngine;

public class PropellerController : MonoBehaviour
{
    public float rotationSpeed = 1000f; // Propeller'in dönme hızı (değerini ayarlayarak hızını değiştirebilirsiniz)

    // Update is called once per frame
    void Update()
    {
        // Propeller'i sürekli olarak yerel Y ekseni etrafında döndür
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}