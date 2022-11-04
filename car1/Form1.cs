using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TrackBar = System.Windows.Forms.TrackBar;

namespace car1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Car car1;
        public Form1()
        {
            InitializeComponent();
            
            car1 = new Car("Toyota");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private bool _IsOn;
        bool start;
        public bool IsOn
        {
            get
            {
                return _IsOn;
            }
            set
            {
                _IsOn = value;
                EngineIgnition.Text = _IsOn ? "Start" : "Stop";
            }
        }
        private void EngineIgnition_Click(object sender, EventArgs e)
        {
            if (start != true)
            {
                RefreshData();
                car1.NeutralGear();
                SpeedUp.Enabled = false;
                SlowDown.Enabled = false;
                trackBar1.Enabled = false;
                setSpeedBox.Enabled = false;
                NeutralGear.Enabled = true;
               
                start = true;
            }
            else if(start != false)
            {
                RefreshData();
                
                car1.CurrentEngineSpeed = 0;
                setSpeedBox.Enabled = true;
                SpeedUp.Enabled = true;
                SlowDown.Enabled = true;
                trackBar1.Enabled = true;
                NeutralGear.Enabled = true;

                start = false;
            }
            IsOn = !IsOn;

        }
        void RefreshData()
        {
            CarNameDisplay.Text = car1.Name;
            CurrentSpeedDisplay.Text = car1.CurrentSpeed.ToString();
            EngineSpeedDisplay.Text = car1.CurrentEngineSpeed.ToString();
            CurrentGearDisplay.Text = car1.CurrentGear.ToString();
        }

        int GetSpeed()
        {
            var input = setSpeedBox.Text;
            if (input == "")
            {
                return 0;
            }
            else if (int.Parse(input) < 0)
            {
                return 0;
            }
            else
            {
                return int.Parse(input);
            }

        }

        private void SpeedUp_Click(object sender, EventArgs e)
        {
            car1.IncreaseSpeed(GetSpeed());
            RefreshData();
        }

        private void SlowDown_Click(object sender, EventArgs e)
        {
            car1.DecreaseSpeed(GetSpeed());
            RefreshData();
        }

        private void TrackBar_SpeedUP_SlowDown_Scroll(object sender, EventArgs e)
        {
            var input = ((TrackBar)sender).Value;
            var carSpeed = car1.CurrentSpeed;
            if (carSpeed < input)
            {
                car1.IncreaseSpeed(input - carSpeed);
            }
            else
            {
                car1.DecreaseSpeed(carSpeed - input);
            }
            RefreshData();
        }

        private void CreateCar_Click(object sender, EventArgs e)
        {
            car1 = new Car(NewCarName.Text);
            trackBar1.Value = car1.CurrentSpeed;
            RefreshData();
        }

        private void NeutralGear_Click(object sender, EventArgs e)
        {
            car1.NeutralGear();
            trackBar1.Value = car1.CurrentSpeed;
            RefreshData();
        }

        private void ParkingGear_Click(object sender, EventArgs e)
        {
            RefreshData();
            car1.ParkingGear();
        }
    }
}
