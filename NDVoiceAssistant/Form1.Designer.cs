namespace SpeechRecognizer
{
    partial class SpeechRecognizer
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
            this.txtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEngine = new System.Windows.Forms.TabPage();
            this.btnEnable = new System.Windows.Forms.Button();
            this.tabPageCommand = new System.Windows.Forms.TabPage();
            this.textBoxCmd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCmdName = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAddCmd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageEngine.SuspendLayout();
            this.tabPageCommand.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBoxOutput.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutput.ForeColor = System.Drawing.Color.Lime;
            this.txtBoxOutput.Location = new System.Drawing.Point(-3, 0);
            this.txtBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(510, 193);
            this.txtBoxOutput.TabIndex = 0;
            this.txtBoxOutput.Text = "-Log";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageEngine);
            this.tabControl1.Controls.Add(this.tabPageCommand);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 62);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 294);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageEngine
            // 
            this.tabPageEngine.BackColor = System.Drawing.Color.Maroon;
            this.tabPageEngine.Controls.Add(this.txtBoxOutput);
            this.tabPageEngine.Controls.Add(this.btnEnable);
            this.tabPageEngine.ForeColor = System.Drawing.Color.Maroon;
            this.tabPageEngine.Location = new System.Drawing.Point(4, 27);
            this.tabPageEngine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageEngine.Name = "tabPageEngine";
            this.tabPageEngine.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageEngine.Size = new System.Drawing.Size(504, 263);
            this.tabPageEngine.TabIndex = 0;
            this.tabPageEngine.Text = "Speech Recognizer";
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.Maroon;
            this.btnEnable.BackgroundImage = global::SpeechRecognizer.Properties.Resources.microphone_black_shape__2_;
            this.btnEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnable.FlatAppearance.BorderSize = 0;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Location = new System.Drawing.Point(203, 203);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(105, 62);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // tabPageCommand
            // 
            this.tabPageCommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCommand.Controls.Add(this.textBoxCmd);
            this.tabPageCommand.Controls.Add(this.label2);
            this.tabPageCommand.Controls.Add(this.label1);
            this.tabPageCommand.Controls.Add(this.textBoxCmdName);
            this.tabPageCommand.Controls.Add(this.guna2GradientPanel1);
            this.tabPageCommand.Location = new System.Drawing.Point(4, 27);
            this.tabPageCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageCommand.Size = new System.Drawing.Size(504, 263);
            this.tabPageCommand.TabIndex = 1;
            this.tabPageCommand.Text = "Commands";
            this.tabPageCommand.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd
            // 
            this.textBoxCmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmd.Location = new System.Drawing.Point(83, 140);
            this.textBoxCmd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCmd.Multiline = true;
            this.textBoxCmd.Name = "textBoxCmd";
            this.textBoxCmd.Size = new System.Drawing.Size(207, 32);
            this.textBoxCmd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command Name";
            // 
            // textBoxCmdName
            // 
            this.textBoxCmdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxCmdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCmdName.Location = new System.Drawing.Point(83, 57);
            this.textBoxCmdName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCmdName.Multiline = true;
            this.textBoxCmdName.Name = "textBoxCmdName";
            this.textBoxCmdName.Size = new System.Drawing.Size(207, 32);
            this.textBoxCmdName.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnAddCmd);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.SandyBrown;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(508, 271);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // btnAddCmd
            // 
            this.btnAddCmd.BackColor = System.Drawing.Color.Maroon;
            this.btnAddCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCmd.ForeColor = System.Drawing.Color.Black;
            this.btnAddCmd.Location = new System.Drawing.Point(145, 202);
            this.btnAddCmd.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAddCmd.Name = "btnAddCmd";
            this.btnAddCmd.Size = new System.Drawing.Size(211, 33);
            this.btnAddCmd.TabIndex = 1;
            this.btnAddCmd.Text = "Add more commands";
            this.btnAddCmd.UseVisualStyleBackColor = false;
            this.btnAddCmd.Click += new System.EventHandler(this.btnAddCmd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "ND Personal Assistant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEngine.ResumeLayout(false);
            this.tabPageCommand.ResumeLayout(false);
            this.tabPageCommand.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxOutput;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEngine;
        private System.Windows.Forms.TabPage tabPageCommand;
        private System.Windows.Forms.TextBox textBoxCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCmd;
        private System.Windows.Forms.TextBox textBoxCmdName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}

