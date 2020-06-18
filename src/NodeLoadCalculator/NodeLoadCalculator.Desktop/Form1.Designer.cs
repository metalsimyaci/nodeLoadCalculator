namespace NodeLoadCalculator.Desktop
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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.grp_values = new System.Windows.Forms.GroupBox();
            this.flp_values = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp_relations = new System.Windows.Forms.GroupBox();
            this.flp_relations = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_result = new System.Windows.Forms.Panel();
            this.grp_result = new System.Windows.Forms.GroupBox();
            this.flp_result = new System.Windows.Forms.FlowLayoutPanel();
            this.grp_values.SuspendLayout();
            this.grp_relations.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_result.SuspendLayout();
            this.grp_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(10, 919);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(195, 63);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Hesapla";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // grp_values
            // 
            this.grp_values.Controls.Add(this.flp_values);
            this.grp_values.Dock = System.Windows.Forms.DockStyle.Left;
            this.grp_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_values.Location = new System.Drawing.Point(0, 0);
            this.grp_values.Name = "grp_values";
            this.grp_values.Padding = new System.Windows.Forms.Padding(10);
            this.grp_values.Size = new System.Drawing.Size(362, 466);
            this.grp_values.TabIndex = 1;
            this.grp_values.TabStop = false;
            this.grp_values.Text = "Degerler";
            // 
            // flp_values
            // 
            this.flp_values.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flp_values.Location = new System.Drawing.Point(10, 38);
            this.flp_values.Name = "flp_values";
            this.flp_values.Size = new System.Drawing.Size(342, 418);
            this.flp_values.TabIndex = 0;
            // 
            // grp_relations
            // 
            this.grp_relations.Controls.Add(this.flp_relations);
            this.grp_relations.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_relations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_relations.Location = new System.Drawing.Point(636, 0);
            this.grp_relations.Name = "grp_relations";
            this.grp_relations.Padding = new System.Windows.Forms.Padding(10);
            this.grp_relations.Size = new System.Drawing.Size(533, 466);
            this.grp_relations.TabIndex = 2;
            this.grp_relations.TabStop = false;
            this.grp_relations.Text = "Iliskiler";
            // 
            // flp_relations
            // 
            this.flp_relations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_relations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flp_relations.Location = new System.Drawing.Point(10, 38);
            this.flp_relations.Name = "flp_relations";
            this.flp_relations.Size = new System.Drawing.Size(513, 418);
            this.flp_relations.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_values);
            this.panel1.Controls.Add(this.grp_relations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 466);
            this.panel1.TabIndex = 3;
            // 
            // pnl_result
            // 
            this.pnl_result.Controls.Add(this.grp_result);
            this.pnl_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_result.Location = new System.Drawing.Point(10, 10);
            this.pnl_result.Name = "pnl_result";
            this.pnl_result.Size = new System.Drawing.Size(1169, 228);
            this.pnl_result.TabIndex = 4;
            // 
            // grp_result
            // 
            this.grp_result.Controls.Add(this.flp_result);
            this.grp_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_result.Location = new System.Drawing.Point(0, 0);
            this.grp_result.Name = "grp_result";
            this.grp_result.Padding = new System.Windows.Forms.Padding(10);
            this.grp_result.Size = new System.Drawing.Size(1169, 228);
            this.grp_result.TabIndex = 2;
            this.grp_result.TabStop = false;
            this.grp_result.Text = "Dugum Puanlari";
            // 
            // flp_result
            // 
            this.flp_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flp_result.Location = new System.Drawing.Point(10, 38);
            this.flp_result.Name = "flp_result";
            this.flp_result.Size = new System.Drawing.Size(1149, 180);
            this.flp_result.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 995);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_result);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dugum Yuk Hesaplayici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_values.ResumeLayout(false);
            this.grp_relations.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_result.ResumeLayout(false);
            this.grp_result.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.GroupBox grp_values;
        private System.Windows.Forms.FlowLayoutPanel flp_values;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grp_relations;
        private System.Windows.Forms.FlowLayoutPanel flp_relations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_result;
        private System.Windows.Forms.GroupBox grp_result;
        private System.Windows.Forms.FlowLayoutPanel flp_result;
    }
}

