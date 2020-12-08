using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayNote : MonoBehaviour
{
    public AudioSource note_C;
    public AudioSource note_Cs;
    public AudioSource note_D;
    public AudioSource note_Ds;
    public AudioSource note_E;
    public AudioSource note_F;
    public AudioSource note_Fs;
    public AudioSource note_G;
    public AudioSource note_Gs;
    public AudioSource note_A;
    public AudioSource note_As;
    public AudioSource note_B;

    public int note = 0;
    public int random_note = 0;
    public Text feedback;
    public Text random_played;
    public string[] notes_array = { "NaN", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    public void Check_Correctness()
    {
        if (notes_array[note] == random_played.text)
        {
            feedback.text = "Correct.\n" + notes_array[note];
        }
        else
        {
            feedback.text = "Wrong.\nIt was " + random_played.text + ".\nYou played " + notes_array[note] + ".";
        }
    }

    public void Note_C_Play()
    {
        note_C.Play();
        note = 1;
        Check_Correctness();
    }

    public void Note_Cs_Play()
    {
        note_Cs.Play();
        note = 2;
        Check_Correctness();
    }

    public void Note_D_Play()
    {
        note_D.Play();
        note = 3;
        Check_Correctness();
    }

    public void Note_Ds_Play()
    {
        note_Ds.Play();
        note = 4;
        Check_Correctness();
    }

    public void Note_E_Play()
    {
        note_E.Play();
        note = 5;
        Check_Correctness();
    }

    public void Note_F_Play()
    {
        note_F.Play();
        note = 6;
        Check_Correctness();
    }

    public void Note_Fs_Play()
    {
        note_Fs.Play();
        note = 7;
        Check_Correctness();
    }

    public void Note_G_Play()
    {
        note_G.Play();
        note = 8;
        Check_Correctness();
    }

    public void Note_Gs_Play()
    {
        note_Gs.Play();
        note = 9;
        Check_Correctness();
    }

    public void Note_A_Play()
    {
        note_A.Play();
        note = 10;
        Check_Correctness();
    }

    public void Note_As_Play()
    {
        note_As.Play();
        note = 11;
        Check_Correctness();
    }

    public void Note_B_Play()
    {
        note_B.Play();
        note = 12;
        Check_Correctness();
    }

    public void Play_Random()
    {
        random_note = Random.Range(1, 12);
        random_played.text = notes_array[random_note];

        if (random_note == 1)
        {
            note_C.Play();
        }

        else if (random_note == 2)
        {
            note_Cs.Play();
        }

        else if (random_note == 3)
        {
            note_D.Play();
        }

        else if (random_note == 4)
        {
            note_Ds.Play();
        }

        else if (random_note == 5)
        {
            note_E.Play();
        }

        else if (random_note == 6)
        {
            note_F.Play();
        }

        else if (random_note == 7)
        {
            note_Fs.Play();
        }

        else if (random_note == 8)
        {
            note_G.Play();
        }

        else if (random_note == 9)
        {
            note_Gs.Play();
        }

        else if (random_note == 10)
        {
            note_A.Play();
        }

        else if (random_note == 11)
        {
            note_As.Play();
        }

        else if (random_note == 12)
        {
            note_B.Play();
        }
        else
        {
            // block of code to be executed if the condition1 is false and condition2 is False
        }
  
    }
}
