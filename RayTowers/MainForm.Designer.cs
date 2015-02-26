namespace RayTowers
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pole1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Disk1 = new System.Windows.Forms.Label();
            this.lbl_Disk2 = new System.Windows.Forms.Label();
            this.lbl_Disk3 = new System.Windows.Forms.Label();
            this.lbl_Disk4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Moves = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(131, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 48);
            this.panel1.TabIndex = 1;
            // 
            // Pole1
            // 
            this.Pole1.AllowDrop = true;
            this.Pole1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pole1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pole1.Location = new System.Drawing.Point(215, 112);
            this.Pole1.Name = "Pole1";
            this.Pole1.Size = new System.Drawing.Size(10, 144);
            this.Pole1.TabIndex = 12;
            this.Pole1.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.Pole1.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(435, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 144);
            this.panel2.TabIndex = 28;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(655, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 144);
            this.panel3.TabIndex = 29;
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.peg_DragDrop);
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.peg_DragEnter);
            // 
            // lbl_Disk1
            // 
            this.lbl_Disk1.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk1.Location = new System.Drawing.Point(202, 144);
            this.lbl_Disk1.Name = "lbl_Disk1";
            this.lbl_Disk1.Size = new System.Drawing.Size(35, 24);
            this.lbl_Disk1.TabIndex = 30;
            this.lbl_Disk1.Text = "1";
            this.lbl_Disk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk2
            // 
            this.lbl_Disk2.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk2.Location = new System.Drawing.Point(192, 168);
            this.lbl_Disk2.Name = "lbl_Disk2";
            this.lbl_Disk2.Size = new System.Drawing.Size(57, 24);
            this.lbl_Disk2.TabIndex = 31;
            this.lbl_Disk2.Text = "2";
            this.lbl_Disk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk3
            // 
            this.lbl_Disk3.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk3.Location = new System.Drawing.Point(180, 192);
            this.lbl_Disk3.Name = "lbl_Disk3";
            this.lbl_Disk3.Size = new System.Drawing.Size(79, 24);
            this.lbl_Disk3.TabIndex = 32;
            this.lbl_Disk3.Text = "3";
            this.lbl_Disk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // lbl_Disk4
            // 
            this.lbl_Disk4.BackColor = System.Drawing.Color.Lime;
            this.lbl_Disk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Disk4.Location = new System.Drawing.Point(170, 216);
            this.lbl_Disk4.Name = "lbl_Disk4";
            this.lbl_Disk4.Size = new System.Drawing.Size(100, 24);
            this.lbl_Disk4.TabIndex = 33;
            this.lbl_Disk4.Text = "4";
            this.lbl_Disk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.anyDisk_MouseDown);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 32);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(17, 62);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(104, 32);
            this.btnStep.TabIndex = 36;
            this.btnStep.Text = "Step";
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnAnimate
            // 
            this.btnAnimate.Location = new System.Drawing.Point(17, 112);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(104, 32);
            this.btnAnimate.TabIndex = 37;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(266, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "Moves:";
            // 
            // txt_Moves
            // 
            this.txt_Moves.Location = new System.Drawing.Point(802, 16);
            this.txt_Moves.Multiline = true;
            this.txt_Moves.Name = "txt_Moves";
            this.txt_Moves.Size = new System.Drawing.Size(136, 280);
            this.txt_Moves.TabIndex = 39;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(336, 12);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(100, 20);
            this.txt_Count.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(542, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(691, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 42;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_Moves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbl_Disk4);
            this.Controls.Add(this.lbl_Disk3);
            this.Controls.Add(this.lbl_Disk2);
            this.Controls.Add(this.lbl_Disk1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pole1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Towers of Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pole1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Disk1;
        private System.Windows.Forms.Label lbl_Disk2;
        private System.Windows.Forms.Label lbl_Disk3;
        private System.Windows.Forms.Label lbl_Disk4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Moves;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

