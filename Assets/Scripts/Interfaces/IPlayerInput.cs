using UnityEngine;

public interface IPlayerInput
{
    Vector2 Move { get; }   // x = horizontal, y = vertical
    bool Sprint { get; }
}
