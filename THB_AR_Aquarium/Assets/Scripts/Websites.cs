using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Websites : MonoBehaviour
{
    public void Mensa()
    {
        Application.OpenURL("https://www.studentenwerk-potsdam.de/essen/speiseplaene/");
    }

    public void Bibliothek()
    {
        Application.OpenURL("https://bibliothek.th-brandenburg.de/");
    }

    public void Audimax()
    {
        Application.OpenURL("https://www.th-brandenburg.de/startseite/");
    }

    public void Informatik()
    {
        Application.OpenURL("https://informatik.th-brandenburg.de/");
    }

    public void Wirtschaft()
    {
        Application.OpenURL("https://wirtschaft.th-brandenburg.de/");
    }

    public void Technik()
    {
        Application.OpenURL("https://technik.th-brandenburg.de/");
    }
}
