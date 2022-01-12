using System;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Guitarist
{
    public partial class Form1 : Form
    {
        const string NotesPath = @"C:\Users\hp\Desktop\ABC\C#\Guitarist\Resources\Notes\";
        SoundPlayer[] Notes;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string notesPath;
            string baseNotes = "eBGDAE";
            Notes = new SoundPlayer[120];

            for (int i = 0; i < 13; i++)
            {
                try
                {
                    notesPath = NotesPath + baseNotes[i / 20] + (i - 20 * (i / 20)) + ".wav";
                    Notes[i] = new SoundPlayer(notesPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
        }
        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            string[] Tabs = Tabs_TB.Lines;
            string _string = "e";

            for (int i = 0; i < Tabs.GetLength(0); i++)
            {
                for (int j = 0; j < Tabs[i].Length; j++)
                {
                    switch (Tabs[i][j])
                    {
                        //Strings:
                        // string 2 (B string)
                        case '(':
                            _string = "B";
                            break;
                        case ')':
                            _string = "e";
                            break;
                        // string 3 (G string)
                        case '[':
                            _string = "G";
                            break;
                        case ']':
                            _string = "e";
                            break;
                        // string 4 (D string)
                        case '{':
                            _string = "D";
                            break;
                        case '}':
                            _string = "e";
                            break;
                        // string 5 (A string)
                        case '/':
                            _string = "A";
                            break;
                        case '\\':
                            _string = "e";
                            break;
                        // string 6 (E string)
                        case '<':
                            _string = "E";
                            break;
                        case '>':
                            _string = "e";
                            break;
                        //Waiting
                        case '-':
                            Application.DoEvents();
                            Thread.Sleep(500);
                            break;
                        case '–':
                            Application.DoEvents();
                            Thread.Sleep(800);
                            break;
                        case '—':
                            Application.DoEvents();
                            Thread.Sleep(1000);
                            break;
                        //Playing
                        default:
                            try
                            {
                                int offset = int.Parse(Tabs[i][j].ToString());
                                int stringIndex = StringToPlay(_string);
                                Notes[stringIndex * 20 + offset].Play();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }
                            
                            break;
                    }
                }
                Application.DoEvents();
                Thread.Sleep(800);
            }
        }
        int StringToPlay(string noteStr)
        {
            string baseNotes = "eBGDAE";
            for (int i = 0; i < baseNotes.Length; i++)
            {
                if (baseNotes[i] == noteStr[0])
                    return i;
            }
            return -1;
        }
    }
}
