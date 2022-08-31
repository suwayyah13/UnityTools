using UnityEngine;

public class KeyBindings
{
    private KeyBinding MainBindings;
    private KeyBinding PossibleBindings;
    public KeyBindings(KeyCode[] mainBindings, KeyCode[] possibleBindings)
    {
        SetMainBindings(mainBindings);
        SetMainBindings(possibleBindings);
    }
    public void SetMainBindings(KeyCode[] bindings)
    {
        this.MainBindings = new(bindings);
    }
    public void SetPossibleBindings(KeyCode[] bindings)
    {
        this.PossibleBindings = new(bindings);
    }
    public KeyCode[] GetPossibleBindings()
    {
        return PossibleBindings.GetBindings();
    }
    public bool CheckKeyUp()
    {
        return MainBindings.CheckKeyUp();
    }
    public bool CheckKeyDown()
    {
        return MainBindings.CheckKeyDown();
    }
}