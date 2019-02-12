using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class Dog : Animal
{
    public string LegCount;
    public UnityEvent Event;
    

    // Start is called before the first frame update
    void Start()
    {
        Event.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,1);
    }
}
