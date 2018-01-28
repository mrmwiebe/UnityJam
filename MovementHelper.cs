using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MovementHelper {

    /// <summary>
    /// This moves a Rigidbody in a controlled way towards the targetVelocity.
    /// </summary>
    /// <param name="rigidbody">The rigidbody that will be moved.</param>
    /// <param name="speedMultiplier">How fast to move the rigidbody.</param>
    /// <param name="targetVelocity">The direction to move.  Usually an Input axis.</param>
    /// <param name="maxVelocityChange">Limits how much to move.</param>
    /// <returns>The change to the rigidbody's velocity.</returns>
    public static Vector3 RigidbodyForceMove(Rigidbody rigidbody, float speedMultiplier, Vector3 targetVelocity, float maxVelocityChange)
    {
        // Calculate how fast we should be moving
        targetVelocity = rigidbody.transform.TransformDirection(targetVelocity);
        targetVelocity *= speedMultiplier;

        // Apply a force that attempts to reach our target velocity
        Vector3 velocity = rigidbody.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);
        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = 0;

        //rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);
        return velocityChange;
    }
}
