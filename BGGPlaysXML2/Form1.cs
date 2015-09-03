using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;

namespace BGGPlaysXML2
{
    public partial class Form1 : Form
    {
        public Stack<GamePlay> Plays = new Stack<GamePlay>();
        public List<String> Output = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Length != 0)
            {
                buttonGenerate.Enabled = true;
            }
            else
                buttonGenerate.Enabled = false;
            
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Plays.Clear();
            Output.Clear();
            //First thing to do: get the XML file
            using (WebClient webclient = new WebClient())
            {
                //Build the URL
                string baseURI = "http://www.boardgamegeek.com/xmlapi2/plays?";
                string mindateString = dateTimePicker.Value.Year.ToString()
                    + "-" + dateTimePicker.Value.Month.ToString() + "-"
                    + dateTimePicker.Value.Day.ToString();
                string maxdateString = dateTimePickerEND.Value.Year.ToString()
                    + "-" + dateTimePickerEND.Value.Month.ToString() + "-"
                    + dateTimePickerEND.Value.Day.ToString();
                string parameters = "username=" + textBoxUser.Text + "&mindate=" + mindateString
                    + "&maxdate=" + maxdateString;
                string URIandPARAMS = baseURI + parameters;
                webclient.DownloadFile(URIandPARAMS, "plays.xml");
            }
            //Now to go thru the XML file, building and adding Play objects to the Stack
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("plays.xml");
            foreach (XmlNode node in xmldoc.DocumentElement)
            {
                string dateString = node.Attributes[1].InnerText;
                int Day = int.Parse(dateString.Substring(8));
                int Month = int.Parse(dateString.Substring(5, 2));
                int Year = int.Parse(dateString.Substring(0, 4));
                DateTime date = new DateTime(Year, Month, Day);
                string gameTitle = node["item"].Attributes[0].InnerText;
                string gameID = node["item"].Attributes[2].InnerText;
                Plays.Push(new GamePlay(gameTitle, gameID, date));
            }
            if (!shortFormatToolStripMenuItem.Checked)
            {
                FullFormat();
            }
            else
            {
                ShortFormat();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void shortFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldedDaysToolStripMenuItem.Checked = false; 
        }

        private void boldedDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shortFormatToolStripMenuItem.Checked = false;
        }

        private List<GamePlay> SortPlays(List<GamePlay> Plays)
        {
            List<GamePlay> SortedPlays = new List<GamePlay>();
            SortedPlays = Plays;
            bool swapFlag = true;
            while (swapFlag)
            {
                swapFlag = false;
                for (int i = 0; i <= SortedPlays.Count - 2; i++)
                {
                    int Q1 = SortedPlays.ElementAt(i).getQuantity();
                    int Q2 = SortedPlays.ElementAt(i + 1).getQuantity();
                    if (Q2 > Q1)
                    {
                        GamePlay tempPlay = SortedPlays.ElementAt(i);
                        SortedPlays[i] = SortedPlays[i + 1];
                        SortedPlays[i + 1] = tempPlay;
                        swapFlag = true;
                    }
                }
            }
            return SortedPlays;
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(((e.KeyData == Keys.Return) || (e.KeyData == Keys.Enter)) && buttonGenerate.Enabled )
            {
                buttonGenerate_Click((object)sender, (EventArgs) e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now.AddDays(-7);
        }

        private void FullFormat()
        {
            //First we need some lists. One for the games and another for the titles to check if its there
            var AddedPlaysLists = new List<List<GamePlay>>();
            var AddedTitlesLists = new List<List<String>>();
            var DaysToAdd = new List<String>();
            var AddedDays = new List<String>();
            var FirstListAddedPlays = new List<GamePlay>();
            var FirstListAddedTitles = new List<String>();
            AddedPlaysLists.Add(FirstListAddedPlays);
            AddedTitlesLists.Add(FirstListAddedTitles);
            string firstDay = Plays.ElementAt(0).getDay();
            if (boldedDaysToolStripMenuItem1.Checked)
            {
                firstDay = BoldWrap(firstDay);
            }
            if(underlineDaysToolStripMenuItem.Checked)
            {
                firstDay = UnderlineWrap(firstDay);
            }
            DaysToAdd.Add(firstDay);
            AddedDays.Add(Plays.ElementAt(0).getDay());
            //Go thru the stack, adding games to the list but only once if it already exists in the current day
            while (Plays.Count > 0)
            {
                GamePlay tempPlay = Plays.Pop();
                //if its not in the list, add it!
                if (!AddedDays.Contains(tempPlay.getDay()))
                {
                    string day = tempPlay.getDay();
                    AddedDays.Add(day);
                    if (boldedDaysToolStripMenuItem1.Checked)
                    {
                        day = BoldWrap(day);
                    }
                    if (underlineDaysToolStripMenuItem.Checked)
                    {
                        day = UnderlineWrap(day);
                    }
                    DaysToAdd.Add(day);
                    var newAddedPlaysList = new List<GamePlay>();
                    var newAddedTitlesList = new List<String>();
                    AddedPlaysLists.Add(newAddedPlaysList);
                    AddedTitlesLists.Add(newAddedTitlesList);
                }
                if (!AddedTitlesLists.Last().Contains(tempPlay.getTitle()))
                {
                    AddedPlaysLists.Last().Add(tempPlay);
                    AddedTitlesLists.Last().Add(tempPlay.getTitle());
                }
                else
                {
                    int indexOfMatch = AddedTitlesLists.Last().IndexOf(tempPlay.getTitle());
                    AddedPlaysLists.Last().ElementAt(indexOfMatch).IncrementQuantity();
                }
            }
            int NumberOfDays = DaysToAdd.Count();
            for (int i = 0; i < NumberOfDays; i++)
            {
                Output.Add(DaysToAdd[i]);
                AddedPlaysLists[i] = SortPlays(AddedPlaysLists[i]);
                foreach (GamePlay play in AddedPlaysLists[i])
                {
                    string formattedString = "[thing=" + play.getID() + "]"
                    + play.getTitle() + "[/thing]" + " x" + play.getQuantity().ToString();
                    if (!bGGFormattedOutputToolStripMenuItem.Checked)
                    {
                        formattedString = play.getTitle() + " x" + play.getQuantity().ToString();
                    }
                    Output.Add(formattedString);
                }
                Output.Add("\n");
            }
            textBoxOutput.Lines = Output.ToArray();
        }

        private void ShortFormat()
        {
            List<GamePlay> AddedPlays = new List<GamePlay>();
            List<String> AddedTitles = new List<String>();
            //Go thru the stack and add the games to the list, but only once if it is already there!
            while (Plays.Count > 0)
            {
                GamePlay tempPlay = Plays.Pop();
                if (!AddedTitles.Contains(tempPlay.getTitle()))
                {
                    AddedPlays.Add(tempPlay);
                    AddedTitles.Add(tempPlay.getTitle());
                }
                else
                {
                    int indexOfMatch = AddedTitles.IndexOf(tempPlay.getTitle());
                    AddedPlays.ElementAt(indexOfMatch).IncrementQuantity();
                }
            }
            AddedPlays = SortPlays(AddedPlays);
            //Now, we need to go thru each element in AddedPlays, adding it to output List<String>
            foreach (GamePlay play in AddedPlays)
            {
                string formattedString = "[thing=" + play.getID() + "]"
                    + play.getTitle() + "[/thing]" + " x" + play.getQuantity().ToString();
                if (!bGGFormattedOutputToolStripMenuItem.Checked)
                {
                    formattedString = play.getTitle() + " x" + play.getQuantity().ToString();
                }
                Output.Add(formattedString);
            }
            textBoxOutput.Lines = Output.ToArray();
        }

        private string UnderlineWrap(string arg)
        {
            return "[u]" + arg + "[/u]";
        }

        private string BoldWrap(string arg)
        {
            return "[b]" + arg + "[/b]";
        }

        private void textBoxOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
                textBoxOutput.SelectAll();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
