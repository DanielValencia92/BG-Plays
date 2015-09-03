using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGGPlaysXML2
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            textBoxOutput.Text = "General Controls" + Environment.NewLine + Environment.NewLine
                        + "The Start Date and End Date controls allow you "
                        + "to restrict retrieval of plays to a certain date range." + Environment.NewLine + Environment.NewLine
                        + "The User textbox must be filled out with a bgg username to enable "
                        + "the Generate button. Pressing the Generate button will retrieve plays "
                        + "from BGG and load them into the text box below." + Environment.NewLine + Environment.NewLine
                        + "Menu Bar" + Environment.NewLine
                        + "The Menu Bar up top allows you to change some options, access this very help window, "
                        + "Or see some information about BG Plays.";
            textBoxOutput.DeselectAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            switch (selectedIndex)
            {
                case -1:
                    textBoxOutput.Text = "Please select an option from the left for more "
                        + "information.";
                    break;
                case 0:
                    textBoxOutput.Text = "General Controls" + Environment.NewLine + Environment.NewLine
                        + "The Start Date and End Date controls allow you "
                        + "to restrict retrieval of plays to a certain date range." + Environment.NewLine + Environment.NewLine
                        + "The User textbox must be filled out with a bgg username to enable "
                        + "the Generate button. Pressing the Generate button will retrieve plays "
                        + "from BGG and load them into the text box below." + Environment.NewLine + Environment.NewLine
                        + "Menu Bar" + Environment.NewLine
                        + "The Menu Bar up top allows you to change some options, access this very help window, "
                        + "Or see some information about BG Plays.";
                    break;
                case 1:
                    textBoxOutput.Text = "Short Format" + Environment.NewLine + Environment.NewLine
                        + "Short format will output your plays simply by number of plays "
                        + "and will not display days." + Environment.NewLine
                        + "Note that Short Format must be unchecked for Bolded Days and/or "
                        + "Underline Days to work.";
                    break;
                case 2:
                    textBoxOutput.Text = "Bolded Days" + Environment.NewLine + Environment.NewLine
                        + "Bolded Days will wrap the days with standard [b][/b] tags." + Environment.NewLine
                        + "This is useful if you want a more clear separation of days." + Environment.NewLine
                        + "Can be used in conjunction with \"Underline Days\"";
                    break;
                case 3:
                    textBoxOutput.Text = "Underlined Days" + Environment.NewLine + Environment.NewLine
                        + "Underlined Days will wrap the days with standard [u][/u] tags." + Environment.NewLine
                        + "This is useful if you want a more clear separation of days." + Environment.NewLine
                        + "Can be used in conjunction with \"Bolded Days\"";
                    break;
            }
        }
    }
}
