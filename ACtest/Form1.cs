using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssettoCorsaSharedMemory;

namespace ACtest
{
    public partial class Form1 : Form
    {
        AssettoCorsa ac = new AssettoCorsa();

        string M_StaticInfo = "";
        string M_PhysicsInfo = "";
        int M_Fuel = 0;
        int M_RPMS = 0;
        int M_Gear = 1;
        int M_Kmh = 0;
        int M_Maxrpm = 10000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ac.StaticInfoInterval = 5000; // Get StaticInfo updates ever 5 seconds
            ac.StaticInfoUpdated += ac_StaticInfoUpdated; // Add event listener for StaticInfo
            ac.PhysicsInterval = 100;
            ac.PhysicsUpdated += ac_PhysicsInfoUpdated;            
        }

        void ac_StaticInfoUpdated(object sender, StaticInfoEventArgs e)
        {
            M_Maxrpm = e.StaticInfo.MaxRpm;
            M_StaticInfo = "StaticInfo\r\n" +
                "  Car Model: " + e.StaticInfo.CarModel + "\r\n" +
                "  Track:     " + e.StaticInfo.Track + "\r\n" +
                "  Max RPM:   " + e.StaticInfo.MaxRpm;            
        }
        void ac_PhysicsInfoUpdated(object sender, PhysicsEventArgs e)
        {
            M_Fuel = Convert.ToInt32(e.Physics.Fuel);
            M_RPMS = Convert.ToInt32(e.Physics.Rpms);
            M_Gear = e.Physics.Gear;
            M_Kmh = Convert.ToInt32(Math.Round(e.Physics.SpeedKmh));
            M_PhysicsInfo = "PhysicsInfo\r\n" +
            "  SpeedKmh:     " + Math.Round(e.Physics.SpeedKmh) + "\r\n" +
            "  Gear:     " + e.Physics.Gear + "\r\n" +
            "  Rpms:     " + e.Physics.Rpms + "\r\n" +
            "  Fuel:     " + e.Physics.Fuel + "\r\n" +
            "  Brake:     " + e.Physics.Brake + "\r\n" +
            "  AccG:     " + Math.Round(e.Physics.AccG[0], 2) + " ," +
            Math.Round(e.Physics.AccG[1], 2) + " ," + Math.Round(e.Physics.AccG[2], 2) + "\r\n" +
            "  Velocity:     " + Math.Round(e.Physics.Velocity[0], 2) + " ," +
            Math.Round(e.Physics.Velocity[1], 2) + " ," + Math.Round(e.Physics.Velocity[2], 2) + "\r\n" +
            "  LocalAngularVelocity:   " + Math.Round(e.Physics.LocalAngularVelocity[0], 2) + " ," +
            Math.Round(e.Physics.LocalAngularVelocity[1], 2) + " ," + Math.Round(e.Physics.LocalAngularVelocity[2], 2) + "\r\n" +
            "  LocalVelocity:   " + Math.Round(e.Physics.LocalVelocity[0], 2) + " ," +
                Math.Round(e.Physics.LocalVelocity[1], 2) + " ," + Math.Round(e.Physics.LocalVelocity[2], 2) + "\r\n";
        }

        bool switch_ac = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (switch_ac == false)
            {
                ac.Start(); // Connect to shared memory and start interval timers
                button1.Text = "STOP";
                switch_ac = true;
            }
            else
            {
                ac.Stop(); // Connect to shared memory and stop interval timers
                button1.Text = "START";
                switch_ac = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_static.Text = M_StaticInfo;
            lab_physics.Text = M_PhysicsInfo;
            tb_fuel.Value = M_Fuel;
            tb_rpms.Maximum = M_Maxrpm;
            if (M_RPMS <= M_Maxrpm)
            {
                tb_rpms.Value = M_RPMS;
                tb_rpms.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            else
            {
                tb_rpms.Value = M_Maxrpm;
                tb_rpms.BackColor = Color.Red;
            }

            if (M_Gear == 0)
                lab_gear.Text = "R";
            else if (M_Gear == 1)
                lab_gear.Text = "N";
            else
                lab_gear.Text = (M_Gear - 1).ToString();
            lab_kmh.Text = M_Kmh.ToString();
        }
    }
}
