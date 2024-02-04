using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary> An event that can have callbacks removed via a passed handle. </summary>
public class HandleEvent
{
    private readonly Dictionary<object, Action> callbacks = new Dictionary<object, Action>();

    public void Add(object handle, Action a)
    {
        this.Remove(handle); //Remove the old one
        this.callbacks[handle] = a;
    }

    public void Remove(object handle) => this.callbacks.Remove(handle);

    public void AddAndCall(object handle, Action a)
    {
        this.Add(handle, a);
        a();
    }

    public void Invoke()
    {
        foreach (var action in this.callbacks.Values)
            action.Invoke();
    }

    public void Clear() => this.callbacks.Clear();
}
