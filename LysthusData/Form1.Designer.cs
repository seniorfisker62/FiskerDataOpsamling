﻿namespace LysthusData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkSensor2 = new System.Windows.Forms.CheckBox();
            this.chkSensor1 = new System.Windows.Forms.CheckBox();
            this.lblHum2 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblHum1 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.timSendToArduino = new System.Windows.Forms.Timer(this.components);
            this.chkContMeasure = new System.Windows.Forms.CheckBox();
            this.chkMongoDBgem = new System.Windows.Forms.CheckBox();
            this.lbltimerMin = new System.Windows.Forms.Label();
            this.txtMeasureTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butValueChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTimerSec = new System.Windows.Forms.Label();
            this.lblTimState = new System.Windows.Forms.Label();
            this.timStatus = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOlieHour = new System.Windows.Forms.Label();
            this.lblBlaeserHour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBlaeserMin = new System.Windows.Forms.Label();
            this.lblBlaeserSec = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOlieMin = new System.Windows.Forms.Label();
            this.lblOlieSec = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSensor2
            // 
            this.chkSensor2.AutoSize = true;
            this.chkSensor2.Location = new System.Drawing.Point(6, 57);
            this.chkSensor2.Name = "chkSensor2";
            this.chkSensor2.Size = new System.Drawing.Size(72, 17);
            this.chkSensor2.TabIndex = 14;
            this.chkSensor2.Text = "Udendørs";
            this.chkSensor2.UseVisualStyleBackColor = true;
            // 
            // chkSensor1
            // 
            this.chkSensor1.AutoSize = true;
            this.chkSensor1.Location = new System.Drawing.Point(6, 37);
            this.chkSensor1.Name = "chkSensor1";
            this.chkSensor1.Size = new System.Drawing.Size(73, 17);
            this.chkSensor1.TabIndex = 13;
            this.chkSensor1.Text = "Indendørs";
            this.chkSensor1.UseVisualStyleBackColor = true;
            // 
            // lblHum2
            // 
            this.lblHum2.AutoSize = true;
            this.lblHum2.Location = new System.Drawing.Point(148, 59);
            this.lblHum2.Name = "lblHum2";
            this.lblHum2.Size = new System.Drawing.Size(22, 13);
            this.lblHum2.TabIndex = 12;
            this.lblHum2.Text = "0.0";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Location = new System.Drawing.Point(93, 59);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(22, 13);
            this.lblTemp2.TabIndex = 11;
            this.lblTemp2.Text = "0.0";
            // 
            // lblHum1
            // 
            this.lblHum1.AutoSize = true;
            this.lblHum1.Location = new System.Drawing.Point(148, 39);
            this.lblHum1.Name = "lblHum1";
            this.lblHum1.Size = new System.Drawing.Size(22, 13);
            this.lblHum1.TabIndex = 10;
            this.lblHum1.Text = "0.0";
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Location = new System.Drawing.Point(93, 39);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(22, 13);
            this.lblTemp1.TabIndex = 9;
            this.lblTemp1.Text = "0.0";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 25);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(257, 20);
            this.txtStatus.TabIndex = 8;
            // 
            // timSendToArduino
            // 
            this.timSendToArduino.Enabled = true;
            this.timSendToArduino.Interval = 1000;
            this.timSendToArduino.Tick += new System.EventHandler(this.timSendToArduino_Tick);
            // 
            // chkContMeasure
            // 
            this.chkContMeasure.AutoSize = true;
            this.chkContMeasure.Location = new System.Drawing.Point(311, 13);
            this.chkContMeasure.Name = "chkContMeasure";
            this.chkContMeasure.Size = new System.Drawing.Size(114, 17);
            this.chkContMeasure.TabIndex = 16;
            this.chkContMeasure.Text = "Kontinuerlig måling";
            this.chkContMeasure.UseVisualStyleBackColor = true;
            this.chkContMeasure.CheckedChanged += new System.EventHandler(this.chkContMeasure_CheckedChanged);
            // 
            // chkMongoDBgem
            // 
            this.chkMongoDBgem.AutoSize = true;
            this.chkMongoDBgem.Location = new System.Drawing.Point(311, 35);
            this.chkMongoDBgem.Name = "chkMongoDBgem";
            this.chkMongoDBgem.Size = new System.Drawing.Size(100, 17);
            this.chkMongoDBgem.TabIndex = 17;
            this.chkMongoDBgem.Text = "Mongo DB gem";
            this.chkMongoDBgem.UseVisualStyleBackColor = true;
            // 
            // lbltimerMin
            // 
            this.lbltimerMin.AutoSize = true;
            this.lbltimerMin.Location = new System.Drawing.Point(160, 41);
            this.lbltimerMin.Name = "lbltimerMin";
            this.lbltimerMin.Size = new System.Drawing.Size(19, 13);
            this.lbltimerMin.TabIndex = 18;
            this.lbltimerMin.Text = "00";
            // 
            // txtMeasureTime
            // 
            this.txtMeasureTime.Location = new System.Drawing.Point(36, 37);
            this.txtMeasureTime.Name = "txtMeasureTime";
            this.txtMeasureTime.Size = new System.Drawing.Size(34, 20);
            this.txtMeasureTime.TabIndex = 19;
            this.txtMeasureTime.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "min.";
            // 
            // butValueChange
            // 
            this.butValueChange.Location = new System.Drawing.Point(71, 37);
            this.butValueChange.Name = "butValueChange";
            this.butValueChange.Size = new System.Drawing.Size(53, 20);
            this.butValueChange.TabIndex = 21;
            this.butValueChange.Text = "change";
            this.butValueChange.UseVisualStyleBackColor = true;
            this.butValueChange.Click += new System.EventHandler(this.butValueChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Temp.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fugt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTimerSec);
            this.groupBox1.Controls.Add(this.lblTimState);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbltimerMin);
            this.groupBox1.Controls.Add(this.txtMeasureTime);
            this.groupBox1.Controls.Add(this.butValueChange);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 69);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = ":";
            // 
            // lblTimerSec
            // 
            this.lblTimerSec.AutoSize = true;
            this.lblTimerSec.Location = new System.Drawing.Point(183, 41);
            this.lblTimerSec.Name = "lblTimerSec";
            this.lblTimerSec.Size = new System.Drawing.Size(19, 13);
            this.lblTimerSec.TabIndex = 23;
            this.lblTimerSec.Text = "00";
            // 
            // lblTimState
            // 
            this.lblTimState.AutoSize = true;
            this.lblTimState.Location = new System.Drawing.Point(6, 16);
            this.lblTimState.Name = "lblTimState";
            this.lblTimState.Size = new System.Drawing.Size(45, 13);
            this.lblTimState.TabIndex = 22;
            this.lblTimState.Text = "stopped";
            // 
            // timStatus
            // 
            this.timStatus.Enabled = true;
            this.timStatus.Interval = 1000;
            this.timStatus.Tick += new System.EventHandler(this.timStatus_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSensor1);
            this.groupBox2.Controls.Add(this.chkSensor2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTemp1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTemp2);
            this.groupBox2.Controls.Add(this.lblHum1);
            this.groupBox2.Controls.Add(this.lblHum2);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 89);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "følere";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(453, 24);
            this.menuStrip2.TabIndex = 28;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOlieSec);
            this.groupBox3.Controls.Add(this.lblOlieMin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblBlaeserSec);
            this.groupBox3.Controls.Add(this.lblBlaeserMin);
            this.groupBox3.Controls.Add(this.lblOlieHour);
            this.groupBox3.Controls.Add(this.lblBlaeserHour);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 67);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Varme";
            // 
            // lblOlieHour
            // 
            this.lblOlieHour.AutoSize = true;
            this.lblOlieHour.Location = new System.Drawing.Point(89, 37);
            this.lblOlieHour.Name = "lblOlieHour";
            this.lblOlieHour.Size = new System.Drawing.Size(13, 13);
            this.lblOlieHour.TabIndex = 3;
            this.lblOlieHour.Text = "0";
            // 
            // lblBlaeserHour
            // 
            this.lblBlaeserHour.AutoSize = true;
            this.lblBlaeserHour.Location = new System.Drawing.Point(89, 20);
            this.lblBlaeserHour.Name = "lblBlaeserHour";
            this.lblBlaeserHour.Size = new System.Drawing.Size(13, 13);
            this.lblBlaeserHour.TabIndex = 2;
            this.lblBlaeserHour.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Olie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Blæser";
            // 
            // lblBlaeserMin
            // 
            this.lblBlaeserMin.AutoSize = true;
            this.lblBlaeserMin.Location = new System.Drawing.Point(111, 20);
            this.lblBlaeserMin.Name = "lblBlaeserMin";
            this.lblBlaeserMin.Size = new System.Drawing.Size(13, 13);
            this.lblBlaeserMin.TabIndex = 4;
            this.lblBlaeserMin.Text = "0";
            // 
            // lblBlaeserSec
            // 
            this.lblBlaeserSec.AutoSize = true;
            this.lblBlaeserSec.Location = new System.Drawing.Point(134, 20);
            this.lblBlaeserSec.Name = "lblBlaeserSec";
            this.lblBlaeserSec.Size = new System.Drawing.Size(13, 13);
            this.lblBlaeserSec.TabIndex = 5;
            this.lblBlaeserSec.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "h.    m.     s.";
            // 
            // lblOlieMin
            // 
            this.lblOlieMin.AutoSize = true;
            this.lblOlieMin.Location = new System.Drawing.Point(110, 37);
            this.lblOlieMin.Name = "lblOlieMin";
            this.lblOlieMin.Size = new System.Drawing.Size(13, 13);
            this.lblOlieMin.TabIndex = 7;
            this.lblOlieMin.Text = "0";
            // 
            // lblOlieSec
            // 
            this.lblOlieSec.AutoSize = true;
            this.lblOlieSec.Location = new System.Drawing.Point(134, 37);
            this.lblOlieSec.Name = "lblOlieSec";
            this.lblOlieSec.Size = new System.Drawing.Size(13, 13);
            this.lblOlieSec.TabIndex = 8;
            this.lblOlieSec.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 309);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMongoDBgem);
            this.Controls.Add(this.chkContMeasure);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkSensor2;
        private System.Windows.Forms.CheckBox chkSensor1;
        private System.Windows.Forms.Label lblHum2;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label lblHum1;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Timer timSendToArduino;
        private System.Windows.Forms.CheckBox chkContMeasure;
        private System.Windows.Forms.CheckBox chkMongoDBgem;
        private System.Windows.Forms.Label lbltimerMin;
        private System.Windows.Forms.TextBox txtMeasureTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butValueChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTimState;
        private System.Windows.Forms.Timer timStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTimerSec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOlieHour;
        private System.Windows.Forms.Label lblBlaeserHour;
        private System.Windows.Forms.Label lblBlaeserSec;
        private System.Windows.Forms.Label lblBlaeserMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOlieSec;
        private System.Windows.Forms.Label lblOlieMin;
    }
}

