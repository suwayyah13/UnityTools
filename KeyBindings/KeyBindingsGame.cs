using System;
using UnityEngine;

public class KeyBindingsGame : MonoBehaviour
{
    private KeyBindings MoveLeft;
    private KeyBindings MoveRight;
    private KeyBindings Jump;
    private KeyBindings StartAim;
    public enum KeyBindingType
	{
		MoveLeft,
		MoveRight,
		Jump,
		StartAim
	}
	public void SetBinding(KeyBindingType keyBindingType, KeyCode[] currentBindings, KeyCode[] possibleBindings)
	{
        switch (keyBindingType)
        {
            case KeyBindingType.MoveLeft:
                MoveLeft = new(currentBindings, possibleBindings);
                break;
            case KeyBindingType.MoveRight:
                MoveRight = new(currentBindings, possibleBindings);
                break;
            case KeyBindingType.Jump:
                Jump = new(currentBindings, possibleBindings); ;
                break;
            case KeyBindingType.StartAim:
                StartAim = new(currentBindings, possibleBindings); ;
                break;
            default:
                throw new Exception("Unknown KeyBindingType value (" + keyBindingType + ")");
        }
    }
    public KeyBindings GetKeyBindingsByType(KeyBindingType keyBindingType)
    {
		KeyBindings keyBindings = keyBindingType switch
		{
			KeyBindingType.MoveLeft => MoveLeft,
			KeyBindingType.MoveRight => MoveRight,
			KeyBindingType.Jump => Jump,
			KeyBindingType.StartAim => StartAim,
			_ => throw new Exception("Unknown KeyBindingType value (" + keyBindingType + ")")
		};
		return keyBindings;
    }
}