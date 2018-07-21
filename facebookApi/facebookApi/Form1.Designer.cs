namespace facebookApi
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FilteredFrinds = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.relationship = new System.Windows.Forms.CheckBox();
            this.single = new System.Windows.Forms.CheckBox();
            this.csc = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FriendsbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFrineds = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(6, 42);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(60, 13);
            this.userName.TabIndex = 2;
            this.userName.Text = "User Name";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 109);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FilteredFrinds
            // 
            this.FilteredFrinds.FormattingEnabled = true;
            this.FilteredFrinds.Location = new System.Drawing.Point(560, 193);
            this.FilteredFrinds.Name = "FilteredFrinds";
            this.FilteredFrinds.Size = new System.Drawing.Size(95, 160);
            this.FilteredFrinds.TabIndex = 2;
            this.FilteredFrinds.SelectedIndexChanged += new System.EventHandler(this.FilteredFrinds_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select your filter ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.relationship);
            this.groupBox2.Controls.Add(this.single);
            this.groupBox2.Controls.Add(this.csc);
            this.groupBox2.Location = new System.Drawing.Point(554, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // relationship
            // 
            this.relationship.AutoSize = true;
            this.relationship.Location = new System.Drawing.Point(6, 67);
            this.relationship.Name = "relationship";
            this.relationship.Size = new System.Drawing.Size(90, 17);
            this.relationship.TabIndex = 2;
            this.relationship.Text = "in relationship";
            this.relationship.UseVisualStyleBackColor = true;
            // 
            // single
            // 
            this.single.AutoSize = true;
            this.single.Location = new System.Drawing.Point(6, 44);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(63, 17);
            this.single.TabIndex = 1;
            this.single.Text = "married ";
            this.single.UseVisualStyleBackColor = true;
            // 
            // csc
            // 
            this.csc.AutoSize = true;
            this.csc.Location = new System.Drawing.Point(6, 21);
            this.csc.Name = "csc";
            this.csc.Size = new System.Drawing.Size(58, 17);
            this.csc.TabIndex = 0;
            this.csc.Text = "singles";
            this.csc.UseVisualStyleBackColor = true;
            this.csc.CheckedChanged += new System.EventHandler(this.Single_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Location = new System.Drawing.Point(412, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 92);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 67);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(66, 17);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "Christian";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 44);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(58, 17);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "Muslim";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 21);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(58, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Jewish";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(418, 171);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "woman";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(418, 193);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(46, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "man";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "optionals";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxFriend.Location = new System.Drawing.Point(285, 21);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(105, 93);
            this.pictureBoxFriend.TabIndex = 15;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFrineds
            // 
            this.listBoxFrineds.FormattingEnabled = true;
            this.listBoxFrineds.Location = new System.Drawing.Point(184, 21);
            this.listBoxFrineds.Name = "listBoxFrineds";
            this.listBoxFrineds.Size = new System.Drawing.Size(95, 147);
            this.listBoxFrineds.TabIndex = 17;
            this.listBoxFrineds.SelectedIndexChanged += new System.EventHandler(this.listBoxFrineds_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Results";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFrineds);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilteredFrinds);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox FilteredFrinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox relationship;
        private System.Windows.Forms.CheckBox single;
        private System.Windows.Forms.CheckBox csc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.BindingSource FriendsbindingSource;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFrineds;
        private System.Windows.Forms.Label label2;
    }
}

