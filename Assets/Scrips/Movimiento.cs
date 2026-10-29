using UnityEngine;
using UnityEngine.InputSystem;

public class Movimineto : MonoBehaviour
{
    public float velocidad = 3f;
    public bool usaFlechas;

    private Vector3 direccion = Vector3.right;

    void Update()
    {
        if (usaFlechas)
        {
            if (Keyboard.current.upArrowKey.wasPressedThisFrame) direccion = Vector3.up;
            if (Keyboard.current.downArrowKey.wasPressedThisFrame) direccion = Vector3.down;
            if (Keyboard.current.leftArrowKey.wasPressedThisFrame) direccion = Vector3.left;
            if (Keyboard.current.rightArrowKey.wasPressedThisFrame) direccion = Vector3.right;
        }
        else
        {
            if (Keyboard.current.wKey.wasPressedThisFrame) direccion = Vector3.up;
            if (Keyboard.current.sKey.wasPressedThisFrame) direccion = Vector3.down;
            if (Keyboard.current.aKey.wasPressedThisFrame) direccion = Vector3.left;
            if (Keyboard.current.dKey.wasPressedThisFrame) direccion = Vector3.right;
        }

        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }
}