namespace OctavePerlinNoise {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.pbNoise = new System.Windows.Forms.PictureBox();
      this.lblScale = new System.Windows.Forms.Label();
      this.tbScale = new System.Windows.Forms.TextBox();
      this.tbWidth = new System.Windows.Forms.TextBox();
      this.tbHeight = new System.Windows.Forms.TextBox();
      this.tbOctaves = new System.Windows.Forms.TextBox();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.lblWidth = new System.Windows.Forms.Label();
      this.lblHeight = new System.Windows.Forms.Label();
      this.lblOctaves = new System.Windows.Forms.Label();
      this.lblPersistance = new System.Windows.Forms.Label();
      this.lblLacunarity = new System.Windows.Forms.Label();
      this.tbPersistance = new System.Windows.Forms.TextBox();
      this.tbLacunarity = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbNoise)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.pbNoise, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblScale, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tbScale, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.tbWidth, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.tbHeight, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.tbOctaves, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.btnGenerate, 2, 6);
      this.tableLayoutPanel1.Controls.Add(this.lblWidth, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblHeight, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblOctaves, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblPersistance, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.lblLacunarity, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.tbPersistance, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.tbLacunarity, 2, 5);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 7;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // pbNoise
      // 
      this.pbNoise.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pbNoise.Location = new System.Drawing.Point(3, 3);
      this.pbNoise.Name = "pbNoise";
      this.tableLayoutPanel1.SetRowSpan(this.pbNoise, 7);
      this.pbNoise.Size = new System.Drawing.Size(620, 444);
      this.pbNoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbNoise.TabIndex = 0;
      this.pbNoise.TabStop = false;
      // 
      // lblScale
      // 
      this.lblScale.AutoSize = true;
      this.lblScale.Location = new System.Drawing.Point(629, 0);
      this.lblScale.Name = "lblScale";
      this.lblScale.Size = new System.Drawing.Size(34, 13);
      this.lblScale.TabIndex = 3;
      this.lblScale.Text = "Scale";
      // 
      // tbScale
      // 
      this.tbScale.Location = new System.Drawing.Point(697, 3);
      this.tbScale.Name = "tbScale";
      this.tbScale.Size = new System.Drawing.Size(100, 20);
      this.tbScale.TabIndex = 2;
      this.tbScale.Text = "0,01";
      // 
      // tbWidth
      // 
      this.tbWidth.Location = new System.Drawing.Point(697, 29);
      this.tbWidth.Name = "tbWidth";
      this.tbWidth.Size = new System.Drawing.Size(100, 20);
      this.tbWidth.TabIndex = 7;
      this.tbWidth.Text = "500";
      // 
      // tbHeight
      // 
      this.tbHeight.Location = new System.Drawing.Point(697, 55);
      this.tbHeight.Name = "tbHeight";
      this.tbHeight.Size = new System.Drawing.Size(100, 20);
      this.tbHeight.TabIndex = 9;
      this.tbHeight.Text = "500";
      // 
      // tbOctaves
      // 
      this.tbOctaves.Location = new System.Drawing.Point(697, 81);
      this.tbOctaves.Name = "tbOctaves";
      this.tbOctaves.Size = new System.Drawing.Size(100, 20);
      this.tbOctaves.TabIndex = 8;
      this.tbOctaves.Text = "4";
      // 
      // btnGenerate
      // 
      this.btnGenerate.Location = new System.Drawing.Point(697, 159);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(75, 23);
      this.btnGenerate.TabIndex = 1;
      this.btnGenerate.Text = "Generate";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
      // 
      // lblWidth
      // 
      this.lblWidth.AutoSize = true;
      this.lblWidth.Location = new System.Drawing.Point(629, 26);
      this.lblWidth.Name = "lblWidth";
      this.lblWidth.Size = new System.Drawing.Size(35, 13);
      this.lblWidth.TabIndex = 4;
      this.lblWidth.Text = "Width";
      // 
      // lblHeight
      // 
      this.lblHeight.AutoSize = true;
      this.lblHeight.Location = new System.Drawing.Point(629, 52);
      this.lblHeight.Name = "lblHeight";
      this.lblHeight.Size = new System.Drawing.Size(38, 13);
      this.lblHeight.TabIndex = 5;
      this.lblHeight.Text = "Height";
      // 
      // lblOctaves
      // 
      this.lblOctaves.AutoSize = true;
      this.lblOctaves.Location = new System.Drawing.Point(629, 78);
      this.lblOctaves.Name = "lblOctaves";
      this.lblOctaves.Size = new System.Drawing.Size(47, 13);
      this.lblOctaves.TabIndex = 6;
      this.lblOctaves.Text = "Octaves";
      // 
      // lblPersistance
      // 
      this.lblPersistance.AutoSize = true;
      this.lblPersistance.Location = new System.Drawing.Point(629, 104);
      this.lblPersistance.Name = "lblPersistance";
      this.lblPersistance.Size = new System.Drawing.Size(62, 13);
      this.lblPersistance.TabIndex = 10;
      this.lblPersistance.Text = "Persistance";
      // 
      // lblLacunarity
      // 
      this.lblLacunarity.AutoSize = true;
      this.lblLacunarity.Location = new System.Drawing.Point(629, 130);
      this.lblLacunarity.Name = "lblLacunarity";
      this.lblLacunarity.Size = new System.Drawing.Size(56, 13);
      this.lblLacunarity.TabIndex = 11;
      this.lblLacunarity.Text = "Lacunarity";
      // 
      // tbPersistance
      // 
      this.tbPersistance.Location = new System.Drawing.Point(697, 107);
      this.tbPersistance.Name = "tbPersistance";
      this.tbPersistance.Size = new System.Drawing.Size(100, 20);
      this.tbPersistance.TabIndex = 12;
      this.tbPersistance.Text = "0,5";
      // 
      // tbLacunarity
      // 
      this.tbLacunarity.Location = new System.Drawing.Point(697, 133);
      this.tbLacunarity.Name = "tbLacunarity";
      this.tbLacunarity.Size = new System.Drawing.Size(100, 20);
      this.tbLacunarity.TabIndex = 13;
      this.tbLacunarity.Text = "2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbNoise)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbNoise;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbScale;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblOctaves;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbOctaves;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblPersistance;
        private System.Windows.Forms.Label lblLacunarity;
        private System.Windows.Forms.TextBox tbPersistance;
        private System.Windows.Forms.TextBox tbLacunarity;
    }
}

