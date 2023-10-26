namespace Calendar.NET
{
    partial class ContactForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.privateContact = new System.Windows.Forms.CheckBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(61, 294);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-Mail:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(71, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 5;
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(157, 45);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(100, 20);
            this.postalCode.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(71, 137);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 7;
            // 
            // privateContact
            // 
            this.privateContact.AutoSize = true;
            this.privateContact.Location = new System.Drawing.Point(17, 254);
            this.privateContact.Name = "privateContact";
            this.privateContact.Size = new System.Drawing.Size(99, 17);
            this.privateContact.TabIndex = 11;
            this.privateContact.Text = "Private Contact";
            this.privateContact.UseVisualStyleBackColor = true;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(157, 97);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 20);
            this.street.TabIndex = 12;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(157, 71);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Postal code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Street:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "City:";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(71, 162);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(100, 20);
            this.telephone.TabIndex = 17;
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(71, 186);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(100, 20);
            this.company.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telephone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Company:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Note:";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(71, 217);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(157, 20);
            this.note.TabIndex = 22;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 348);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.company);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.privateContact);
            this.Controls.Add(this.email);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Name = "ContactForm";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Contact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox postalCode;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.CheckBox privateContact;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox note;
    }
}