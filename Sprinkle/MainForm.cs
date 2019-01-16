using System;
using System.Media;
using System.Windows.Forms;
using Sprinkle.WaterData;
using Sprinkle.Database;
using System.IO.Ports;
using System.Threading;
using System.Globalization;

namespace Sprinkle
{
    public partial class MainForm : Form
    {
        //for classifier function, we declared global variables
        private float Temp = 0;
        private float NTU = 0; //Water's Turbidity unit is NTU
        private float PH = 0; //pH of Water
        private float EC = 0; // Electric conductivity of water
        //Treading for parallel processing
        //creating new thread to open about page
        Thread aboutThread;
        Thread logThread; //for output log page

        //To read data sent by arduino
        SerialPort my_port = new SerialPort();

        //Making classifiers object to predict 
        //Classifier class handles the ML stuffs
        Classifier classifier = new Classifier();
        public int duration = 5; //duration to read data 

        //To insert result log in database
        SQLiteDB db = new SQLiteDB();
        //To check if already data inserted in db
        bool DBInsertFlag = false;

        public MainForm()
        {
            InitializeComponent();
            //initialize aboutThread for the first click on "wiki" 
            aboutThreadInitial();
            logThreadInitial(); //initialize logThread for the first click on "Output logs"
        }
        // to create threads for about page
        private void aboutThreadInitial()
        {
            aboutThread = new Thread(openAbout); //calling openAbout() method in thread
            aboutThread.SetApartmentState(ApartmentState.STA);
        }
        // to create threads for output log page
        private void logThreadInitial()
        {
            logThread = new Thread(openLog); //calling openLog() method in thread
            logThread.SetApartmentState(ApartmentState.STA);
        }

        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            //before reading, making sure all data containers' variables are set to 0
            Temp = 0;
            EC = 0;
            PH = 0;
            NTU = 0;
            try
            {
                //Process to read data from COM ports
                // 7 lines to edit
                my_port.BaudRate = 115200;
                my_port.PortName = PortComboBox.SelectedItem.ToString();
                my_port.Open();

                //fetced data to store as string
                string data; // = "22.5@4.39@9.89@0";
                DateTime Tthen = DateTime.Now;
                do
                {
                    data = my_port.ReadLine();
                    //after reading data is sent to parse into real forms
                    DataParsing(data);
                    onePing();
                } while (Tthen.AddSeconds(duration) > DateTime.Now);
                my_port.Close();
                // Now time to set the DBInsert flag to true, so database can be updated
                DBInsertFlag = true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!!");
            }
            
        }

        //split data string into different variables and showing them
        public void DataParsing(string _data)
        {
            // _data string is in this format
            // _data == temperature@conductivity@ph@turbidity
            var data = _data.Split('@');
            int totalData = _data.Split('@').Length;
            if (totalData == 4)
            {
                //Displaying the data in a panel
                turbidity.Text ="Turbidity: " + data[3] + "NTU";
                ph.Text = "Pouvoir Hydrogène: " + data[2] + "pH";
                temperature.Text = "Temperature: " + data[0] + "°C";
                conductivity.Text = "Conductivity: " + data[1] + "mS/cm";

                //now converting strings into float
                Temp = float.Parse(data[0], CultureInfo.InvariantCulture.NumberFormat);
                EC = float.Parse(data[1], CultureInfo.InvariantCulture.NumberFormat);
                PH = float.Parse(data[2], CultureInfo.InvariantCulture.NumberFormat);
                NTU = float.Parse(data[3], CultureInfo.InvariantCulture.NumberFormat);
            }
        }
        
        public void onePing()
        {
            SystemSounds.Question.Play();
        }

        //opens about page win "wiki" is clicked
        private void wiki_Click(object sender, EventArgs e)
        {
            if (aboutThread.ThreadState.Equals(ThreadState.Running))
            {
                // if running, abrot previous one and open new window by thread
                aboutThread.Abort();
                aboutThreadInitial();
                aboutThread.Start();

            }
            else
            {
                aboutThreadInitial();
                aboutThread.Start();
            }
        }

        //open about form
        private void openAbout()
        {
            //Application.Run(new About());
            About about = new About();
            about.ShowDialog();
        }

        private void outputLog_Click(object sender, EventArgs e)
        {
            if (logThread.ThreadState.Equals(ThreadState.Running))
            {
                // Message
                MessageBox.Show("'Output Log' is already opened in a window!", "Reminder!!");
            }
            else
            {
                logThreadInitial();
                logThread.Start();
            }
        }

        //open output log form
        private void openLog()
        {
            //Application.Run(new OutputLog());
            OutputLog log = new OutputLog();
            log.ShowDialog();
        }

        private void whoStandard_Click(object sender, EventArgs e)
        {
            if (EC != 0 || PH != 0 || NTU != 0)
            {
                //WHO standards condition
                if(EC >= 300 && EC <= 800 && PH >= 6.5 && PH <= 8.5 && NTU <= 5)
                {
                    result.Text = "Drinkable";
                }
                else
                {
                    result.Text = "Not Drinkable";
                }
            }
        }

        private void mlPrediction_Click(object sender, EventArgs e)
        {
            if(EC != 0 || PH != 0 || NTU !=0)
            {
                //when the parameters are not 0 then prediction shoud work
                try
                {
                    //does the prediction
                    result.Text = classifier.Classify(EC, PH, NTU);
                    if(DBInsertFlag == true)
                    {
                        // now save the log
                        db.InsertLog(Temp, PH, EC, NTU, result.Text);
                        DBInsertFlag = false;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
            
        }
    }
}
