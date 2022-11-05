using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        /* https://docs.unity3d.com/Packages/com.unity.inputsystem@1.4/api/UnityEngine.InputSystem.html
         * 
         * 1. Write code that will make the player move upwards.
         * 
         * 2. Make player stop moving when they've reached the edge.
         * 
         * 3. Make it so that the player only moves up when the player presses a button.
         * 
         * 4. Make the player move down.
         */

        // Set the Keyboard object as the current connected keyboard device
        Keyboard kb = Keyboard.current;

        // No keyboard connected
        if (kb == null)
            return;

        // Move up
        if (kb.upArrowKey.IsPressed() || kb.wKey.IsPressed())
        {
            if (transform.position.y < yBoundaryUp)
                transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }

        // Move down
        if (kb.downArrowKey.IsPressed() || kb.sKey.IsPressed())
        {
            if (transform.position.y > yBoundaryDown)
                transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
