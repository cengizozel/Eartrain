using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenuOpener : MonoBehaviour
{
    public GameObject Panel;

    // INSTRUMENT
    public string[] instrument = new string[]{"Piano", "Guitar", "Violin", "Saxophone", "Flute", "Cello", "Clarinet"};    
    public string[] piano = new string[] { "Grand", "Rhodes", "Roto Organ" };
    public string[] guitar = new string[] { "Classical", "Acoustic", "Electric" };
    public string[] violin = new string[] { "Baroque", "Classical", "Stroh", "Electric", "5-String" };
    public string[] saxophone = new string[] { "Baritone", "Alto", "Tenor", "Soprano" };
    public string[] flute = new string[] { "Standard", "Piccolo", "Harmony" };
    public string[] cello = new string[] { "Acoustic", "Electric", "Violin", "Carbon Fiber" };
    public string[] clarinet = new string[] { "Bb Clarinet" };

    // ACTIVE RANGE
    public string[] active_range_1 = new string[] { "C3", "C4", "C5", "C6" };
    public string[] active_range_2 = new string[] { "C3", "C4", "C5", "C6" };

    // SINGLE NOTES
    public bool isSingle;
    public bool isSingleMC;

    // CHORDS
    public bool isChords;
    public bool isChordsMC;
    public bool isChordsArp;

    // INTERVALS
    public bool isInterval;
    public bool isIntervalMC;

    // SCALES
    public bool isScales;
    public bool isScalesMC;
    public bool isScalesArp;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

}
