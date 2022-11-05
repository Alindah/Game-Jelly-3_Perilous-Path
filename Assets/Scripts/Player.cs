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

        /* 1. Create a function that makes the player move upwards,
         * stopping when they've reached the edge.
         * 
         * 2. Make it so that the player only moves up when the player presses a button.
         * 
         * 3. Make the player move down.
         */

        Keyboard kb = Keyboard.current;

        // No keyboard connected
        if (kb == null)
            return;

        if (kb.upArrowKey.IsPressed() || kb.wKey.IsPressed())
        {
            if (transform.position.y < yBoundaryUp)
                transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }

        if (kb.downArrowKey.IsPressed() || kb.sKey.IsPressed())
        {
            if (transform.position.y > yBoundaryDown)
                transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
