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
using System.Xml;


namespace TextAdventureForm {
    public partial class BaseForm : Form {

        //variable to store room exit

        public string exitString;

        public string xcoord;
        public string ycoord;
        private int xInt;
        private int yInt;

        //create rooms grid
        private static Rooms[,] rooms;  //2D array of type room

        public static Rooms[,] Room
        {
            get { return rooms; }
        }

        public BaseForm()
        {
            InitializeComponent();
        }



        private void BaseForm_Load(object sender, EventArgs e)
        {
            //start function
            //set how many rooms there will be
            rooms = new Rooms[6, 3]; //x, y


            //Chris ignore this. Its broken and I didnt devote enough time to figure it out. :D
            //create a data table to import items to

            //sourced from: https://msdn.microsoft.com/en-us/library/58a18dwa(v=vs.110).aspx

            //   XmlSerializer ser = new XmlSerializer(typeof(DataSet));

            //creates a Dataset. Adds a table, column and 10 rows.
            //   DataSet datast = new DataSet("Items Data");
            //  DataTable table = new DataTable("itemsTable");
            //  DataColumn column = new DataColumn("itemTitle");
            //  DataColumn column2 = new DataColumn("itemDescription");


            //  table.Columns.Add(column);
            //  table.Columns.Add(column2);
            // datast.Tables.Add(table);
            //  DataRow row;

            //  for (int i = 0; i < 10; i++)
            //  {
            //     row = table.NewRow();
            //     row[0] = "Item " + i;
            //      table.Rows.Add(row);
            //  }
            //  TextWriter writer = new StreamWriter("itemsTable.xml");
            //  ser.Serialize(writer, datast);
            //  writer.Close();

        }




        private void UseBtn_Click(object sender, EventArgs e)
        {
            //Save room information

            //creates a new object
            Rooms room = new TextAdventure.Rooms();




            //setting object variables
            room.RoomTitle = roomTitle.Text;
            room.RoomDescription =  roomDescrip.Text;
            

           

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

            roomDescrip.Text = newRoom.RoomDescription;
            roomTitle.Text = newRoom.RoomTitle;

            
            fStream.Close();
        }



        private void CreateItemBtn_Click(object sender, EventArgs e)
        {
             Items item = new TextAdventure.Items();         

            

            item.ItemTitle = roomTitle.Text;
            item.ItemDescription = roomDescrip.Text;

            XmlSerializer ser = new XmlSerializer(typeof(Items));
            //creates the xml file
            TextWriter tw = new StreamWriter("itemFile.xml");

            ser.Serialize(tw, item);            
            tw.Close();          


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //use this to set exit direction
            //set box selected item to string value
           //exitString = comboBox1.SelectedValue.ToString();
        

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //y coordinate
           ycoord = numericUpDown2.Value.ToString();

            ///convert string to int so can use it to set coordinates
            yInt = Int32.Parse(ycoord);
            


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //x coordinate
            xcoord = numericUpDown1.Value.ToString();

            xInt = Int32.Parse(xcoord);
        }

        //save all data to xml
        private void button1_Click(object sender, EventArgs e)
        {

            //create room coordinates
            //using saved xcoord and ycoord variables set by user
            rooms = new Rooms[xInt,yInt];

            //create item
            Items item = new TextAdventure.Items();
            item.ItemTitle = itemTitle.Text;
            item.ItemDescription = itemDescrip.Text;

            XmlSerializer ser = new XmlSerializer(typeof(Items));
            //creates the xml file
            TextWriter tw = new StreamWriter("itemFile.xml");

            ser.Serialize(tw, item);
            tw.Close();


            //create room 

            //creates a new object
            Rooms room = new TextAdventure.Rooms();
            //setting object variables
            room.RoomTitle = roomTitle.Text;
            room.RoomDescription = roomDescrip.Text;

            //
            XmlSerializer ser2 = new XmlSerializer(typeof(Rooms));
            //creates the xml file
            TextWriter tw2 = new StreamWriter("itemFile.xml");

            ser2.Serialize(tw2, room);


            tw2.Close();

            //set exit
            //using saved string value as the direction.
            room.AddExit(exitString);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load saved data
            XmlSerializer ser = new XmlSerializer(typeof(Rooms));
            FileStream fStream = new FileStream("roomFile.xml", FileMode.Open);
            Rooms newRoom = (Rooms)ser.Deserialize(fStream);

            roomDescrip.Text = newRoom.RoomDescription;
            roomTitle.Text = newRoom.RoomTitle;


            //load saved data
            XmlSerializer ser2 = new XmlSerializer(typeof(Items));
            FileStream fStream2 = new FileStream("itemFile.xml", FileMode.Open);
            Items newItem = (Items)ser.Deserialize(fStream2);

            itemDescrip.Text = newItem.ItemDescription;
            itemTitle.Text = newItem.ItemTitle; 

            //get coordinates
            

            fStream2.Close();
            fStream.Close();
        }
    }
}
