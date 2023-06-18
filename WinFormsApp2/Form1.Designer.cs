namespace WinFormsApp2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtname = new TextBox();
            txtemail = new TextBox();
            txtcontact = new TextBox();
            btnsave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 168);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 206);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 248);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact";
            label3.Click += label3_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(311, 161);
            txtname.Name = "txtname";
            txtname.Size = new Size(208, 27);
            txtname.TabIndex = 3;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(311, 203);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(208, 27);
            txtemail.TabIndex = 4;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(311, 248);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(208, 27);
            txtcontact.TabIndex = 5;
            txtcontact.TextChanged += txtcontact_TextChanged;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.ActiveBorder;
            btnsave.Location = new Point(360, 315);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 7;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsave);
            Controls.Add(txtcontact);
            Controls.Add(txtemail);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtname;
        private TextBox txtemail;
        private TextBox txtcontact;
        private Button btnsave;
    }
}