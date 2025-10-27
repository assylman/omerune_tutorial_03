using System;

[Serializable]
public class Floor
{
    public int peopleCount = 0;

    override public string ToString()
    {
        return "PeopleCount: " + peopleCount;
    }
}
