using UnityEngine;
using Unity.Netcode;

public class PlayerMovement : NetworkBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (IsOwner == false)
        {
            return;
        }
        Vector2 direction = new Vector2()
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = Input.GetAxisRaw("Vertical"),
        };
        float moveSpeed = 3f;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
