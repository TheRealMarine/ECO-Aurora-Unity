using UnityEngine;

/// <summary>
/// Use this interface to add additional actions to ESC button for UIManager
/// </summary>
public interface IEscapeHandler
{
    //return true to consume escape
    bool HandleEscape();
}
