using UnityEngine;

public class KeyBinding
{
    private KeyCode[] Bindings;
    public KeyBinding(KeyCode[] bindings)
    {
        SetBindings(bindings);
    }
    public void SetBindings(KeyCode[] bindings)
	{
        this.Bindings = bindings;
    }
    public bool CheckKeyUp()
    {
        bool result = false;
        foreach(KeyCode binding in Bindings)
        {
            if(Input.GetKeyUp(binding))
            {
                result = true;
                break;
			}
        }
        return result;
    }
    public bool CheckKeyDown()
    {
        bool result = false;
        foreach (KeyCode binding in Bindings)
        {
            if (Input.GetKeyDown(binding))
            {
                result = true;
                break;
            }
        }
        return result;
    }
    public KeyCode[] GetBindings()
    {
        return Bindings;
	}
}
