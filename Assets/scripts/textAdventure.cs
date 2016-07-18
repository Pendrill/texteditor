using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textAdventure : MonoBehaviour {

	// Use this for initialization
	public Font notefont;
	public Font normal;
	public Font dialogue;
	public Text thetext;
	public Text header;
	public Text talkbox;

	string currentroom = "start";
	int kitchenstage;
	int picroomstage;
	string textbuffer;
	string cont;

	int dialogueint=0;
	int counter=0;
	bool haskey;
	int talkint;

	void Start () {
		
		textbuffer = "You are currently in the: " + currentroom+"\n";
		cont = "Press space to continue";
		kitchenstage = 0;
		picroomstage = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		counter++;
		textbuffer = "You are currently in the: " + currentroom+"\n";
		
		if (currentroom == "start") {
			startfont (header);
			thetext.text = "Welcome to the game.\n The game is life. \nNot this game. \nThis is a text adventure" +
			"\nUnless otherwise instructed, press space to continue" +
			"\nAdventures await you!";
			if(Input.anyKeyDown){currentroom = "???";
			}
		}

		else if (currentroom == "???" || currentroom == "Break Room") {
			startfont (header);
			header.text = textbuffer;
			
			if (kitchenstage == 0) {
				startfont (header);
				header.text = textbuffer;
				type(thetext);
				thetext.text ="You are sitting at a small table in a small room." +
					"\non one side, there is a counter, above which are a few cupbords." +
					"\nThrough an open cupbord, you see several coffee mugs and bowls, all with various post-it notes attatched to them." +
					"\nMost intriguing." +
					"\nNext to the counter is an old, yellowing fridge making soft (yet still concerning) rattling noises. " +
					"\nThey should probbaly get that checked out. " +
					"\nOn the other side of the room there is a vending machine and a water fountain. " +
					"\nWith your superior intellect, you deduce this is a kitchen - no, a BREAK ROOM. ";
				
				if (Input.anyKeyDown) {
					kitchenstage = 1;
					currentroom = "Break Room";
				}
				
			}
			if (kitchenstage == 1) {
				startfont (header);
				header.text = textbuffer;

				type (thetext);
				thetext.text="To your left there is an open entrance into a hallway." +
					"\n in front of you there is a door"+
					"\n in front of the door there is a man"+
					"\n you'd think you would have noticed him first"+
					"\n actually you did but you were ignoring him"+
					"\n this is your boss craig"+
					"\n you spend most of your time ignoring him";
				
				startfont(talkbox);
				talkbox.text = "TALK TO CRAIG [z]" +
				"\nEXIT TO HALLWAY [x]" +
				"\nGO THROUGH DOOR [c]";
				if(Input.GetKeyDown(KeyCode.Z)){
					kitchenstage = 2;
					counter = 0;
				}
				if(Input.GetKeyDown(KeyCode.X)){
					kitchenstage = 3;
					counter = 0;
				}
				if(Input.GetKeyDown(KeyCode.C)){
					kitchenstage = 4;
					counter = 0;
				}

			}
			if (kitchenstage == 2) {
				
				if (Input.anyKeyDown&&counter>10) {
					dialogueint++;
					counter = 0;
				}
					thetext.text = "Craig calls everyone buddy. He says it in they tone one might use to say '$%#@head'";

					talkbox.text = "Hey, buddy! I'm so sorry for making you stay overtime like this,";

				if (dialogueint == 1) {
					thetext.text = "He looks around, then whispers";
					talkbox.text = "I actually kept all three of you here.";
				}
				if (dialogueint == 2) {
					thetext.text = "Craig is talking";
					talkbox.text = "You, and then the two suspects. Today's the day we put an end to this";
				}
				if (dialogueint == 3) {
					thetext.text = "You don't like where this is going ";
					talkbox.text = "I locked the doors, no one is getting out till we get to the bottom of this";
				}
				if (dialogueint == 4) {
					thetext.text = "Craig pulls something out of his coat pocket";
					talkbox.text = "I know you told me to be delicate about the situation, but I got another one this morning.";
				}
				if (dialogueint == 5) {
					thetext.text="Craig hands you the thing";
					talkbox.text = "Here, check it out.";
				}
				if (dialogueint == 6) {
					
					thetext.text = "It's a note";
					talkbox.text="OPEN THE NOTE [z]";
				}
				if (dialogueint == 7) {
					notetype (thetext);
					thetext.fontSize = 30;
					thetext.text = "Oh, Craig. Craig, Craig, Craig. YOU ARE NEVER GETTING YOUR COOKIE BACK. I WILL NEVER STOP. Catch me if you can, 'BUDDY'";
					talkbox.text="close note";
				}
				if (dialogueint == 8) {
					thetext.fontSize = 20;
					type (thetext);
					thetext.text = "That's right, this is about a cookie.";
					talkbox.text="It's not about the COOKIE, man, It's about my pride. HE'S MOCKING ME. He keps leaving these notes and stealing my freaking cookies";
				}
				if (dialogueint == 9) {
					
					thetext.text = "as usual, Craig dumps his personal responsibilities on you ";
					talkbox.text="But you can handle it, right? I'll leave it to you, man";
				}
				if (dialogueint == 10) {
					
					thetext.text = "He most certainly does not pay you the big bucks";
					talkbox.text="This is why I pay you the big bucks! ";
					if (Input.anyKeyDown) {
						kitchenstage = 5;
					}
				}


					
			}
			if (kitchenstage == 3) {
				thetext.text = "Craig, fast as lightning, heads you off as you make for the door." +
				"\nThere was never any hope of escape.";
				talkbox.text = "TALK TO CRAIG [z]";
				if (Input.anyKeyDown&&counter>10) {
					kitchenstage = 2;
				}
			}
			if (kitchenstage == 4&&counter>10) {
				thetext.text = "it's locked";
					if(Input.GetKeyDown(KeyCode.Z)){
						kitchenstage = 2;	
					}
					if(Input.GetKeyDown(KeyCode.X)){
						kitchenstage = 3;
					}
					if(Input.GetKeyDown(KeyCode.C)){
						kitchenstage = 4;
					}
			}

			if (kitchenstage == 5 && counter > 10) {
				thetext.text = "Craig stands there, wearing an expression you assume he thinks is an encouraging smile";
				talkbox.text="EXIT TO HALLWAY [Z]\nTRY THE DOOR [X]";
				if(Input.GetKeyDown(KeyCode.Z)&&counter>10){
					currentroom = "????";	
					counter = 0;
				}
				if (Input.GetKeyDown(KeyCode.X)) {
					kitchenstage = 6;
					counter = 0;
				}

			
			}
			if (kitchenstage==6&&haskey==false&&counter>10) {
				thetext.text = "Craig locked it, remember?";
				talkbox.text="EXIT TO HALLWAY [Z]" +
				"\nTRY DOOR [X]";
				if(Input.GetKeyDown(KeyCode.Z)&&counter>10){
					currentroom = "????";	
					counter = 0;
				}
			}
		}
		if (currentroom == "????" || currentroom == "Picture Room") {
			if (picroomstage == 0) {
				thetext.text = "This isn't actually a hallway, it's another room. On one wall hangs a very large and very bewildering painting." +
				"\n Sitting in a comfy chair in the room is your work friend, Anna. " +
				"\nYou like Anna. Anna's cool. " +
				"At the moment, she is sipping some (you assume) coffee, and warily taking in the painting." +
				"\n it really is quite an image.";
				talkbox.text = "Talk to Anna [z]" +
				"\nGo back into Break Room [x]"  +
				"\nLook at the painting [v]";
				if (Input.GetKeyDown (KeyCode.Z)&& counter>10) {
					picroomstage = 1;	
					counter = 0;
				}
				if (Input.GetKeyDown (KeyCode.X)&& counter>10) {
					kitchenstage = 5;
					currentroom="Break Room";
					counter = 0;
				}
				if (Input.GetKeyDown (KeyCode.C)&& counter>10) {
					picroomstage = 2;	
					counter = 0;
				}

			}
			if (picroomstage == 1&&counter>10) {
				if (Input.anyKeyDown && counter>10) {
					talkint++;
					counter=0;
				}
				if (talkint == 0) {
					currentroom = "Picture Room";
					thetext.text = "Smalltalk with Anna";
					talkbox.text = "Any Idea why he's keeping us late? I'm done for the day.";
				}
				if (talkint == 1) {
					thetext.text = "I hear you're helping him with something?";
					talkbox.text = "Any Idea why he's keeping us late? I'm done for the day.";
				}
				if (talkint == 2) {
					thetext.text = "Smalltalk with Anna";
					talkbox.text = "Any Idea why he's keeping us late? I'm done for the day.";
				}
				if (talkint == 3) {
					thetext.text = "Smalltalk with Anna";
					talkbox.text = "Any Idea why he's keeping us late? I'm done for the day.";
				}
			}




		}
		if (currentroom == "?????" || currentroom == "Cat Room") {
		}
	
	}

	void notetype(Text t){
		t.font = notefont;

	}
	void type(Text t){
		
		t.color = Color.gray;
		t.font = normal;
	}

	void startfont(Text t){
		t.color = Color.yellow;
		t.font = dialogue;
	}
}
