namespace utilities
{
    partial class frm_Alert
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
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(20, 30);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(60, 60);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // pic_close
            // 
            this.pic_close.Image = global::utilities.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(450, 20);
            this.pic_close.Margin = new System.Windows.Forms.Padding(0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(30, 30);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 1;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title.Location = new System.Drawing.Point(100, 29);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(330, 40);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_message.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_message.Location = new System.Drawing.Point(100, 69);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(330, 24);
            this.lbl_message.TabIndex = 3;
            this.lbl_message.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 120);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.pic_close);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Alert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frm_Alert";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pic_logo;
        private PictureBox pic_close;
        private Label lbl_title;
        private Label lbl_message;
        private System.Windows.Forms.Timer timer1;
    }
}