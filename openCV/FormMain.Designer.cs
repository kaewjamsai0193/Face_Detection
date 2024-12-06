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
            groupBoxLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).BeginInit();
            controlGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLive
            // 
            groupBoxLive.Anchor = AnchorStyles.None;
            groupBoxLive.Controls.Add(imageBoxLive);
            groupBoxLive.Location = new Point(97, 9);
            groupBoxLive.Margin = new Padding(3, 2, 3, 2);
            groupBoxLive.Name = "groupBoxLive";
            groupBoxLive.Padding = new Padding(3, 2, 3, 2);
            groupBoxLive.Size = new Size(499, 285);
            groupBoxLive.TabIndex = 0;
            groupBoxLive.TabStop = false;
            groupBoxLive.Text = "Live view";
            // 
            // imageBoxLive
            // 
            imageBoxLive.Anchor = AnchorStyles.None;
            imageBoxLive.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            imageBoxLive.Location = new Point(5, 20);
            imageBoxLive.Margin = new Padding(3, 2, 3, 2);
            imageBoxLive.Name = "imageBoxLive";
            imageBoxLive.Size = new Size(488, 261);
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
            controlGroup.Location = new Point(106, 298);
            controlGroup.Margin = new Padding(3, 2, 3, 2);
            controlGroup.Name = "controlGroup";
            controlGroup.Padding = new Padding(3, 2, 3, 2);
            controlGroup.Size = new Size(496, 88);
            controlGroup.TabIndex = 1;
            controlGroup.TabStop = false;
            controlGroup.Text = "Control Panel";
            // 
            // FlipVer
            // 
            FlipVer.Location = new Point(351, 56);
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
            FlipHor.Location = new Point(351, 20);
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
            groupBox1.Location = new Point(106, 385);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(496, 39);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 427);
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
    }
}
