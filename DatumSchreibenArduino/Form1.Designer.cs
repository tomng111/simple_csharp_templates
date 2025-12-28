namespace DatumSchreibenArduino
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
            this.label1 = new System.Windows.Forms.Label();
            this.ausAllBut = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.einAllBut = new System.Windows.Forms.Button();
            this.sendBut = new System.Windows.Forms.Button();
            this.dataSendTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baudBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusLb = new System.Windows.Forms.Label();
            this.actTempTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tempGraph = new ZedGraph.ZedGraphControl();
            this.alarmTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEMPERATUR-STEUERUNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ausAllBut
            // 
            this.ausAllBut.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausAllBut.Location = new System.Drawing.Point(407, 358);
            this.ausAllBut.Name = "ausAllBut";
            this.ausAllBut.Size = new System.Drawing.Size(152, 56);
            this.ausAllBut.TabIndex = 2;
            this.ausAllBut.Text = "EXIT";
            this.ausAllBut.UseVisualStyleBackColor = true;
            this.ausAllBut.Click += new System.EventHandler(this.ausAllBut_Click);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // einAllBut
            // 
            this.einAllBut.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einAllBut.Location = new System.Drawing.Point(181, 358);
            this.einAllBut.Name = "einAllBut";
            this.einAllBut.Size = new System.Drawing.Size(152, 56);
            this.einAllBut.TabIndex = 7;
            this.einAllBut.Text = "CONNECT";
            this.einAllBut.UseVisualStyleBackColor = true;
            this.einAllBut.Click += new System.EventHandler(this.einAllBut_Click);
            // 
            // sendBut
            // 
            this.sendBut.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBut.Location = new System.Drawing.Point(23, 34);
            this.sendBut.Name = "sendBut";
            this.sendBut.Size = new System.Drawing.Size(89, 35);
            this.sendBut.TabIndex = 9;
            this.sendBut.Text = "SEND";
            this.sendBut.UseVisualStyleBackColor = true;
            this.sendBut.Click += new System.EventHandler(this.sendBut_Click);
            // 
            // dataSendTxt
            // 
            this.dataSendTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSendTxt.Location = new System.Drawing.Point(158, 13);
            this.dataSendTxt.Name = "dataSendTxt";
            this.dataSendTxt.Size = new System.Drawing.Size(103, 26);
            this.dataSendTxt.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.baudBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comPortBox);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kommunikation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAUDRATE";
            // 
            // baudBox
            // 
            this.baudBox.FormattingEnabled = true;
            this.baudBox.Location = new System.Drawing.Point(140, 47);
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(121, 26);
            this.baudBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "COM-PORTS";
            // 
            // comPortBox
            // 
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(140, 17);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(121, 26);
            this.comPortBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataSendTxt);
            this.groupBox2.Controls.Add(this.sendBut);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Befehl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "SOLLWERT-TEMP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.alarmTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.statusLb);
            this.groupBox3.Controls.Add(this.actTempTxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 106);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "STATUS";
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Location = new System.Drawing.Point(155, 85);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(58, 18);
            this.statusLb.TabIndex = 20;
            this.statusLb.Text = "N.CON";
            // 
            // actTempTxt
            // 
            this.actTempTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actTempTxt.Location = new System.Drawing.Point(158, 14);
            this.actTempTxt.Name = "actTempTxt";
            this.actTempTxt.Size = new System.Drawing.Size(103, 26);
            this.actTempTxt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "ISTWERT-TEMP";
            // 
            // tempGraph
            // 
            this.tempGraph.Location = new System.Drawing.Point(289, 35);
            this.tempGraph.Name = "tempGraph";
            this.tempGraph.ScrollGrace = 0D;
            this.tempGraph.ScrollMaxX = 0D;
            this.tempGraph.ScrollMaxY = 0D;
            this.tempGraph.ScrollMaxY2 = 0D;
            this.tempGraph.ScrollMinX = 0D;
            this.tempGraph.ScrollMinY = 0D;
            this.tempGraph.ScrollMinY2 = 0D;
            this.tempGraph.Size = new System.Drawing.Size(499, 314);
            this.tempGraph.TabIndex = 17;
            this.tempGraph.UseExtendedPrintDialog = true;
            // 
            // alarmTxt
            // 
            this.alarmTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTxt.Location = new System.Drawing.Point(158, 46);
            this.alarmTxt.Name = "alarmTxt";
            this.alarmTxt.Size = new System.Drawing.Size(103, 26);
            this.alarmTxt.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "ALARM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempGraph);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.einAllBut);
            this.Controls.Add(this.ausAllBut);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ausAllBut;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button einAllBut;
        private System.Windows.Forms.Button sendBut;
        private System.Windows.Forms.TextBox dataSendTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baudBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox actTempTxt;
        private ZedGraph.ZedGraphControl tempGraph;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alarmTxt;
        private System.Windows.Forms.Label label7;
    }
}

