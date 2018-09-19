using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UFO", menuName = "UFO")]
public class Player : ScriptableObject {
    public string playername;
    public string description;
    public Sprite artwork;

    public int eat;
    public int collection;

    public void Print(){
        Debug.Log(name + ":" + description + "the player" + playername);
    }
		
	
}
