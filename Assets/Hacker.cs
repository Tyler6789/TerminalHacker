using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowMainMenu();

		
	}
	
    void ShowMainMenu()    {
        Terminal.ClearScreen();
        var greeting = "Hello Tyler";
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("===Welcome===");
        Terminal.WriteLine("Digitech EcoSystem Terminal 6");
        Terminal.WriteLine("  ");
        Terminal.WriteLine("Type in number for desired");
        Terminal.WriteLine("class of animal:");
        Terminal.WriteLine("  ");
        Terminal.WriteLine("Type 1 for Mammals");
        Terminal.WriteLine("Type 2 for Bugs");
        Terminal.WriteLine("Enter your selection:");

    }
	// Update is called once per frame
	void Update () {
		
	}
}
