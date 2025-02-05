namespace openCV
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxLive = new GroupBox();
            live = new PictureBox();
            controlGroup = new GroupBox();
            Start = new Button();
            Connect = new Button();
            groupBox1 = new GroupBox();
            recStatus = new Label();
            camStatus = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            time = new Label();
            dateset = new Label();
            label4 = new Label();
            label3 = new Label();
            TimeSet = new System.Windows.Forms.Timer(components);
            date = new System.Windows.Forms.Timer(components);
            pictureBoxGray = new PictureBox();
            groupBox3 = new GroupBox();
            grouplog = new GroupBox();
            logbox = new TextBox();
            boxRecognizer = new GroupBox();
            label6 = new Label();
            sectime = new NumericUpDown();
            label5 = new Label();
            Browse = new Button();
            foldertext = new TextBox();
            Snipshot = new CheckBox();
            Recognizer = new CheckBox();
            NumricTime = new System.Windows.Forms.Timer(components);
            snapshotTimer = new System.Windows.Forms.Timer(components);
            groupBoxLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)live).BeginInit();
            controlGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).BeginInit();
            groupBox3.SuspendLayout();
            grouplog.SuspendLayout();
            boxRecognizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sectime).BeginInit();
            SuspendLayout();
            // 
            // groupBoxLive
            // 
            groupBoxLive.Anchor = AnchorStyles.None;
            groupBoxLive.Controls.Add(live);
            groupBoxLive.Location = new Point(12, 28);
            groupBoxLive.Margin = new Padding(3, 2, 3, 2);
            groupBoxLive.Name = "groupBoxLive";
            groupBoxLive.Padding = new Padding(3, 2, 3, 2);
            groupBoxLive.Size = new Size(514, 328);
            groupBoxLive.TabIndex = 0;
            groupBoxLive.TabStop = false;
            groupBoxLive.Text = "Live view";
            // 
            // live
            // 
            live.Location = new Point(6, 20);
            live.Name = "live";
            live.Size = new Size(502, 302);
            live.SizeMode = PictureBoxSizeMode.StretchImage;
            live.TabIndex = 9;
            live.TabStop = false;
            // 
            // controlGroup
            // 
            controlGroup.Anchor = AnchorStyles.None;
            controlGroup.Controls.Add(Start);
            controlGroup.Controls.Add(Connect);
            controlGroup.Location = new Point(18, 360);
            controlGroup.Margin = new Padding(3, 2, 3, 2);
            controlGroup.Name = "controlGroup";
            controlGroup.Padding = new Padding(3, 2, 3, 2);
            controlGroup.Size = new Size(298, 88);
            controlGroup.TabIndex = 1;
            controlGroup.TabStop = false;
            controlGroup.Text = "Control Panel";
            // 
            // Start
            // 
            Start.Enabled = false;
            Start.Location = new Point(154, 27);
            Start.Margin = new Padding(3, 2, 3, 2);
            Start.Name = "Start";
            Start.Size = new Size(122, 49);
            Start.TabIndex = 2;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Connect
            // 
            Connect.Location = new Point(20, 27);
            Connect.Margin = new Padding(3, 2, 3, 2);
            Connect.Name = "Connect";
            Connect.Size = new Size(112, 49);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(recStatus);
            groupBox1.Controls.Add(camStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(525, 464);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(291, 32);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // recStatus
            // 
            recStatus.AutoSize = true;
            recStatus.Location = new Point(213, 13);
            recStatus.Name = "recStatus";
            recStatus.Size = new Size(0, 15);
            recStatus.TabIndex = 5;
            // 
            // camStatus
            // 
            camStatus.AutoSize = true;
            camStatus.Location = new Point(70, 13);
            camStatus.Name = "camStatus";
            camStatus.Size = new Size(0, 15);
            camStatus.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Location = new Point(160, 13);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Recond :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Camara :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(time);
            groupBox2.Controls.Add(dateset);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(822, 464);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 32);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(57, 13);
            time.Name = "time";
            time.Size = new Size(0, 15);
            time.TabIndex = 4;
            // 
            // dateset
            // 
            dateset.AutoSize = true;
            dateset.Location = new Point(151, 13);
            dateset.Name = "dateset";
            dateset.Size = new Size(0, 15);
            dateset.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 13);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 1;
            label4.Text = "Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 13);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Time : ";
            // 
            // TimeSet
            // 
            TimeSet.Enabled = true;
            TimeSet.Interval = 500;
            TimeSet.Tick += timer1_Tick;
            // 
            // date
            // 
            date.Enabled = true;
            date.Interval = 500;
            // 
            // pictureBoxGray
            // 
            pictureBoxGray.Location = new Point(6, 20);
            pictureBoxGray.Name = "pictureBoxGray";
            pictureBoxGray.Size = new Size(161, 151);
            pictureBoxGray.TabIndex = 5;
            pictureBoxGray.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(pictureBoxGray);
            groupBox3.Location = new Point(532, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(175, 178);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detection";
            // 
            // grouplog
            // 
            grouplog.Anchor = AnchorStyles.None;
            grouplog.Controls.Add(logbox);
            grouplog.Location = new Point(532, 215);
            grouplog.Name = "grouplog";
            grouplog.Size = new Size(527, 141);
            grouplog.TabIndex = 7;
            grouplog.TabStop = false;
            grouplog.Text = "Log";
            // 
            // logbox
            // 
            logbox.Location = new Point(6, 17);
            logbox.Multiline = true;
            logbox.Name = "logbox";
            logbox.ScrollBars = ScrollBars.Both;
            logbox.Size = new Size(510, 118);
            logbox.TabIndex = 0;
            // 
            // boxRecognizer
            // 
            boxRecognizer.Anchor = AnchorStyles.None;
            boxRecognizer.Controls.Add(label6);
            boxRecognizer.Controls.Add(sectime);
            boxRecognizer.Controls.Add(label5);
            boxRecognizer.Controls.Add(Browse);
            boxRecognizer.Controls.Add(foldertext);
            boxRecognizer.Controls.Add(Snipshot);
            boxRecognizer.Controls.Add(Recognizer);
            boxRecognizer.Location = new Point(713, 28);
            boxRecognizer.Name = "boxRecognizer";
            boxRecognizer.Size = new Size(346, 178);
            boxRecognizer.TabIndex = 8;
            boxRecognizer.TabStop = false;
            boxRecognizer.Text = "Recognizer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 59);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "Sec / Img";
            // 
            // sectime
            // 
            sectime.Location = new Point(142, 57);
            sectime.Name = "sectime";
            sectime.Size = new Size(43, 23);
            sectime.TabIndex = 6;
            sectime.TextAlign = HorizontalAlignment.Center;
            sectime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 89);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 5;
            label5.Text = "ImageFolder :";
            // 
            // Browse
            // 
            Browse.Location = new Point(260, 145);
            Browse.Name = "Browse";
            Browse.Size = new Size(75, 23);
            Browse.TabIndex = 4;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // foldertext
            // 
            foldertext.Location = new Point(17, 116);
            foldertext.Name = "foldertext";
            foldertext.ReadOnly = true;
            foldertext.Size = new Size(323, 23);
            foldertext.TabIndex = 3;
            // 
            // Snipshot
            // 
            Snipshot.AutoSize = true;
            Snipshot.Location = new Point(17, 58);
            Snipshot.Name = "Snipshot";
            Snipshot.Size = new Size(119, 19);
            Snipshot.TabIndex = 2;
            Snipshot.Text = "On / Off Snipshot";
            Snipshot.UseVisualStyleBackColor = true;
            Snipshot.CheckedChanged += Snipshot_CheckedChanged;
            // 
            // Recognizer
            // 
            Recognizer.AutoSize = true;
            Recognizer.Location = new Point(17, 22);
            Recognizer.Name = "Recognizer";
            Recognizer.Size = new Size(131, 19);
            Recognizer.TabIndex = 1;
            Recognizer.Text = "On / Off Recognizer";
            Recognizer.UseVisualStyleBackColor = true;
            Recognizer.CheckedChanged += Recognizer_CheckedChanged;
            // 
            // NumricTime
            // 
            NumricTime.Interval = 1000;
            // 
            // snapshotTimer
            // 
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 498);
            Controls.Add(boxRecognizer);
            Controls.Add(grouplog);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(controlGroup);
            Controls.Add(groupBoxLive);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)live).EndInit();
            controlGroup.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).EndInit();
            groupBox3.ResumeLayout(false);
            grouplog.ResumeLayout(false);
            grouplog.PerformLayout();
            boxRecognizer.ResumeLayout(false);
            boxRecognizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sectime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxLive;
        private GroupBox controlGroup;
        private Button Connect;
        private Button Start;
        private Label label1;
        private GroupBox groupBox1;
        private Label recStatus;
        private Label camStatus;
        private Label label2;
        private GroupBox groupBox2;
        private Label dateset;
        private Label label4;
        private Label label3;
        private System.Windows.Forms.Timer TimeSet;
        private Label time;
        private System.Windows.Forms.Timer date;
        private PictureBox pictureBoxGray;
        private GroupBox groupBox3;
        private GroupBox grouplog;
        private GroupBox boxRecognizer;
        private CheckBox Snipshot;
        private CheckBox Recognizer;
        private Button Browse;
        private TextBox foldertext;
        private Label label5;
        private TextBox logbox;
        private Label label6;
        private NumericUpDown sectime;
        private System.Windows.Forms.Timer NumricTime;
        private PictureBox live;
        private System.Windows.Forms.Timer snapshotTimer;
    }
}
