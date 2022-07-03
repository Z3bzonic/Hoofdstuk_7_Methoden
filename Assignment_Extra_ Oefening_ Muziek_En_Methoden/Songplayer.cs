using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    public class Songplayer
    {
        public void PlaySong(int[,] song, int tempo = 1000, string lyrics = "") // skipping lyrics -- not seen object types yet
        {
            BeeperOutput beep = new BeeperOutput();
            RythmDivider rythm = new RythmDivider();
            Octaver octave = new Octaver();
            NoteDisplay noteDisplay = new NoteDisplay();
            string playing = Songs.nowPlaying;

            // note - octavepicker (0 for C4to B4 - rythmpicker(safe till 2 on tempo 1000 result 127ms, will become buggy on most HW) 
                for (int i = 0; i < song.Length / 3; i++) //song.Length/3 omdat hij de total lenght doet maar gezien er 3 kolommen zijn...
                {
                    int finalTempo = rythm.DivideRythm(song[i, 0 + 2], tempo);
                    int finalPitch = octave.IncreaseOctave(song[i, 0], song[i, 0 + 1]);
                    beep.PlayNote(pitch: finalPitch, speed: finalTempo);
                    int note = song[i,0] ;
                    int octUp = song[i, 0 + 1];
                if (playing != "RandomSong")
                    {
                    noteDisplay.DisplayNotes(note,octUp);
                    }
                }
        }
    }
}
