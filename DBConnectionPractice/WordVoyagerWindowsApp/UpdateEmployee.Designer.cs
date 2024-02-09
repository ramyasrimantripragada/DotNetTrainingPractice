namespace WordVoyagerWindowsApp
{
    partial class UpdateEmployee
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
            this.updateEmp = new System.Windows.Forms.Button();
            this.designation = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.updatename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateEmp
            // 
            this.updateEmp.BackColor = System.Drawing.Color.Silver;
            this.updateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmp.Location = new System.Drawing.Point(344, 346);
            this.updateEmp.Name = "updateEmp";
            this.updateEmp.Size = new System.Drawing.Size(244, 53);
            this.updateEmp.TabIndex = 23;
            this.updateEmp.Text = "Submit";
            this.updateEmp.UseVisualStyleBackColor = false;
            this.updateEmp.Click += new System.EventHandler(this.onClickUpdateEmployee);
            // 
            // designation
            // 
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.Location = new System.Drawing.Point(482, 222);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(243, 35);
            this.designation.TabIndex = 22;
            this.designation.TextChanged += new System.EventHandler(this.onChangeDesignation);
            // 
            // department
            // 
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(482, 282);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(243, 35);
            this.department.TabIndex = 21;
            this.department.TextChanged += new System.EventHandler(this.onChangeDepartment);
            // 
            // updatename
            // 
            this.updatename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatename.Location = new System.Drawing.Point(482, 159);
            this.updatename.Name = "updatename";
            this.updatename.Size = new System.Drawing.Size(243, 35);
            this.updatename.TabIndex = 20;
            this.updatename.TextChanged += new System.EventHandler(this.onChangeName);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Designation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Updating Employee Record";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 569);
            this.Controls.Add(this.updateEmp);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.department);
            this.Controls.Add(this.updatename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateEmployee_FormClosed);
            this.Load += new System.EventHandler(this.onLoadSetInputValues);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateEmp;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox updatename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}