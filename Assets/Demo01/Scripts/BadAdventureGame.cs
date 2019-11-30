using System;
using UnityEngine;
using UnityEngine.UI;

public class BadAdventureGame : MonoBehaviour
{
    public Text text;

    private enum State
    {
        A1OutsideHangar,
        A2InACell,
        A3EmergencyExit,
        A4PickingLock,
        A5LockSmashing,
        A6DarkRoom,
        A7TheLongWayRound,
        A8Evesdropping,
        A9PressureBuildUp,
        A10NarrowEscape,
        A11Diversion,
        B1OpeningDoor,
        B2BoobyTrap,
        B3Escape,
        B4FriendlyFire,
        B5Waiting,
        B6Running,
        S2OnboardWithSupplies,
        S1OnboardButOnlyJust,
        X1GameOver
    }

    private State _state;

    private void Start()
    {
        _state = State.A1OutsideHangar;
    }

    private void Update()
    {
        switch (_state)
        {
            case State.A1OutsideHangar:
                A1OutsideHangar();
                break;
            case State.A2InACell:
                A2InACell();
                break;
            case State.A3EmergencyExit:
                A3EmergencyExit();
                break;
            case State.A4PickingLock:
                A4PickingLock();
                break;
            case State.A5LockSmashing:
                A5LockSmashing();
                break;
            case State.A6DarkRoom:
                A6DarkRoom();
                break;
            case State.A7TheLongWayRound:
                A7TheLongWayRound();
                break;
            case State.A8Evesdropping:
                A8Evesdropping();
                break;
            case State.A9PressureBuildUp:
                A9PressureBuildUp();
                break;
            case State.A10NarrowEscape:
                A10NarrowEscape();
                break;
            case State.A11Diversion:
                A11Diversion();
                break;
            case State.B1OpeningDoor:
                B1OpeningDoor();
                break;
            case State.B2BoobyTrap:
                B2BoobyTrap();
                break;
            case State.B3Escape:
                B3Escape();
                break;
            case State.B4FriendlyFire:
                B4FriendlyFire();
                break;
            case State.B5Waiting:
                B5Waiting();
                break;
            case State.B6Running:
                B6Running();
                break;
            case State.S1OnboardButOnlyJust:
                S1OnboardButOnlyJust();
                break;
            case State.S2OnboardWithSupplies:
                S2OnboardWithSupplies();
                break;
            case State.X1GameOver:
                X1GameOver();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void A1OutsideHangar()
    {
        text.text = "Outside Hangar" +
                    "\nFesters. Everywhere. Armed mostly with gas-powered rock flingers." +
                    "\nAt least 10 of them guarding the hangar door. Typical." +
                    "\nCould try punching your way through. Or sneaking the long way to the emergency exit." +
                    "\nWhat should you do?" +
                    "\n\n1. Take them head on - rush the 10 guards." +
                    "\n\n2. Sneak your way to the emergency exit.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A2InACell;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.A3EmergencyExit;
    }

    private void A2InACell()
    {
        text.text = "In A Cell" +
                    "\nWell, that was pretty stupid. You sustain a brutal beating and end up dumped " +
                    "in a dirty cell. The bars are thick cast iron. The door is old and patched together with plate " +
                    "metal and thick red wires." +
                    "\nYou have no idea where you are. And your head hurts." +
                    "\nSo, what to do now, slugger?" +
                    "\n\n1. Wait it out. My head hurts." +
                    "\n\n2. Slam into the door with all my might.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.B1OpeningDoor;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.B2BoobyTrap;
    }

    private void A3EmergencyExit()
    {
        text.text = "Emergency Exit" +
                    "\nOkay, you're around the corner. No one can see you. You think." +
                    "\nBit tough to hear yourself think above the thumping machinery. However, in front of you " +
                    "is the emergency exit door. It has an oversized, cast iron lock hanging from a bolted handle. " +
                    "You could try picking the lock, or maybe look for a way to pry it off." +
                    "\nWhat to do?" +
                    "\n\n1. Pick it." +
                    "\n\n2. Pry it.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A4PickingLock;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.A5LockSmashing;
    }

    private void A4PickingLock()
    {
        text.text = "Picking Lock" +
                    "\nYou give it a good 10 minutes. No dice. Not going to happen." +
                    "\nYou do realise that you have no idea how to pick a lock right? You're an airship pilot, " +
                    "not a common thief." +
                    "\nSo what now?" +
                    "\n\n1. Fine, try to pry it.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A5LockSmashing;
    }

    private void A5LockSmashing()
    {
        text.text = "Lock Smashing" +
                    "\nGot to be something around here to help with some smashy smashy. You see a crate with all " +
                    "manner of pipes, wires and cogs scattered within it. Mostly trash." +
                    "\nYou could try the brute force approach - wack the lock with one of the pipes. Or you could " +
                    "take some time to build a contraption with some kind of leverage, maybe a mini pulley system " +
                    "with those wires and the cogs." +
                    "\nHow to proceed?" +
                    "\n\n1. No time to waste, grab the pipe, start wacking." +
                    "\n\n2. Take the time to build a leverage-gadget.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A6DarkRoom;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.A6DarkRoom;
    }

    private void A6DarkRoom()
    {
        text.text = "Dark Room" +
                    "\nRight, well, that took far longer than anticipated but the lock is off and the door opened. " +
                    "Thank goodness for the Pumping Station being so loud." +
                    "\nYou're in a dark room. You hear people yelling over the top of the combustion boilers. " +
                    "You catch some words. THUNK, THUNK, \"shut off the valves...\", THUNK THUNK, \"...get out in " +
                    "time?\", THUNK THUNK, \"...massive pressure\", THUNK THUNK \"...for glory\"... THUNK THUNK..." +
                    "\nWhat next, Adventurer?" +
                    "\n\n1. Get closer to the people speaking." +
                    "\n\n2. Ignore them, keep pushing for the airship.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A7TheLongWayRound;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.A8Evesdropping;
    }

    private void A7TheLongWayRound()
    {
        text.text = "The Long Way Round" +
                    "\nGood thinking, no point worrying about some random guys' plans to blow up the entire pumping " +
                    "station by shutting off the water cooling valves. I'm sure everything will be just fine. " +
                    "Nothing at all to worry about. Plenty of time to do what you need to do." +
                    "\nYou take quite some time, but eventually you make your way around the edge of the pumping " +
                    "station and see daylight." +
                    "\nWhat! An almighty screech pierces the air. Gears grinding. Steam spooshing from cracks in " +
                    "pipes. And then, a deafening roar...." +
                    "\n\n1. Continue...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.X1GameOver;
    }

    private void A8Evesdropping()
    {
        text.text = "Evesdropping" +
                    "\nYou slink through the machinery towards 2 skanky looking men. The tall, scrawny one is carrying " +
                    "an oversized gas-canister-powered arrow shooter, while the shorter dumpy man has strapped to him " +
                    "at least a dozen small glass bottles with grey liquid inside." +
                    "\nThe stout fellow finishes cranking a large valve (clockwise you notice) and then both men " +
                    "dash off with much haste." +
                    "\nWhat to do?" +
                    "\n\n1. Quick, uncrank that valve, they were clearly up to no good." +
                    "\n\n2. Chase the men.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A9PressureBuildUp;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.A10NarrowEscape;
    }

    private void A9PressureBuildUp()
    {
        text.text = "Pressure Build Up" +
                    "\nYou open up the valve (anti-clockwise), step back, and congratulate yourself on averting " +
                    "certain tragedy. Phew, that was close." +
                    "\nAs you stand pondering your next move, you hear a popping noise, as if a huge build up of " +
                    "steam has cause the rivet of a boiler to be expunged like a squeezed whitehead on a teenager's " +
                    "forehead." +
                    "\nThen another. Then another. Oh..... maybe the men turned off more than on valve. You hear an " +
                    "almighty screeching as the huge gears and cogs start to jam. Then a deafening road." +
                    "\n\n1. Continue...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.X1GameOver;
    }

    private void A10NarrowEscape()
    {
        text.text = "Narrow Escape" +
                    "\nYou take your cue from the two men and get on your horse. Figuratively of course, no one " +
                    "rides horses since the combustamobile was invented." +
                    "\nYou zig. You zag. You weave through the huge machinery of the pumping station. " +
                    "Steam jets have started squirting out of pipes. Gears are grinding to a halt. " +
                    "You see the exit ahead." +
                    "\nSomething behind you gives a grinding screech. Metal eating into metal. You leap for the door " +
                    "and slide through on your stomach, just as all hell breaks lose behind you." +
                    "\n\n1. Continue...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A11Diversion;
    }

    private void A11Diversion()
    {
        text.text = "Diversion" +
                    "\nIn front of you is the expanse of the airship hangar." +
                    "\nFesters are running everywhere and mostly yelling at one another. Some men are clambering " +
                    "aboard airships, others are attempting to put out fires that have started from the explosion." +
                    "\nWho were those men? Friend or foe? That will have to wait. Time to get out of here." +
                    "\nWhat now?" +
                    "\n\n1. Mad sprint to the nearest airship." +
                    "\n\n2. Quick scrounge for weapons, then mad sprint to the nearest airship.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.S1OnboardButOnlyJust;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.S2OnboardWithSupplies;
    }

    private void B1OpeningDoor()
    {
        text.text = "Opening Door" +
                    "\nYou wait it out. After, perhaps, 20 minutes you hear feet shuffling. Keys jangle. " +
                    "The door starts to unlock." +
                    "\nWhat to do?" +
                    "\n\n1. Wait a little longer, it seemed to work last time." +
                    "\n\n2. Rush the door and thrust a handful of knuckles through the chestplate of whoever enters.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.B4FriendlyFire;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.B3Escape;
    }

    private void B2BoobyTrap()
    {
        text.text = "Booby Trap" +
                    "\nYou stand up, a little groggily, back up to the far edge of the wall and make an almighty " +
                    "sprint towards the door." +
                    "\nAnd, of course, its booby trapped. Maybe next time you want to ask what the red wires are " +
                    "wrapped around the door." +
                    "\n\n1. Continue...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.X1GameOver;
    }

    private void B3Escape()
    {
        text.text = "Escape" +
                    "\nThe door opens and then... nothing. You peak outside and there is nobody there." +
                    "\nWell, thats odd." +
                    "\nHave you just been freed? And by whom? And why?" +
                    "\nNo time for that now. We have escaping to do. Whats the plan?" +
                    "\n\n1. Wait a bit longer." +
                    "\n\n2. Get running.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.B5Waiting;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.B6Running;
    }

    private void B4FriendlyFire()
    {
        text.text = "Friendly Fire" +
                    "\nYou tear off a piece of metal framing from your leather airship pilot armour and hold it " +
                    "ready as a shiv of sorts. As the door opens you rush at your captor, leaping like a crazy" +
                    " person and hollering a primal scream of rage." +
                    "\nPayback time for your beating and from all the pain these dirty Festers have caused your " +
                    "family. You drive home your metal shiv. You hear the crunch of bones and feel the slice of " +
                    "flesh." +
                    "\nAfter a brief struggle, there is stillness. You look down and see... oh my lord..." +
                    " you see... yourself? What? How?" +
                    "\n\n1. Continue...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.B5Waiting;
    }

    private void B5Waiting()
    {
        text.text = "Waiting" +
                    "\nNot much happens, what would you like to do?" +
                    "\n\n1. Get running.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.B6Running;
    }

    private void B6Running()
    {
        text.text = "Running" +
                    "\nYou run down a long corridor then up a flight of metal stairs. They make a loud racket as " +
                    "you clamber up them. Thank goodness the machinery in this place is so loud." +
                    "\nIn front of you is the emergency exit door. It has an oversized, cast iron lock hanging " +
                    "from a bolted handle. You could try picking the lock, or maybe look for a way to pry it off." +
                    "\nWhat to do?" +
                    "\n\n1. Pick it." +
                    "\n\n2. Pry it.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A4PickingLock;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.A5LockSmashing;
    }

    private void S1OnboardButOnlyJust()
    {
        text.text = "Onboard But Only Just" +
                    "\nYou scramble aboard your airship. With all of your remaining strength, you lift the anchoring " +
                    "rope off its huge hook and give an all mighty shove." +
                    "\nAs you start to drift out of the hangar, you hear shouts of dismay from a nearby group of " +
                    "Festers." +
                    "\n\"So long suckers! May we never meet again!\", you holler. You may, you may not. Time will " +
                    "tell." +
                    "\nYou've won this battle. Now, on with the war!" +
                    "\n\n1. Continue...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A1OutsideHangar;
    }

    private void S2OnboardWithSupplies()
    {
        text.text = "Onboard With Supplies" +
                    "\nYou take what feels like an eternity to scrounge a rock flinger and 3 vials of tonix. " +
                    "When a huge machine cog lands an arm span from your head you decide its time to make your dash." +
                    "\nYou scramble aboard your airship. With all of your remaining strength, you lift the anchoring " +
                    "rope off its huge hook and give an all mighty shove." +
                    "\nFrom behind you hear a surprised crew member. He rushes. You shoot. Direct hit. Thank goodness" +
                    " for the weapon. You're safe. For now." +
                    "\n\n1. Continue...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A1OutsideHangar;
    }

    private void X1GameOver()
    {
        text.text = "Game Over" +
                    "\nWell, that clearly wasn't the right choice." +
                    "\nYou failed." +
                    "\nNo parade for you.Want to try again?" +
                    "\n\n1. Yes, this time I shall taste glory." +
                    "\n\n2. No, I'm going to go sulk for a while.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) _state = State.A1OutsideHangar;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) _state = State.A1OutsideHangar;
    }
}