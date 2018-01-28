using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper {

    /// <summary>
    /// Returns a vector between two points
    /// </summary>
    /// <param name="p1">Point 1</param>
    /// <param name="p2">Point 2</param>
	public static Vector3 VectorBetweenPoints(Vector3 p1, Vector3 p2)
    {
        // Calculate Angle Between the collision point and the player
        Vector3 dir = p1 - p2;
        // We then get the opposite (-Vector3) and normalize it
        dir = -dir.normalized;
        // And finally we add force in the direction of dir and multiply it by force. 
        // This will push back the player
        return dir;
    }
}
