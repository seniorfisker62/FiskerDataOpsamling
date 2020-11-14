using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Linq.Expressions;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Reflection.Emit;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;

namespace LysthusData
{
    public partial class Form1 : Form
    {
        public const int Sensor1Temp = 1;
        public const int Sensor1Hum = 2;
        public const int Sensor2Temp = 3;
        public const int Sensor2Hum = 4;
        public const int Blaeservarme = 9;
        public const int Olievarme = 10;

        public const int LampON = 5;
        public const int LampOFF = 6;
        public const int idle = 0;
        public const int off = 0;
        public const int on = 1;
        public const int change = 2;
        public const int sec5 = 5;

        Byte[] sendBytes;
        Byte[] receiveBytes;
        string returnData;
        int lampstate = off;
        public bool TimetoMeasure = false;
        public int seccnt = 0;
        public bool MongoDBchecked = false;
        public int cntminute = 0;
        public int blaeserMSec = 0;
        public int olieMSec = 0;
        
        //Port and IP Data for Socket Client
        IPAddress IP = IPAddress.Parse("192.168.0.3");
        public int port = 8888;

        static string fileName = @"C:\lysthusdata\logfile.txt";
        public StreamWriter log = new StreamWriter(fileName);

        private void addlog(string newentry)
        {            
            log.WriteLine(DateTime.Now.ToString() + " : " + newentry);
            log.Flush();    
        }

        public Form1()
        {
            InitializeComponent();
            this.Text = "Lysthus Data 2.0.1";
            cntminute = 30;            
            addlog("program start");
            chkMongoDBgem.Checked = true;
            chkContMeasure.Checked = false;
            chkSensor1.Checked = true;
            chkSensor2.Checked = true;
        }

        private void showTime(int newtime)
        {
            int minpart = newtime / 60;
            int secpart = newtime - (minpart * 60);
            
            lbltimerMin.Text = minpart.ToString();
            lblTimerSec.Text = secpart.ToString();
        }

        private void timSendToArduino_Tick(object sender, EventArgs e)
        {
            arduinoComm();
        }

        private void arduinoComm()
        {
            seccnt ++;
            
            int tempsec = 0;
            if (chkContMeasure.Checked)
            {
                tempsec = sec5 - seccnt;
            }
            else
            {
                tempsec = cntminute - seccnt;
            }
            showTime(tempsec);

            if ((seccnt >= cntminute) || (chkContMeasure.Checked && (seccnt >= sec5)))
            {
                ChangeMeasureTime();
                timSendToArduino.Stop();
                seccnt = 0;
                TimetoMeasure = true;
            }

            if (TimetoMeasure || (lampstate == change))
            {
                Boolean IPpresent = false;
                try
                {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send("192.168.0.3", 1000);
                    if (reply.Status.ToString().Equals("Success"))
                    {
                        IPpresent = true;
                    } else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    TimetoMeasure = false;
                    timSendToArduino.Start();
                    txtStatus.Text = "ERROR: Arduino IP not present";
                    addlog("ERROR: Arduino IP not present");
                }

                if (IPpresent)
                {
                    txtStatus.Text = "Measuring";

                    Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    IPEndPoint sendReceiveEndPoint = new IPEndPoint(IP, port);                    
                    UdpClient clientReturn = new UdpClient(port);

                    if (chkSensor1.Checked)
                    {
                        // Temperature 1  lysthus temperature  
                        sendBytes = Encoding.ASCII.GetBytes(Sensor1Temp.ToString());
                        udpClient.SendTo(sendBytes, sendReceiveEndPoint);
                        returnData = string.Empty;
                        receiveBytes = clientReturn.Receive(ref sendReceiveEndPoint);
                        returnData = Encoding.ASCII.GetString(receiveBytes);
                        if (returnData == null) {returnData = string.Empty;}
                        lblTemp1.Text = returnData.ToString();

                        // Humidity 1  lysthus humidity   
                        sendBytes = Encoding.ASCII.GetBytes(Sensor1Hum.ToString());
                        udpClient.SendTo(sendBytes, sendReceiveEndPoint);
                        returnData = string.Empty;
                        receiveBytes = clientReturn.Receive(ref sendReceiveEndPoint);
                        returnData = Encoding.ASCII.GetString(receiveBytes);
                        if (returnData == null) { returnData = string.Empty; }
                        lblHum1.Text = returnData.ToString();
                    }


                    if (chkSensor2.Checked)
                    {
                        // Temperature 2  lysthus ude temperature
                        sendBytes = Encoding.ASCII.GetBytes(Sensor2Temp.ToString());
                        udpClient.SendTo(sendBytes, sendReceiveEndPoint);
                        returnData = string.Empty;
                        receiveBytes = clientReturn.Receive(ref sendReceiveEndPoint);
                        returnData = Encoding.ASCII.GetString(receiveBytes);
                        if (returnData == null) { returnData = string.Empty; }
                        lblTemp2.Text = returnData.ToString();

                        // Humidity 2  lysthus ude humidity   
                        sendBytes = Encoding.ASCII.GetBytes(Sensor2Hum.ToString());
                        udpClient.SendTo(sendBytes, sendReceiveEndPoint);
                        returnData = string.Empty;
                        receiveBytes = clientReturn.Receive(ref sendReceiveEndPoint);
                        returnData = Encoding.ASCII.GetString(receiveBytes);
                        if (returnData == null) { returnData = string.Empty; }
                        lblHum2.Text = returnData.ToString();
                    }


                    // blaeser time   
                    sendBytes = Encoding.ASCII.GetBytes(Blaeservarme.ToString());
                    udpClient.SendTo(sendBytes, sendReceiveEndPoint);
                    returnData = string.Empty;
                    receiveBytes = clientReturn.Receive(ref sendReceiveEndPoint);
                    returnData = Encoding.ASCII.GetString(receiveBytes);
                    if (returnData == null) { returnData = string.Empty; }
                    blaeserMSec += Int32.Parse(returnData);
                    TimeSpan ts = TimeSpan.FromSeconds(blaeserMSec/1000);
                    lblBlaeserHour.Text = ts.Hours.ToString();
                    lblBlaeserMin.Text = ts.Minutes.ToString();
                    lblBlaeserSec.Text = ts.Seconds.ToString();
                    
                    // olievarme time   
                    sendBytes = Encoding.ASCII.GetBytes(Olievarme.ToString());
                    udpClient.SendTo(sendBytes, sendReceiveEndPoint);
                    returnData = string.Empty;
                    receiveBytes = clientReturn.Receive(ref sendReceiveEndPoint);
                    returnData = Encoding.ASCII.GetString(receiveBytes);
                    if (returnData == null) { returnData = string.Empty; }
                    olieMSec += Int32.Parse(returnData);
                    ts = TimeSpan.FromSeconds(olieMSec / 1000);
                    lblOlieHour.Text = ts.Hours.ToString();
                    lblOlieMin.Text = ts.Minutes.ToString();
                    lblOlieSec.Text = ts.Seconds.ToString();

                    if (chkMongoDBgem.Checked)
                    {
                        newMongoData();
                    }
                    
                    TimetoMeasure = false;
                    sendReceiveEndPoint = null;
                    udpClient.Close();
                    clientReturn.Close();
                    timSendToArduino.Start();
                }
            }
            else
            {
               txtStatus.Text = "timing";
            }
        }

        private void newMongoData()
        {
            try
            { 
                MongoClient dbClient = new MongoClient("mongodb+srv://seniorfisker62:seniorfisker@cluster0-bau6k.mongodb.net/lysthusdata?retryWrites=true&w=majority");

                var database = dbClient.GetDatabase("lysthusdata");            
                var Coll = database.GetCollection<BsonDocument>("doegndata");

                var document = new BsonDocument
                {
                    {"Timestamp", DateTime.Now.ToString()},
                    {"LysthusTemp",lblTemp1.Text},
                    {"LysthusFugt",lblHum1.Text},
                    {"UdeTemp",lblTemp2.Text},
                    {"UdeFugt",lblHum2.Text},
                };
                Coll.InsertOne(document);

                database = null;
                dbClient = null;
            }
            catch
            {
                addlog("ERROR: MongoDB fejl");
            }
        }

        private void butLamp_Click(object sender, EventArgs e)
        {
            //lampstate = change;
        }

        private void chkContMeasure_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            { 
                if (chkMongoDBgem.Checked == true)
                { 
                    chkMongoDBgem.Checked = false;
                    chkMongoDBgem.Enabled = false;
                    MongoDBchecked = true;
                }
            }else
            {
                if (MongoDBchecked)
                {
                    chkMongoDBgem.Enabled = true;
                    chkMongoDBgem.Checked = true;
                    MongoDBchecked = false;
                }
            }
        }

        void ChangeMeasureTime()
        {
            cntminute = int.Parse(txtMeasureTime.Text) * 60;          
        }              

        private void butValueChange_Click(object sender, EventArgs e)
        {
            ChangeMeasureTime();
        }        

        private void timStatus_Tick(object sender, EventArgs e)
        {
            if (timSendToArduino.Enabled)
            {
                lblTimState.Text = "enabled";
            }else
            {
                lblTimState.Text = "disabled";
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
