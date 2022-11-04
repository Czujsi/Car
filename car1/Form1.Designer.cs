namespace car1
{
    partial class Form1
    {
        // / <summary>
        // / Wymagana zmienna projektanta.
        // / </summary>
        private System.ComponentModel.IContainer components = null;

        // / <summary>
        // / Wyczyść wszystkie używane zasoby.
        // / </summary>
        // / <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        // / <summary>
        // / Metoda wymagana do obsługi projektanta — nie należy modyfikować
        // / jej zawartości w edytorze kodu.
        // / </summary>
        private void InitializeComponent()
        {
            this.CarNameDisplay = new System.Windows.Forms.Label();
            this.CurrentSpeedDisplay = new System.Windows.Forms.Label();
            this.SpeedUp = new System.Windows.Forms.Button();
            this.SlowDown = new System.Windows.Forms.Button();
            this.setSpeedBox = new System.Windows.Forms.TextBox();
            this.EngineSpeedDisplay = new System.Windows.Forms.Label();
            this.CurrentGearDisplay = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.CreateCar = new System.Windows.Forms.Button();
            this.NewCarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NeutralGear = new System.Windows.Forms.Button();
            this.EngineIgnition = new System.Windows.Forms.Button();
            this.ParkingGear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarNameDisplay
            // 
            this.CarNameDisplay.AutoSize = true;
            this.CarNameDisplay.Location = new System.Drawing.Point(433, 184);
            this.CarNameDisplay.Name = "CarNameDisplay";
            this.CarNameDisplay.Size = new System.Drawing.Size(35, 13);
            this.CarNameDisplay.TabIndex = 1;
            this.CarNameDisplay.Text = "Name";
            // 
            // CurrentSpeedDisplay
            // 
            this.CurrentSpeedDisplay.AutoSize = true;
            this.CurrentSpeedDisplay.Location = new System.Drawing.Point(310, 184);
            this.CurrentSpeedDisplay.Name = "CurrentSpeedDisplay";
            this.CurrentSpeedDisplay.Size = new System.Drawing.Size(106, 13);
            this.CurrentSpeedDisplay.TabIndex = 2;
            this.CurrentSpeedDisplay.Text = "CurrentSpeedDisplay";
            // 
            // SpeedUp
            // 
            this.SpeedUp.Location = new System.Drawing.Point(475, 315);
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.Size = new System.Drawing.Size(125, 28);
            this.SpeedUp.TabIndex = 3;
            this.SpeedUp.Text = "Speed Up";
            this.SpeedUp.UseVisualStyleBackColor = true;
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            // 
            // SlowDown
            // 
            this.SlowDown.Location = new System.Drawing.Point(226, 313);
            this.SlowDown.Name = "SlowDown";
            this.SlowDown.Size = new System.Drawing.Size(135, 30);
            this.SlowDown.TabIndex = 4;
            this.SlowDown.Text = "SlowDown";
            this.SlowDown.UseVisualStyleBackColor = true;
            this.SlowDown.Click += new System.EventHandler(this.SlowDown_Click);
            // 
            // setSpeedBox
            // 
            this.setSpeedBox.Location = new System.Drawing.Point(336, 255);
            this.setSpeedBox.Name = "setSpeedBox";
            this.setSpeedBox.Size = new System.Drawing.Size(183, 20);
            this.setSpeedBox.TabIndex = 5;
            // 
            // EngineSpeedDisplay
            // 
            this.EngineSpeedDisplay.AutoSize = true;
            this.EngineSpeedDisplay.Location = new System.Drawing.Point(301, 109);
            this.EngineSpeedDisplay.Name = "EngineSpeedDisplay";
            this.EngineSpeedDisplay.Size = new System.Drawing.Size(105, 13);
            this.EngineSpeedDisplay.TabIndex = 6;
            this.EngineSpeedDisplay.Text = "EngineSpeedDisplay";
            // 
            // CurrentGearDisplay
            // 
            this.CurrentGearDisplay.AutoSize = true;
            this.CurrentGearDisplay.Location = new System.Drawing.Point(422, 107);
            this.CurrentGearDisplay.Name = "CurrentGearDisplay";
            this.CurrentGearDisplay.Size = new System.Drawing.Size(98, 13);
            this.CurrentGearDisplay.TabIndex = 7;
            this.CurrentGearDisplay.Text = "CurrentGearDisplay";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(250, 381);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(315, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar_SpeedUP_SlowDown_Scroll);
            // 
            // CreateCar
            // 
            this.CreateCar.Location = new System.Drawing.Point(12, 12);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(157, 26);
            this.CreateCar.TabIndex = 9;
            this.CreateCar.Text = "Create Car";
            this.CreateCar.UseVisualStyleBackColor = true;
            this.CreateCar.Click += new System.EventHandler(this.CreateCar_Click);
            // 
            // NewCarName
            // 
            this.NewCarName.Location = new System.Drawing.Point(12, 44);
            this.NewCarName.Name = "NewCarName";
            this.NewCarName.Size = new System.Drawing.Size(157, 20);
            this.NewCarName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // NeutralGear
            // 
            this.NeutralGear.Location = new System.Drawing.Point(594, 147);
            this.NeutralGear.Name = "NeutralGear";
            this.NeutralGear.Size = new System.Drawing.Size(40, 37);
            this.NeutralGear.TabIndex = 12;
            this.NeutralGear.Text = "N";
            this.NeutralGear.UseVisualStyleBackColor = true;
            this.NeutralGear.Click += new System.EventHandler(this.NeutralGear_Click);
            // 
            // EngineIgnition
            // 
            this.EngineIgnition.Location = new System.Drawing.Point(681, 304);
            this.EngineIgnition.Name = "EngineIgnition";
            this.EngineIgnition.Size = new System.Drawing.Size(46, 39);
            this.EngineIgnition.TabIndex = 13;
            this.EngineIgnition.Text = "Start";
            this.EngineIgnition.UseVisualStyleBackColor = true;
            this.EngineIgnition.Click += new System.EventHandler(this.EngineIgnition_Click);
            // 
            // ParkingGear
            // 
            this.ParkingGear.Location = new System.Drawing.Point(640, 147);
            this.ParkingGear.Name = "ParkingGear";
            this.ParkingGear.Size = new System.Drawing.Size(40, 37);
            this.ParkingGear.TabIndex = 14;
            this.ParkingGear.Text = "P";
            this.ParkingGear.UseVisualStyleBackColor = true;
            this.ParkingGear.Click += new System.EventHandler(this.ParkingGear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 473);
            this.Controls.Add(this.ParkingGear);
            this.Controls.Add(this.EngineIgnition);
            this.Controls.Add(this.NeutralGear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewCarName);
            this.Controls.Add(this.CreateCar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.CurrentGearDisplay);
            this.Controls.Add(this.EngineSpeedDisplay);
            this.Controls.Add(this.setSpeedBox);
            this.Controls.Add(this.SlowDown);
            this.Controls.Add(this.SpeedUp);
            this.Controls.Add(this.CurrentSpeedDisplay);
            this.Controls.Add(this.CarNameDisplay);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CarNameDisplay;
        private System.Windows.Forms.Label CurrentSpeedDisplay;
        private System.Windows.Forms.Button SpeedUp;
        private System.Windows.Forms.Button SlowDown;
        private System.Windows.Forms.TextBox setSpeedBox;
        private System.Windows.Forms.Label EngineSpeedDisplay;
        private System.Windows.Forms.Label CurrentGearDisplay;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.TextBox NewCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NeutralGear;
        private System.Windows.Forms.Button EngineIgnition;
        private System.Windows.Forms.Button ParkingGear;
    }
}

