namespace Form_Qly_Sim
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
            this.components = new System.ComponentModel.Container();
            this.simTheDataSet = new Form_Qly_Sim.SimTheDataSet();
            this.simTheDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simTheDataSet1 = new Form_Qly_Sim.SimTheDataSet1();
            this.simTheDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSim = new System.Windows.Forms.DataGridView();
            this.simTheDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simTheDataSet2 = new Form_Qly_Sim.SimTheDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // simTheDataSet
            // 
            this.simTheDataSet.DataSetName = "SimTheDataSet";
            this.simTheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simTheDataSetBindingSource
            // 
            this.simTheDataSetBindingSource.DataSource = this.simTheDataSet;
            this.simTheDataSetBindingSource.Position = 0;
            // 
            // simTheDataSet1
            // 
            this.simTheDataSet1.DataSetName = "SimTheDataSet1";
            this.simTheDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simTheDataSet1BindingSource
            // 
            this.simTheDataSet1BindingSource.DataSource = this.simTheDataSet1;
            this.simTheDataSet1BindingSource.Position = 0;
            // 
            // dataGridViewSim
            // 
            this.dataGridViewSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSim.Location = new System.Drawing.Point(173, 84);
            this.dataGridViewSim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSim.Name = "dataGridViewSim";
            this.dataGridViewSim.RowHeadersWidth = 51;
            this.dataGridViewSim.RowTemplate.Height = 24;
            this.dataGridViewSim.Size = new System.Drawing.Size(535, 220);
            this.dataGridViewSim.TabIndex = 0;
            // 
            // simTheDataSet2BindingSource
            // 
            this.simTheDataSet2BindingSource.DataSource = this.simTheDataSet2;
            this.simTheDataSet2BindingSource.Position = 0;
            // 
            // simTheDataSet2
            // 
            this.simTheDataSet2.DataSetName = "SimTheDataSet2";
            this.simTheDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Sim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSim);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simTheDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource simTheDataSetBindingSource;
        private SimTheDataSet simTheDataSet;
        private SimTheDataSet1 simTheDataSet1;
        private System.Windows.Forms.BindingSource simTheDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSim;
        private System.Windows.Forms.BindingSource simTheDataSet2BindingSource;
        private SimTheDataSet2 simTheDataSet2;
        private System.Windows.Forms.Label label1;
    }
}

