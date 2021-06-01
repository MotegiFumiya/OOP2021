using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("Let it be ","The Beatles ",243),
                new Song("Bridge Over Troubled Water ","Simon & Garfunkel ",293),
                new Song("Close To You ","Carpenters ",276),
                new Song("Honesty ","Billy Joel ",231),
                new Song("I Will Always Love You ","Whitney Houston ",273),
            };
            PrintSongs(songs);
        }
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {//引数数
                Console.WriteLine(@"{0}{1}{2:m\:ss}", song.Title, song.ArtistName,TimeSpan.FromSeconds( song.Length));
               //song.Title
            }
        }
        /* {0},{1}について
         {}の中で、は特別な意味を持て居る。その為:を文字':'として表示させるために
        \:としている。なお、\:をエスケープシーケンスと認識させないように、をせんとうにふかし、
        逐語的リテラル文字列にしている*/
    }
}
