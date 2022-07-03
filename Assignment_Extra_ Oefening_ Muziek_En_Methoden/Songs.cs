using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class Songs
    {
        public static string nowPlaying = "";
        internal Songplayer player = new Songplayer(); // kan dat problemen geven de instance hier maar eenmaal aanroepen?
        public void RandomSong()
        {

            Random random = new Random();
            int note = random.Next(262, 494);
            int octave = random.Next(0, 3);
            int speed = random.Next(2, 5);
            int[,] song = { { note, octave, speed } };
            nowPlaying = "RandomSong";
            player.PlaySong(song);
        }
        public void Molla()
        {
            int tempo = 1800; // quarternote based
            int[,] song =
        {
            {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Quarter },
            {(int)Notes.ReN, (int)OL.five, (int)RD.Eights },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Quarter },
            {(int)Notes.Rst, (int)OL.five, (int)RD.Eights },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
            {(int)Notes.Rst, (int)OL.five, (int)RD.Eights },

            {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
            {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.ReS, (int)OL.five, (int)RD.Eights },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
            {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Eights },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Quarter },
            {(int)Notes.Rst, (int)OL.five, (int)RD.Eights },
            {(int)Notes.ReN, (int)OL.five, (int)RD.Eights },
            
            {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.ReS, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.DoN, (int)OL.six, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.SiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.LaN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.ReN, (int)OL.five, (int)RD.Sixtenths },

            {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.ReN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.ReN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
            {(int)Notes.Sol, (int)OL.five, (int)RD.Sixtenths },

            };
            nowPlaying = "Molla";
            player.PlaySong(song,tempo);
        }

        public void ACDC()
        {
            int tempo = 1800;// quarternote based
            int[,] song =
            {
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 1
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 1
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 2
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 2
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 1
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 1
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.Sol,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 2
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group 2
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.SoS,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group3
                {(int)Notes.DoN, (int)OL.six,  (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaS,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaN,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaS,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaN, (int)OL.five,  (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.FaN,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },//group3 
                {(int)Notes.DoN, (int)OL.six,  (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaS,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaN,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaS,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.LaN, (int)OL.five,  (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.FaN,(int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Sixtenths },
                {(int)Notes.MiN,(int)OL.five, (int)RD.Sixtenths },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },//group4
                {(int)Notes.Rst, 0,  (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Rst, 0,  (int)RD.Eights },
                {(int)Notes.Rst, 0,  (int)RD.Eights },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.ReN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },//group4
                {(int)Notes.Rst, 0,  (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Rst, 0,  (int)RD.Eights },
                {(int)Notes.Rst, 0,  (int)RD.Eights },

                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.ReN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },

            };
            nowPlaying = "AC/DC";
            player.PlaySong(song, tempo);
        }
        public void FurElise()
        {
            int tempo = 1800;// quarternote based
            int[,] song =
            {
                {(int)Notes.DoN, (int)OL.six, (int)RD.Eights },
                {(int)Notes.SiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.six, (int)RD.Eights },
                {(int)Notes.SiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.six, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Eights },
                {(int)Notes.LaS, (int)OL.five, (int)RD.Eights },
                {(int)Notes.SoS, (int)OL.five, (int)RD.Eights },
                {(int)Notes.FaN, (int)OL.five, (int)RD.WholeNote },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.Rst, 0,  (int)RD.Quarter },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Eights },
                {(int)Notes.SoS, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.Rst, 0,  (int)RD.Quarter },

                {(int)Notes.DoN, (int)OL.six, (int)RD.Eights },
                {(int)Notes.SiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.six, (int)RD.Eights },
                {(int)Notes.SiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.DoN, (int)OL.six, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Eights },
                {(int)Notes.LaS, (int)OL.five, (int)RD.Eights },
                {(int)Notes.SoS, (int)OL.five, (int)RD.Eights },
                {(int)Notes.FaN, (int)OL.five, (int)RD.WholeNote },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.MiN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.Rst, 0,  (int)RD.Quarter },
                {(int)Notes.DoN, (int)OL.five, (int)RD.Eights },
                {(int)Notes.SoS, (int)OL.five, (int)RD.Eights },
                {(int)Notes.Sol, (int)OL.five, (int)RD.Eights },
                {(int)Notes.FaN, (int)OL.five, (int)RD.Quarter },
                {(int)Notes.Rst, 0,  (int)RD.Quarter },
            };
            nowPlaying = "Fur Elise";
            player.PlaySong(song, tempo);
        }

    }
}
