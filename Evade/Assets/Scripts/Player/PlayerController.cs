using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        UpdateRotation();
        MoveForward();
    }

    private void MoveForward()
    {
        transform.position += transform.forward * (Time.deltaTime * movementSpeed);
    }

    private void UpdateRotation()
    {
        var horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(transform.forward, horizontal * Time.deltaTime * rotationSpeed);
    }
}
