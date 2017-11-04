using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell, mirror, sheets_1, lock_1, cell_mirror, sheets_2, lock_2, freedom };
    private States myState;

   
    // Use this for initialization
    void Start () {
        text.text = "Press Enter to Play";
       // myState = States.cell;
       
    }

    void start_game()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            text.text = "Welcome to Prison";
            State_cell();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            text.text = "Welcome to Prison";
            State_cell();
        }


    }
    // Update is called once per frame
    void Update () {
        

        if (myState == States.cell)                { State_cell(); }
        else if (myState == States.sheets_1)       {State_sheets_1();}
        else if (myState == States.sheets_2)       { State_sheets_2(); }
        else if (myState == States.lock_1)         {State_lock_1();}
        else if (myState == States.lock_2)         { State_lock_2(); }
        else if (myState == States.mirror)         { State_mirror(); }
        else if (myState == States.cell_mirror)    { State_cell_mirror(); }
        else if (myState == States.freedom)        { State_freedom(); }
    }

    // cell
    void State_cell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                    "some dirty sheets on the bed, a mirror on the wall, and the door " +
                    "is locked from the outside. \n\n" +
                    "Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
    }


    // state_sheets1
    void State_sheets_1()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
                    "time somebody changed them. The pleasure of prison life " +
                    "I guess!\n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    // mirror
    void State_mirror()
    {
        text.text = "The dirty old mirror on the wall seems loose. \n\n" +
                    "Press T to Take The mirror, or R to Return to cell";
        if (Input.GetKeyDown(KeyCode.T))               { myState = States.cell_mirror; }
        else if (Input.GetKeyDown(KeyCode.R))          { myState = States.cell; }
    }

    // cell_mirror
    void State_cell_mirror()
    {
        text.text = "You are still in your cell, and you STILL want  to escape! There are " +
                    "some dirty sheets on the bed, a mark where the mirror was, " +
                    "and that pesky door is still  there, and firmly locked!\n\n" +
                    "Press S to view Sheets, or L to view Lock";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets_2; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_2; }
    }

    // Sheets_2
    void State_sheets_2()
    {
        text.text = "Holding a mirror in your hand doesn't make the sheets look " +
                    "any better. \n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    // Lock_1
    void State_lock_1()
    {
        text.text = "This is one of those button locks. You have no idea what the "  +
                    "combination is. You wish you colud somehow see where the dirty " +
                    "fingerprints were, maybe that would help. \n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    // Lock_2
    void State_lock_2()
    {
        text.text = "You carefully put the mirror thorugh the bars, and turn it round " +
                    "so you can see the lock. You can just make out fingerprints around " +
                    "the buttons. You press the dirty buttons, and fingerprints around \n\n" +
                    "Press O to Open, or R to Return to your cell";
        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.freedom;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    // Freedom
    void State_freedom()
    {
        text.text = "You are FREE!\n\n" +
                    "Press P  to Play again";
            if (Input.GetKeyDown(KeyCode.P)) { myState = States.cell; }
   
    }
}
