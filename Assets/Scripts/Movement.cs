using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

namespace Entity.Behaviour
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed = -5f;
        private Keyboard CurrentKey = Keyboard.current;

        private void Update()
        {
            if (CurrentKey.wKey.isPressed)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            } else if (CurrentKey.dKey.isPressed)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    }
}