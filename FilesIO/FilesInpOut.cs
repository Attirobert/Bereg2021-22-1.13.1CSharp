using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesIO
{
    class FilesInpOut
    {
        // Osztályváltozók
        private string fileName;
        private FileMode fileMode;
        private FileAccess fileAccess;
        private FileStream fs;
        private StreamReader sr;


        public FilesInpOut() {
            setFileName();  // Fájl nevének bekérése
            setFileMode();  // Megnyitás módjának bekérése
            setFileAccess();    // Hozzáférés módjának beállítása
        }

        private void setFileName()
        {
            Console.WriteLine("Adja meg a fájl nevét kiterjesztés nélkül:");
            this.fileName = Console.ReadLine() + ".txt";
        }

        private void setFileMode()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a műveletet:");
            Console.WriteLine("     cr:  Create");
            Console.WriteLine("     crn: CreateNew");
            Console.WriteLine("     o:   Open");
            Console.WriteLine("     oc:  OpenOrCreate");
            Console.WriteLine("     a:   Append");
            Console.WriteLine("     t:   Truncate");

            do
            {
                ismet = false;
                s = Console.ReadLine();
                switch (s)
                {
                    case "cr": fileMode = FileMode.Create; break;       // Létrehoz egy új fájlt, ha már létezik, a tartalmát kitörli.
                    case "crn": fileMode = FileMode.CreateNew; break;   // Mint előbb, de ha már létezik a fájl, akkor kivételt dob.
                    case "o": fileMode = FileMode.Open; break;          // Megnyit egy fájlt, ha nem létezik, kivételt dob.
                    case "oc": fileMode = FileMode.OpenOrCreate; break; // Mintelőbb, de ha nem létezik, akkor létrehozza a fájlt.
                    case "a": fileMode = FileMode.Append; break;        // Megnyit egy fájlt és automatikusan a végére áll. Ha nem létezik, létrehozza.
                    case "t": fileMode = FileMode.Truncate; break;      // Megnyit egy létező fájlt és törli a tartalmát.  Ebben a módban a fájl  tartalmát nem lehet olvasni (egyébként kivételt dob).
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true;
                        break;
                }
            } while (ismet);
        }

        private void setFileAccess()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a fájl hozzáférést:");
            Console.WriteLine("     r:  Olvasás");
            Console.WriteLine("     w:  Írás");
            Console.WriteLine("     rw: Olvasás és írás");

            do
            {
                ismet = false;
                s = Console.ReadLine();
                switch (s)
                {
                    case "r": fileAccess = FileAccess.Read; break;
                    case "w": fileAccess = FileAccess.Write; break;
                    case "rw": fileAccess = FileAccess.ReadWrite; break;
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true;
                        break;
                }
            } while (ismet);
        }

        public StreamReader getFile()
        {
            this.fs = new FileStream(this.fileName, this.fileMode, this.fileAccess);
            this.sr = new StreamReader(fs);
            return sr;
        }

        public void closeFile()
        {
            if (this.sr != null) this.sr.Close();
            if (this.fs != null) this.fs.Close();
        }

    }
    internal class FilesIO
    {
        static void Main(string[] args)
        {
            FilesInpOut f = new FilesInpOut();
            StreamReader sr = f.getFile();

            // Dolgozunk a fájllal
            // Egészet kiolvassa
            string s = sr.ReadToEnd();
            Console.WriteLine(s);

            Console.WriteLine();
            // Soronként olvas
            //s = sr.ReadLine();
            while (!sr.EndOfStream) // s != null
            {
                Console.WriteLine(s);
                s = sr.ReadLine();
            }

            Console.ReadKey();
            f.closeFile();
        }
    }
}
