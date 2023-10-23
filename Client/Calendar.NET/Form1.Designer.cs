namespace Calendar.NET
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
            this.calendar1 = new Calendar.NET.Calendar.NET.Calendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.AllowEditingEvents = false;
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.BackColor = System.Drawing.Color.Transparent;
            this.calendar1.CalendarDate = new System.DateTime(2023, 10, 20, 13, 16, 0, 0);
            this.calendar1.CalendarView = CalendarViews.Month;
            this.calendar1.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.calendar1.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar1.DimDisabledEvents = true;
            this.calendar1.HighlightCurrentDay = true;
            this.calendar1.Location = new System.Drawing.Point(12, 12);
            this.calendar1.Name = "calendar1";
            this.calendar1.ShowArrowControls = true;
            this.calendar1.ShowDashedBorderOnDisabledEvents = true;
            this.calendar1.ShowDateInHeader = true;
            this.calendar1.ShowDisabledEvents = false;
            this.calendar1.ShowEventTooltips = true;
            this.calendar1.ShowTodayButton = true;
            this.calendar1.Size = new System.Drawing.Size(714, 497);
            this.calendar1.TabIndex = 0;
            this.calendar1.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 530);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Calendar.NET.Calendar calendar1;
        private System.Windows.Forms.Button button2;
    }
}

