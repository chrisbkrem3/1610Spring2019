using UnityEngine;
using UnityEngine.Events;

public class RocketEvent : MonoBehaviour
{
    public UnityEvent Event;

    private void OnCollisionEnter2D()
    {
        Event.Invoke();
    }

}
