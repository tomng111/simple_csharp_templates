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
            this.ein1But = new System.Windows.Forms.Button();
            this.ein2But = new System.Windows.Forms.Button();
            this.aus1But = new System.Windows.Forms.Button();
            this.aus2But = new System.Windows.Forms.Button();
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
            this.disTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LED-STEUERUNG";
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
            // ein1But
            // 
            this.ein1But.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ein1But.Location = new System.Drawing.Point(93, 89);
            this.ein1But.Name = "ein1But";
            this.ein1But.Size = new System.Drawing.Size(89, 35);
            this.ein1But.TabIndex = 3;
            this.ein1But.Text = "1-EIN";
            this.ein1But.UseVisualStyleBackColor = true;
            this.ein1But.Click += new System.EventHandler(this.ein1But_Click);
            // 
            // ein2But
            // 
            this.ein2But.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ein2But.Location = new System.Drawing.Point(93, 165);
            this.ein2But.Name = "ein2But";
            this.ein2But.Size = new System.Drawing.Size(89, 35);
            this.ein2But.TabIndex = 4;
            this.ein2But.Text = "2-EIN";
            this.ein2But.UseVisualStyleBackColor = true;
            this.ein2But.Click += new System.EventHandler(this.ein2But_Click);
            // 
            // aus1But
            // 
            this.aus1But.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aus1But.Location = new System.Drawing.Point(244, 89);
            this.aus1But.Name = "aus1But";
            this.aus1But.Size = new System.Drawing.Size(89, 35);
            this.aus1But.TabIndex = 5;
            this.aus1But.Text = "1-AUS";
            this.aus1But.UseVisualStyleBackColor = true;
            this.aus1But.Click += new System.EventHandler(this.aus1But_Click);
            // 
            // aus2But
            // 
            this.aus2But.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aus2But.Location = new System.Drawing.Point(244, 165);
            this.aus2But.Name = "aus2But";
            this.aus2But.Size = new System.Drawing.Size(89, 35);
            this.aus2But.TabIndex = 6;
            this.aus2But.Text = "2-AUS";
            this.aus2But.UseVisualStyleBackColor = true;
            this.aus2But.Click += new System.EventHandler(this.aus2But_Click);
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
            this.sendBut.Location = new System.Drawing.Point(93, 251);
            this.sendBut.Name = "sendBut";
            this.sendBut.Size = new System.Drawing.Size(89, 35);
            this.sendBut.TabIndex = 9;
            this.sendBut.Text = "SEND";
            this.sendBut.UseVisualStyleBackColor = true;
            this.sendBut.Click += new System.EventHandler(this.sendBut_Click);
            // 
            // dataSendTxt
            // 
            this.dataSendTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSendTxt.Location = new System.Drawing.Point(244, 255);
            this.dataSendTxt.Name = "dataSendTxt";
            this.dataSendTxt.Size = new System.Drawing.Size(89, 31);
            this.dataSendTxt.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.disTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.baudBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comPortBox);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(407, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 197);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kommunikation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAUDRATE";
            // 
            // baudBox
            // 
            this.baudBox.FormattingEnabled = true;
            this.baudBox.Location = new System.Drawing.Point(140, 81);
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(121, 26);
            this.baudBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "COM-PORTS";
            // 
            // comPortBox
            // 
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(140, 34);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(121, 26);
            this.comPortBox.TabIndex = 0;
            // 
            // disTxt
            // 
            this.disTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disTxt.Location = new System.Drawing.Point(140, 127);
            this.disTxt.Name = "disTxt";
            this.disTxt.Size = new System.Drawing.Size(121, 26);
            this.disTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "DISTANZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataSendTxt);
            this.Controls.Add(this.sendBut);
            this.Controls.Add(this.einAllBut);
            this.Controls.Add(this.aus2But);
            this.Controls.Add(this.aus1But);
            this.Controls.Add(this.ein2But);
            this.Controls.Add(this.ein1But);
            this.Controls.Add(this.ausAllBut);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ausAllBut;
        private System.Windows.Forms.Button ein1But;
        private System.Windows.Forms.Button ein2But;
        private System.Windows.Forms.Button aus1But;
        private System.Windows.Forms.Button aus2But;
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
        private System.Windows.Forms.TextBox disTxt;
        private System.Windows.Forms.Label label4;
    }
}

