using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Vector3 Rotate;
    public float horizontalInput;
    public float VerticalInput;
    public float speed;
    public float mouseSensitivity = 100f;
    float xrotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        Rotate.x  += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.localRotation = Quaternion.Euler( 0f, -Rotate.x, 0f);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameplayManager.gamePlayManager.spawnBullet();

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}
