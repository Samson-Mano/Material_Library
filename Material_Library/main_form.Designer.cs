namespace Material_Library
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_category = new System.Windows.Forms.Label();
            this.comboBox_units = new System.Windows.Forms.ComboBox();
            this.comboBox_material = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exportSelMat = new System.Windows.Forms.Button();
            this.button_exportAllMat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_expFormat = new System.Windows.Forms.ComboBox();
            this.richTextBox_materialDetails = new System.Windows.Forms.RichTextBox();
            this.button_consistentunit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_consistentunit);
            this.groupBox1.Controls.Add(this.comboBox_expFormat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_exportAllMat);
            this.groupBox1.Controls.Add(this.button_exportSelMat);
            this.groupBox1.Controls.Add(this.label_category);
            this.groupBox1.Controls.Add(this.comboBox_units);
            this.groupBox1.Controls.Add(this.comboBox_material);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Selection Pane";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Location = new System.Drawing.Point(160, 111);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(21, 20);
            this.label_category.TabIndex = 11;
            this.label_category.Text = "__";
            // 
            // comboBox_units
            // 
            this.comboBox_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_units.FormattingEnabled = true;
            this.comboBox_units.Location = new System.Drawing.Point(160, 155);
            this.comboBox_units.Name = "comboBox_units";
            this.comboBox_units.Size = new System.Drawing.Size(197, 28);
            this.comboBox_units.TabIndex = 10;
            // 
            // comboBox_material
            // 
            this.comboBox_material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_material.FormattingEnabled = true;
            this.comboBox_material.Location = new System.Drawing.Point(160, 53);
            this.comboBox_material.Name = "comboBox_material";
            this.comboBox_material.Size = new System.Drawing.Size(197, 28);
            this.comboBox_material.TabIndex = 9;
            this.comboBox_material.SelectedIndexChanged += new System.EventHandler(this.comboBox_material_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Units : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Material Name : ";
            // 
            // button_exportSelMat
            // 
            this.button_exportSelMat.Location = new System.Drawing.Point(478, 45);
            this.button_exportSelMat.Name = "button_exportSelMat";
            this.button_exportSelMat.Size = new System.Drawing.Size(226, 43);
            this.button_exportSelMat.TabIndex = 12;
            this.button_exportSelMat.Text = "Export Selected Material";
            this.button_exportSelMat.UseVisualStyleBackColor = true;
            // 
            // button_exportAllMat
            // 
            this.button_exportAllMat.Location = new System.Drawing.Point(478, 102);
            this.button_exportAllMat.Name = "button_exportAllMat";
            this.button_exportAllMat.Size = new System.Drawing.Size(225, 39);
            this.button_exportAllMat.TabIndex = 13;
            this.button_exportAllMat.Text = "Export All Material";
            this.button_exportAllMat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Export Format : ";
            // 
            // comboBox_expFormat
            // 
            this.comboBox_expFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_expFormat.FormattingEnabled = true;
            this.comboBox_expFormat.Location = new System.Drawing.Point(606, 155);
            this.comboBox_expFormat.Name = "comboBox_expFormat";
            this.comboBox_expFormat.Size = new System.Drawing.Size(98, 28);
            this.comboBox_expFormat.TabIndex = 15;
            // 
            // richTextBox_materialDetails
            // 
            this.richTextBox_materialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_materialDetails.Location = new System.Drawing.Point(12, 230);
            this.richTextBox_materialDetails.Name = "richTextBox_materialDetails";
            this.richTextBox_materialDetails.Size = new System.Drawing.Size(856, 449);
            this.richTextBox_materialDetails.TabIndex = 7;
            this.richTextBox_materialDetails.Text = "";
            // 
            // button_consistentunit
            // 
            this.button_consistentunit.Location = new System.Drawing.Point(363, 153);
            this.button_consistentunit.Name = "button_consistentunit";
            this.button_consistentunit.Size = new System.Drawing.Size(51, 31);
            this.button_consistentunit.TabIndex = 16;
            this.button_consistentunit.Text = "?";
            this.button_consistentunit.UseVisualStyleBackColor = true;
            this.button_consistentunit.Click += new System.EventHandler(this.button_consistentunit_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 691);
            this.Controls.Add(this.richTextBox_materialDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(898, 738);
            this.Name = "main_form";
            this.Text = "FEA Material Library -------- Developed by Samson Mano <saminnx@gmail.com>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_form_FormClosing);
            this.Load += new System.EventHandler(this.main_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox comboBox_units;
        private System.Windows.Forms.ComboBox comboBox_material;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_expFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_exportAllMat;
        private System.Windows.Forms.Button button_exportSelMat;
        private System.Windows.Forms.RichTextBox richTextBox_materialDetails;
        private System.Windows.Forms.Button button_consistentunit;
    }
}

