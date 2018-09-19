using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {
    public Player ufo;
    // Use this for initialization

    public Text nameText;
    public Text descriptionText;
    public Image artworkImage;

	void Start () {
        //ufo.Print();
        nameText.text = ufo.name;
        descriptionText.text = ufo.description;

	}
}
