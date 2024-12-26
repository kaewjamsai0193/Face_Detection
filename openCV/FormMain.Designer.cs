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
            imageBoxLive = new Emgu.CV.UI.ImageBox();
            controlGroup = new GroupBox();
            FlipVer = new Button();
            FlipHor = new Button();
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
            groupBoxLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).BeginInit();
            controlGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLive
            // 
            groupBoxLive.Anchor = AnchorStyles.None;
            groupBoxLive.Controls.Add(imageBoxLive);
            groupBoxLive.Location = new Point(32, 28);
            groupBoxLive.Margin = new Padding(3, 2, 3, 2);
            groupBoxLive.Name = "groupBoxLive";
            groupBoxLive.Padding = new Padding(3, 2, 3, 2);
            groupBoxLive.Size = new Size(443, 256);
            groupBoxLive.TabIndex = 0;
            groupBoxLive.TabStop = false;
            groupBoxLive.Text = "Live view";
            // 
            // imageBoxLive
            // 
            imageBoxLive.Anchor = AnchorStyles.None;
            imageBoxLive.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            imageBoxLive.Location = new Point(6, 16);
            imageBoxLive.Margin = new Padding(3, 2, 3, 2);
            imageBoxLive.Name = "imageBoxLive";
            imageBoxLive.Size = new Size(437, 236);
            imageBoxLive.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBoxLive.TabIndex = 2;
            imageBoxLive.TabStop = false;
            // 
            // controlGroup
            // 
            controlGroup.Anchor = AnchorStyles.None;
            controlGroup.Controls.Add(FlipVer);
            controlGroup.Controls.Add(FlipHor);
            controlGroup.Controls.Add(Start);
            controlGroup.Controls.Add(Connect);
            controlGroup.Location = new Point(32, 309);
            controlGroup.Margin = new Padding(3, 2, 3, 2);
            controlGroup.Name = "controlGroup";
            controlGroup.Padding = new Padding(3, 2, 3, 2);
            controlGroup.Size = new Size(443, 88);
            controlGroup.TabIndex = 1;
            controlGroup.TabStop = false;
            controlGroup.Text = "Control Panel";
            // 
            // FlipVer
            // 
            FlipVer.Location = new Point(320, 55);
            FlipVer.Margin = new Padding(3, 2, 3, 2);
            FlipVer.Name = "FlipVer";
            FlipVer.Size = new Size(108, 28);
            FlipVer.TabIndex = 5;
            FlipVer.Text = "FlipVertical";
            FlipVer.UseVisualStyleBackColor = true;
            FlipVer.Click += FlipVer_Click;
            // 
            // FlipHor
            // 
            FlipHor.Location = new Point(320, 20);
            FlipHor.Margin = new Padding(3, 2, 3, 2);
            FlipHor.Name = "FlipHor";
            FlipHor.Size = new Size(108, 31);
            FlipHor.TabIndex = 4;
            FlipHor.Text = "FlipHorizon";
            FlipHor.UseVisualStyleBackColor = true;
            FlipHor.Click += FlipHor_Click;
            // 
            // Start
            // 
            Start.Enabled = false;
            Start.Location = new Point(159, 27);
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
            Connect.Location = new Point(41, 27);
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
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(recStatus);
            groupBox1.Controls.Add(camStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 421);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(450, 39);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // recStatus
            // 
            recStatus.AutoSize = true;
            recStatus.Location = new Point(351, 18);
            recStatus.Name = "recStatus";
            recStatus.Size = new Size(0, 15);
            recStatus.TabIndex = 5;
            // 
            // camStatus
            // 
            camStatus.AutoSize = true;
            camStatus.Location = new Point(176, 18);
            camStatus.Name = "camStatus";
            camStatus.Size = new Size(0, 15);
            camStatus.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 18);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Recond :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Camara :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(time);
            groupBox2.Controls.Add(dateset);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(106, 465);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 32);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(155, 13);
            time.Name = "time";
            time.Size = new Size(0, 15);
            time.TabIndex = 4;
            // 
            // dateset
            // 
            dateset.AutoSize = true;
            dateset.Location = new Point(335, 14);
            dateset.Name = "dateset";
            dateset.Size = new Size(0, 15);
            dateset.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 14);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 1;
            label4.Text = "Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 14);
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
            pictureBoxGray.Location = new Point(6, 22);
            pictureBoxGray.Name = "pictureBoxGray";
            pictureBoxGray.Size = new Size(194, 145);
            pictureBoxGray.TabIndex = 5;
            pictureBoxGray.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBoxGray);
            groupBox3.Location = new Point(488, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 173);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 498);
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
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).EndInit();
            controlGroup.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxLive;
        private Emgu.CV.UI.ImageBox imageBoxLive;
        private GroupBox controlGroup;
        private Button Connect;
        private Button FlipVer;
        private Button FlipHor;
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
    }
}
