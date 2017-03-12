namespace PermitTrak
{
    partial class frmCancelPermit
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataRepeatCancelPermit = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.txtPermitID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermitNumber = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.dataRepeatCancelPermit.ItemTemplate.SuspendLayout();
            this.dataRepeatCancelPermit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancel Permit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataRepeatCancelPermit
            // 
            this.dataRepeatCancelPermit.AllowUserToAddItems = false;
            this.dataRepeatCancelPermit.AllowUserToDeleteItems = false;
            // 
            // dataRepeatCancelPermit.ItemTemplate
            // 
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.txtPermitID);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.label5);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.txtCompanyName);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.label4);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.txtDescription);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.label3);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.label2);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.txtPermitNumber);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.txtStartDate);
            this.dataRepeatCancelPermit.ItemTemplate.Controls.Add(this.cmdCancel);
            this.dataRepeatCancelPermit.ItemTemplate.Size = new System.Drawing.Size(623, 96);
            this.dataRepeatCancelPermit.Location = new System.Drawing.Point(12, 52);
            this.dataRepeatCancelPermit.Name = "dataRepeatCancelPermit";
            this.dataRepeatCancelPermit.Size = new System.Drawing.Size(631, 311);
            this.dataRepeatCancelPermit.TabIndex = 1;
            this.dataRepeatCancelPermit.Text = "dataRepeater1";
            this.dataRepeatCancelPermit.ItemValueNeeded += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemValueEventHandler(this.dataRepeatCancelPermit_ItemValueNeeded);
            // 
            // txtPermitID
            // 
            this.txtPermitID.Location = new System.Drawing.Point(229, 60);
            this.txtPermitID.Name = "txtPermitID";
            this.txtPermitID.Size = new System.Drawing.Size(27, 20);
            this.txtPermitID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Company";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(85, 60);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(125, 20);
            this.txtCompanyName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(216, 8);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(283, 46);
            this.txtDescription.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Permit Number";
            // 
            // txtPermitNumber
            // 
            this.txtPermitNumber.Location = new System.Drawing.Point(85, 8);
            this.txtPermitNumber.Name = "txtPermitNumber";
            this.txtPermitNumber.Size = new System.Drawing.Size(59, 20);
            this.txtPermitNumber.TabIndex = 3;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(85, 34);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(59, 20);
            this.txtStartDate.TabIndex = 1;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(518, 32);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmCancelPermit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 375);
            this.Controls.Add(this.dataRepeatCancelPermit);
            this.Controls.Add(this.label1);
            this.Name = "frmCancelPermit";
            this.Text = "frmCancelPermit";
            this.dataRepeatCancelPermit.ItemTemplate.ResumeLayout(false);
            this.dataRepeatCancelPermit.ItemTemplate.PerformLayout();
            this.dataRepeatCancelPermit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeatCancelPermit;
        private System.Windows.Forms.TextBox txtPermitNumber;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPermitID;
    }
}