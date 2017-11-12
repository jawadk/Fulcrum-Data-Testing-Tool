namespace Fulcrum_Data_Testing_Tool
{
    partial class DashBorad
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
            this.txtb_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ReadXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // txtb_FilePath
            // 
            this.txtb_FilePath.Location = new System.Drawing.Point(81, 18);
            this.txtb_FilePath.Name = "txtb_FilePath";
            this.txtb_FilePath.Size = new System.Drawing.Size(445, 20);
            this.txtb_FilePath.TabIndex = 1;
            this.txtb_FilePath.Text = "D:\\Inbound_Product.xml";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(551, 18);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ReadXML
            // 
            this.btn_ReadXML.Location = new System.Drawing.Point(551, 91);
            this.btn_ReadXML.Name = "btn_ReadXML";
            this.btn_ReadXML.Size = new System.Drawing.Size(75, 22);
            this.btn_ReadXML.TabIndex = 3;
            this.btn_ReadXML.Text = "Read XML";
            this.btn_ReadXML.UseVisualStyleBackColor = true;
            this.btn_ReadXML.Click += new System.EventHandler(this.btn_ReadXML_Click);
            // 
            // DashBorad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 273);
            this.Controls.Add(this.btn_ReadXML);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txtb_FilePath);
            this.Controls.Add(this.label1);
            this.Name = "DashBorad";
            this.Text = "Fulcrum Data Validation DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_FilePath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ReadXML;
    }
}

