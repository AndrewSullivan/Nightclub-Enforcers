using UnityEngine;

public class BottlePickUp : MonoBehaviour
{
    public Transform objectHolder;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false; // Stops forces being applied to object that is picked up;
        GetComponent<Rigidbody>().freezeRotation = true; // Stops object that has been picked up from rotating when player moves or looks around.

        this.transform.position = objectHolder.transform.position; // This then changes the transform position of the object picked up, to the position of the object holder game object in front of the player.
        this.transform.parent = GameObject.Find("Object Holder").transform; // This sets the transform parent of the object to the transform of the of the object holder.
    }

    private void OnMouseUp()
    {
        GetComponent<Rigidbody>().freezeRotation = false; // Resets rigidybody to allow game object to rotate in any given way when it is no longer being held by the player.
        GetComponent<Rigidbody>().useGravity = true; // Resets rigidybody to allow forces to affect the object that was picked up;

        this.transform.parent = null; // This resets the parent of the picked up game objects transform to nothing.
    }

}
