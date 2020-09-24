namespace ACtest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_static = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_physics = new System.Windows.Forms.Label();
            this.tb_fuel = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rpms = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_gear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_kmh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rpms)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_static
            // 
            this.lab_static.AutoSize = true;
            this.lab_static.Font = new System.Drawing.Font("新細明體", 12F);
            this.lab_static.Location = new System.Drawing.Point(6, 18);
            this.lab_static.Name = "lab_static";
            this.lab_static.Size = new System.Drawing.Size(67, 16);
            this.lab_static.TabIndex = 1;
            this.lab_static.Text = "Staticinfo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_static);
            this.groupBox1.Location = new System.Drawing.Point(27, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staticinfo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_physics);
            this.groupBox2.Location = new System.Drawing.Point(233, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 277);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Physicsinfo";
            // 
            // lab_physics
            // 
            this.lab_physics.AutoSize = true;
            this.lab_physics.Font = new System.Drawing.Font("新細明體", 12F);
            this.lab_physics.Location = new System.Drawing.Point(6, 18);
            this.lab_physics.Name = "lab_physics";
            this.lab_physics.Size = new System.Drawing.Size(80, 16);
            this.lab_physics.TabIndex = 1;
            this.lab_physics.Text = "Physicsinfo";
            // 
            // tb_fuel
            // 
            this.tb_fuel.Location = new System.Drawing.Point(25, 337);
            this.tb_fuel.Maximum = 100;
            this.tb_fuel.Name = "tb_fuel";
            this.tb_fuel.Size = new System.Drawing.Size(73, 45);
            this.tb_fuel.TabIndex = 3;
            this.tb_fuel.TabStop = false;
            this.tb_fuel.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "FUEL";
            // 
            // tb_rpms
            // 
            this.tb_rpms.Location = new System.Drawing.Point(106, 322);
            this.tb_rpms.Maximum = 10000;
            this.tb_rpms.Name = "tb_rpms";
            this.tb_rpms.Size = new System.Drawing.Size(164, 45);
            this.tb_rpms.TabIndex = 3;
            this.tb_rpms.TabStop = false;
            this.tb_rpms.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "RPMS";
            // 
            // lab_gear
            // 
            this.lab_gear.AutoSize = true;
            this.lab_gear.Font = new System.Drawing.Font("新細明體", 24F);
            this.lab_gear.Location = new System.Drawing.Point(338, 335);
            this.lab_gear.Name = "lab_gear";
            this.lab_gear.Size = new System.Drawing.Size(37, 32);
            this.lab_gear.TabIndex = 4;
            this.lab_gear.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "GEAR";
            // 
            // lab_kmh
            // 
            this.lab_kmh.AutoSize = true;
            this.lab_kmh.Font = new System.Drawing.Font("新細明體", 24F);
            this.lab_kmh.Location = new System.Drawing.Point(462, 335);
            this.lab_kmh.Name = "lab_kmh";
            this.lab_kmh.Size = new System.Drawing.Size(30, 32);
            this.lab_kmh.TabIndex = 4;
            this.lab_kmh.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "KMH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 438);
            this.Controls.Add(this.lab_kmh);
            this.Controls.Add(this.lab_gear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_rpms);
            this.Controls.Add(this.tb_fuel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rpms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_static;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_physics;
        private System.Windows.Forms.TrackBar tb_fuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_rpms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_gear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_kmh;
        private System.Windows.Forms.Label label4;
    }
}

