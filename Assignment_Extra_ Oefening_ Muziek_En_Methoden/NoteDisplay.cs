using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class NoteDisplay
    {
        public void DisplayNotes(int note, int octave) 
        {
                // was planning on rendering on proper sheet with bars ... far out of scope ^^
                //string[] symbols = { "♯" , "𝄀" , "♩" , "♪" , "♬" , "𝅗𝅥" , "𝅘𝅥𝅯" , "𝄽" , "𝄾" }; 
                Console.SetCursorPosition(50, 10);
                Console.WriteLine((Notes)note);
        }
    }
}
