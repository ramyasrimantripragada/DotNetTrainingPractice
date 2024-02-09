namespace WordVoyagerWindowsApp
{
    partial class MainMenu
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
            this.displayEmployeeDeatils = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayEmployeeDeatils
            // 
            this.displayEmployeeDeatils.BackColor = System.Drawing.Color.Silver;
            this.displayEmployeeDeatils.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmployeeDeatils.Location = new System.Drawing.Point(562, 134);
            this.displayEmployeeDeatils.Name = "displayEmployeeDeatils";
            this.displayEmployeeDeatils.Size = new System.Drawing.Size(369, 56);
            this.displayEmployeeDeatils.TabIndex = 2;
            this.displayEmployeeDeatils.Text = "Display Employee Records";
            this.displayEmployeeDeatils.UseVisualStyleBackColor = false;
            this.displayEmployeeDeatils.Click += new System.EventHandler(this.displayEmployeeDeatils_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(562, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Insert New Employee Record";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.displayInsertEmployee);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee Records Management";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.displayEmployeeDeatils);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button displayEmployeeDeatils;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

