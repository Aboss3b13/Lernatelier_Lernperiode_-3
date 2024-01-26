namespace reaction_time
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
            this.click = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.prev_times = new System.Windows.Forms.TextBox();
            this.prev_btn = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.BackColor = System.Drawing.SystemColors.Control;
            this.click.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click.Location = new System.Drawing.Point(12, 142);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(762, 240);
            this.click.TabIndex = 0;
            this.click.Text = "click when the background changes color";
            this.click.UseVisualStyleBackColor = false;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(23, 46);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(442, 76);
            this.time.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(519, 46);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(255, 76);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // prev_times
            // 
            this.prev_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_times.Location = new System.Drawing.Point(850, 46);
            this.prev_times.Multiline = true;
            this.prev_times.Name = "prev_times";
            this.prev_times.Size = new System.Drawing.Size(332, 395);
            this.prev_times.TabIndex = 3;
            // 
            // prev_btn
            // 
            this.prev_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_btn.Location = new System.Drawing.Point(370, 401);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(404, 59);
            this.prev_btn.TabIndex = 5;
            this.prev_btn.Text = "previous times";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(23, 401);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(313, 59);
            this.send.TabIndex = 7;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 472);
            this.Controls.Add(this.send);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.prev_times);
            this.Controls.Add(this.start);
            this.Controls.Add(this.time);
            this.Controls.Add(this.click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox prev_times;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button send;
    }
}

