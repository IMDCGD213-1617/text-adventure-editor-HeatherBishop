using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TextAdventure;

namespace TextAdventureForm {
    public partial class BaseForm : Form {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            FirstChoice();
        }


        private void FirstChoice() {
            OutputBox.Text = "";
            OutputBox.Text = "You have been tasked to work late and finish off some paperwork.\r\nMost of your collegues have already left.\nOnly a few loyal friends remain, but the mood is quickly becoming sour.\r\nThe thought of facing them is unbearable.\nUnfortunately, your pen has run out. You have no stapler or envelopes left.\r\nWithout them, there is no hope you will finish your work before the Boss gets back in the morning.\r\nAquire the items BLACK PEN, STAPLER, MANILLA ENVELOPE. Or get fired, your preference.\r\nNOTE: If you are stuck at any time, type HELP to see a list of commands.\r\nIf there is no text on the screen, type LOOK or EXAMINE.\r\nPress any key to begin.";
        }

        private void UseBtn_Click(object sender, EventArgs e)
        {
            //Player.Move();

            //creates a new object
            Rooms room = new TextAdventure.Rooms();
            //setting object variables
            room.RoomTitle = InputBox.Text;
            room.RoomDescription =  OutputBox.Text;

            //
            XmlSerializer ser = new XmlSerializer(typeof(Rooms));
            //creates the xml file
            TextWriter tw = new StreamWriter("filename2.xml");

            ser.Serialize(tw, room);
            tw.Close();
        }

        private void PickupBtn_Click(object sender, EventArgs e) {
            XmlSerializer ser = new XmlSerializer(typeof(Rooms));
            FileStream fStream = new FileStream("filename2.xml", FileMode.Open);
            Rooms newRoom = (Rooms)ser.Deserialize(fStream);

            OutputBox.Text = newRoom.RoomDescription;
            InputBox.Text = newRoom.RoomTitle;
            fStream.Close();
        }

        private void East_Click(object sender, EventArgs e)
        {
            
        }

        private void West_Click(object sender, EventArgs e) {

        }

        private void South_Click(object sender, EventArgs e) {

        }

        private void North_Click(object sender, EventArgs e) {

        }


    }
}
