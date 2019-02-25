using UnityEngine;
using UnityEngine.Events;

public class HealthEvent : MonoEvents
{
    public UnityEvent Event;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Event.Invoke();
    }

    void Update()
    {
        transform.Rotate(0, 0, 1);
    }

}
