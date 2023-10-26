namespace Calendar.NET.Forms
{
    partial class AppointmentForm
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
            this.Topic = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.End = new System.Windows.Forms.DateTimePicker();
            this.ContactId = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Repetition = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ContactId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repetition)).BeginInit();
            this.SuspendLayout();
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(125, 42);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(100, 20);
            this.Topic.TabIndex = 0;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(125, 175);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 20);
            this.City.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Topic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Note";
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(125, 210);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(100, 20);
            this.Note.TabIndex = 9;
            this.Note.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(108, 256);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact";
            // 
            // Start
            // 
            this.Start.CustomFormat = "d/M/yyyy h:mm tt";
            this.Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start.Location = new System.Drawing.Point(125, 88);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 20);
            this.Start.TabIndex = 12;
            // 
            // End
            // 
            this.End.CustomFormat = "d/M/yyyy h:mm tt";
            this.End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End.Location = new System.Drawing.Point(125, 135);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(200, 20);
            this.End.TabIndex = 13;
            // 
            // ContactId
            // 
            this.ContactId.Location = new System.Drawing.Point(318, 41);
            this.ContactId.Name = "ContactId";
            this.ContactId.Size = new System.Drawing.Size(33, 20);
            this.ContactId.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Repetition";
            // 
            // Repetition
            // 
            this.Repetition.Location = new System.Drawing.Point(425, 88);
            this.Repetition.Name = "Repetition";
            this.Repetition.Size = new System.Drawing.Size(33, 20);
            this.Repetition.TabIndex = 16;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 353);
            this.Controls.Add(this.Repetition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ContactId);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Topic);
            this.Name = "AppointmentForm";
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.ContactId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repetition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.DateTimePicker End;
        private System.Windows.Forms.NumericUpDown ContactId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Repetition;
    }
}