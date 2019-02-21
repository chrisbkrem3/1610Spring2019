using UnityEngine;
using UnityEngine.Events;

public class HealthEvent : MonoBehaviour
{
    public UnityEvent Event;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Event.Invoke();
    }
}
