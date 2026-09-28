namespace juego_aviones_quispe_luque
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
            statusStrip1 = new StatusStrip();
            statusStrip2 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(24, 24);
            statusStrip2.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip2.Location = new Point(0, 396);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(800, 32);
            statusStrip2.TabIndex = 1;
            statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(179, 25);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(179, 25);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip2);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Form1";
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}
