namespace CyotekDotComRotateArrayDemo
{
  partial class MainForm
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
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.rotationTimer = new System.Windows.Forms.Timer(this.components);
      this.cyotekLinkLabel = new System.Windows.Forms.LinkLabel();
      this.closeButton = new System.Windows.Forms.Button();
      this.clockwiseRadioButton = new System.Windows.Forms.RadioButton();
      this.antiClockwiseRadioButton = new System.Windows.Forms.RadioButton();
      this.speedTrackBar = new System.Windows.Forms.TrackBar();
      this.zPolyominoViewer = new CyotekDotComRotateArrayDemo.PolyominoViewer();
      this.tPolyominoViewer = new CyotekDotComRotateArrayDemo.PolyominoViewer();
      this.sPolyominoViewer = new CyotekDotComRotateArrayDemo.PolyominoViewer();
      this.oPolyominoViewer = new CyotekDotComRotateArrayDemo.PolyominoViewer();
      this.lPolyominoViewer = new CyotekDotComRotateArrayDemo.PolyominoViewer();
      this.jPolyominoViewer = new CyotekDotComRotateArrayDemo.PolyominoViewer();
      this.iPolyominoViewer = new CyotekDotComRotateArrayDemo.PolyominoViewer();
      this.tableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel.ColumnCount = 7;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel.Controls.Add(this.zPolyominoViewer, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.tPolyominoViewer, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.sPolyominoViewer, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.oPolyominoViewer, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.lPolyominoViewer, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.jPolyominoViewer, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.iPolyominoViewer, 0, 0);
      this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 1;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(690, 152);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // rotationTimer
      // 
      this.rotationTimer.Enabled = true;
      this.rotationTimer.Interval = 1000;
      this.rotationTimer.Tick += new System.EventHandler(this.rotationTimer_Tick);
      // 
      // cyotekLinkLabel
      // 
      this.cyotekLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cyotekLinkLabel.AutoSize = true;
      this.cyotekLinkLabel.Location = new System.Drawing.Point(12, 181);
      this.cyotekLinkLabel.Name = "cyotekLinkLabel";
      this.cyotekLinkLabel.Size = new System.Drawing.Size(89, 13);
      this.cyotekLinkLabel.TabIndex = 4;
      this.cyotekLinkLabel.TabStop = true;
      this.cyotekLinkLabel.Text = "www.cyotek.com";
      this.cyotekLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cyotekLinkLabel_LinkClicked);
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(737, 176);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 5;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // clockwiseRadioButton
      // 
      this.clockwiseRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.clockwiseRadioButton.AutoSize = true;
      this.clockwiseRadioButton.Checked = true;
      this.clockwiseRadioButton.Location = new System.Drawing.Point(708, 63);
      this.clockwiseRadioButton.Name = "clockwiseRadioButton";
      this.clockwiseRadioButton.Size = new System.Drawing.Size(73, 17);
      this.clockwiseRadioButton.TabIndex = 2;
      this.clockwiseRadioButton.TabStop = true;
      this.clockwiseRadioButton.Text = "&Clockwise";
      this.clockwiseRadioButton.UseVisualStyleBackColor = true;
      // 
      // antiClockwiseRadioButton
      // 
      this.antiClockwiseRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.antiClockwiseRadioButton.AutoSize = true;
      this.antiClockwiseRadioButton.Location = new System.Drawing.Point(708, 86);
      this.antiClockwiseRadioButton.Name = "antiClockwiseRadioButton";
      this.antiClockwiseRadioButton.Size = new System.Drawing.Size(93, 17);
      this.antiClockwiseRadioButton.TabIndex = 3;
      this.antiClockwiseRadioButton.Text = "&Anti-clockwise";
      this.antiClockwiseRadioButton.UseVisualStyleBackColor = true;
      // 
      // speedTrackBar
      // 
      this.speedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.speedTrackBar.Location = new System.Drawing.Point(708, 12);
      this.speedTrackBar.Maximum = 5000;
      this.speedTrackBar.Minimum = 500;
      this.speedTrackBar.Name = "speedTrackBar";
      this.speedTrackBar.Size = new System.Drawing.Size(104, 45);
      this.speedTrackBar.TabIndex = 1;
      this.speedTrackBar.TickFrequency = 500;
      this.speedTrackBar.Value = 1000;
      this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
      // 
      // zPolyominoViewer
      // 
      this.zPolyominoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.zPolyominoViewer.Location = new System.Drawing.Point(395, 3);
      this.zPolyominoViewer.Name = "zPolyominoViewer";
      this.zPolyominoViewer.Size = new System.Drawing.Size(92, 146);
      this.zPolyominoViewer.TabIndex = 4;
      // 
      // tPolyominoViewer
      // 
      this.tPolyominoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tPolyominoViewer.Location = new System.Drawing.Point(493, 3);
      this.tPolyominoViewer.Name = "tPolyominoViewer";
      this.tPolyominoViewer.Size = new System.Drawing.Size(92, 146);
      this.tPolyominoViewer.TabIndex = 5;
      // 
      // sPolyominoViewer
      // 
      this.sPolyominoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sPolyominoViewer.Location = new System.Drawing.Point(591, 3);
      this.sPolyominoViewer.Name = "sPolyominoViewer";
      this.sPolyominoViewer.Size = new System.Drawing.Size(96, 146);
      this.sPolyominoViewer.TabIndex = 6;
      // 
      // oPolyominoViewer
      // 
      this.oPolyominoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.oPolyominoViewer.Location = new System.Drawing.Point(297, 3);
      this.oPolyominoViewer.Name = "oPolyominoViewer";
      this.oPolyominoViewer.Size = new System.Drawing.Size(92, 146);
      this.oPolyominoViewer.TabIndex = 3;
      // 
      // lPolyominoViewer
      // 
      this.lPolyominoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lPolyominoViewer.Location = new System.Drawing.Point(3, 3);
      this.lPolyominoViewer.Name = "lPolyominoViewer";
      this.lPolyominoViewer.Size = new System.Drawing.Size(92, 146);
      this.lPolyominoViewer.TabIndex = 0;
      // 
      // jPolyominoViewer
      // 
      this.jPolyominoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.jPolyominoViewer.Location = new System.Drawing.Point(101, 3);
      this.jPolyominoViewer.Name = "jPolyominoViewer";
      this.jPolyominoViewer.Size = new System.Drawing.Size(92, 146);
      this.jPolyominoViewer.TabIndex = 1;
      // 
      // iPolyominoViewer
      // 
      this.iPolyominoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.iPolyominoViewer.Location = new System.Drawing.Point(199, 3);
      this.iPolyominoViewer.Name = "iPolyominoViewer";
      this.iPolyominoViewer.Size = new System.Drawing.Size(92, 146);
      this.iPolyominoViewer.TabIndex = 2;
      // 
      // MainForm
      // 
      this.AcceptButton = this.closeButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(824, 211);
      this.Controls.Add(this.speedTrackBar);
      this.Controls.Add(this.antiClockwiseRadioButton);
      this.Controls.Add(this.clockwiseRadioButton);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.cyotekLinkLabel);
      this.Controls.Add(this.tableLayoutPanel);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "www.cyotek.com Array Rotation Demo";
      this.tableLayoutPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private PolyominoViewer iPolyominoViewer;
    private PolyominoViewer zPolyominoViewer;
    private PolyominoViewer tPolyominoViewer;
    private PolyominoViewer sPolyominoViewer;
    private PolyominoViewer oPolyominoViewer;
    private PolyominoViewer lPolyominoViewer;
    private PolyominoViewer jPolyominoViewer;
    private System.Windows.Forms.Timer rotationTimer;
    private System.Windows.Forms.LinkLabel cyotekLinkLabel;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.RadioButton clockwiseRadioButton;
    private System.Windows.Forms.RadioButton antiClockwiseRadioButton;
    private System.Windows.Forms.TrackBar speedTrackBar;
  }
}

