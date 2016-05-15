namespace LYFocusApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ChosenFocuser = new System.Windows.Forms.Label();
            this.FocusControls = new System.Windows.Forms.GroupBox();
            this.setPosBox1 = new System.Windows.Forms.TextBox();
            this.getProperty = new System.Windows.Forms.Button();
            this.listProperty = new System.Windows.Forms.ListBox();
            this.setPos = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.btHalt = new System.Windows.Forms.Button();
            this.lbMoveSize = new System.Windows.Forms.Label();
            this.nUDMove = new System.Windows.Forms.NumericUpDown();
            this.btOut = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.tBActualPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.PositionTimer = new System.Windows.Forms.Timer(this.components);
            this.textProperty = new System.Windows.Forms.TextBox();
            this.lblTemperHum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.FocusControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMove)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChooseButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConnectButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChosenFocuser, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(3, 3);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 0;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(3, 53);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ChosenFocuser
            // 
            this.ChosenFocuser.AutoSize = true;
            this.ChosenFocuser.Location = new System.Drawing.Point(103, 0);
            this.ChosenFocuser.Name = "ChosenFocuser";
            this.ChosenFocuser.Size = new System.Drawing.Size(0, 13);
            this.ChosenFocuser.TabIndex = 2;
            // 
            // FocusControls
            // 
            this.FocusControls.Controls.Add(this.label1);
            this.FocusControls.Controls.Add(this.setPosBox1);
            this.FocusControls.Controls.Add(this.getProperty);
            this.FocusControls.Controls.Add(this.listProperty);
            this.FocusControls.Controls.Add(this.setPos);
            this.FocusControls.Controls.Add(this.buttonSwap);
            this.FocusControls.Controls.Add(this.btHalt);
            this.FocusControls.Controls.Add(this.lbMoveSize);
            this.FocusControls.Controls.Add(this.nUDMove);
            this.FocusControls.Controls.Add(this.btOut);
            this.FocusControls.Controls.Add(this.btIn);
            this.FocusControls.Controls.Add(this.tBActualPosition);
            this.FocusControls.Controls.Add(this.labelPosition);
            this.FocusControls.Location = new System.Drawing.Point(13, 142);
            this.FocusControls.Name = "FocusControls";
            this.FocusControls.Size = new System.Drawing.Size(200, 335);
            this.FocusControls.TabIndex = 1;
            this.FocusControls.TabStop = false;
            this.FocusControls.Text = "FocusControls";
            this.FocusControls.Enter += new System.EventHandler(this.FocusControls_Enter);
            // 
            // setPosBox1
            // 
            this.setPosBox1.Location = new System.Drawing.Point(11, 192);
            this.setPosBox1.Name = "setPosBox1";
            this.setPosBox1.Size = new System.Drawing.Size(63, 20);
            this.setPosBox1.TabIndex = 9;
            this.setPosBox1.Text = "2000";
            // 
            // getProperty
            // 
            this.getProperty.Location = new System.Drawing.Point(97, 230);
            this.getProperty.Name = "getProperty";
            this.getProperty.Size = new System.Drawing.Size(91, 23);
            this.getProperty.TabIndex = 2;
            this.getProperty.Text = "Get Property";
            this.getProperty.UseVisualStyleBackColor = true;
            this.getProperty.Click += new System.EventHandler(this.getProperty_Click);
            // 
            // listProperty
            // 
            this.listProperty.BackColor = System.Drawing.SystemColors.Info;
            this.listProperty.FormattingEnabled = true;
            this.listProperty.Items.AddRange(new object[] {
            "MaxStep",
            "MaxIncrement",
            "Absolute",
            "Temperature",
            "Humidity",
            "Calibration"});
            this.listProperty.Location = new System.Drawing.Point(6, 230);
            this.listProperty.Name = "listProperty";
            this.listProperty.Size = new System.Drawing.Size(85, 82);
            this.listProperty.TabIndex = 3;
            this.listProperty.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // setPos
            // 
            this.setPos.Location = new System.Drawing.Point(106, 188);
            this.setPos.Name = "setPos";
            this.setPos.Size = new System.Drawing.Size(91, 24);
            this.setPos.TabIndex = 8;
            this.setPos.Text = "Set Position Value";
            this.setPos.UseVisualStyleBackColor = true;
            this.setPos.Click += new System.EventHandler(this.setPos_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(108, 144);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(98, 28);
            this.buttonSwap.TabIndex = 7;
            this.buttonSwap.Text = "SwapDirection";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // btHalt
            // 
            this.btHalt.Location = new System.Drawing.Point(11, 144);
            this.btHalt.Name = "btHalt";
            this.btHalt.Size = new System.Drawing.Size(63, 29);
            this.btHalt.TabIndex = 6;
            this.btHalt.Text = "Halt";
            this.btHalt.UseVisualStyleBackColor = true;
            this.btHalt.Click += new System.EventHandler(this.btHalt_Click);
            // 
            // lbMoveSize
            // 
            this.lbMoveSize.AutoSize = true;
            this.lbMoveSize.Location = new System.Drawing.Point(11, 68);
            this.lbMoveSize.Name = "lbMoveSize";
            this.lbMoveSize.Size = new System.Drawing.Size(57, 13);
            this.lbMoveSize.TabIndex = 5;
            this.lbMoveSize.Text = "Move Size";
            // 
            // nUDMove
            // 
            this.nUDMove.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDMove.Location = new System.Drawing.Point(97, 61);
            this.nUDMove.Maximum = new decimal(new int[] {
            6400,
            0,
            0,
            0});
            this.nUDMove.Name = "nUDMove";
            this.nUDMove.Size = new System.Drawing.Size(103, 20);
            this.nUDMove.TabIndex = 4;
            this.nUDMove.ValueChanged += new System.EventHandler(this.nUDMove_ValueChanged);
            // 
            // btOut
            // 
            this.btOut.Location = new System.Drawing.Point(108, 99);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(68, 27);
            this.btOut.TabIndex = 3;
            this.btOut.Text = "Out";
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(11, 98);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(67, 28);
            this.btIn.TabIndex = 2;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // tBActualPosition
            // 
            this.tBActualPosition.Location = new System.Drawing.Point(106, 23);
            this.tBActualPosition.Name = "tBActualPosition";
            this.tBActualPosition.Size = new System.Drawing.Size(100, 20);
            this.tBActualPosition.TabIndex = 1;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(11, 29);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Position";
            this.labelPosition.Click += new System.EventHandler(this.label1_Click);
            // 
            // PositionTimer
            // 
            this.PositionTimer.Interval = 2000;
            this.PositionTimer.Tick += new System.EventHandler(this.PositionTimer_Tick);
            // 
            // textProperty
            // 
            this.textProperty.Location = new System.Drawing.Point(15, 509);
            this.textProperty.Name = "textProperty";
            this.textProperty.Size = new System.Drawing.Size(178, 20);
            this.textProperty.TabIndex = 4;
            // 
            // lblTemperHum
            // 
            this.lblTemperHum.AutoSize = true;
            this.lblTemperHum.Location = new System.Drawing.Point(19, 120);
            this.lblTemperHum.Name = "lblTemperHum";
            this.lblTemperHum.Size = new System.Drawing.Size(0, 13);
            this.lblTemperHum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "V2.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 544);
            this.Controls.Add(this.lblTemperHum);
            this.Controls.Add(this.textProperty);
            this.Controls.Add(this.FocusControls);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Focuser Controller";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.FocusControls.ResumeLayout(false);
            this.FocusControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label ChosenFocuser;
        private System.Windows.Forms.GroupBox FocusControls;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox tBActualPosition;
        private System.Windows.Forms.Timer PositionTimer;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.NumericUpDown nUDMove;
        private System.Windows.Forms.Label lbMoveSize;
        private System.Windows.Forms.Button btHalt;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button setPos;
        private System.Windows.Forms.TextBox setPosBox1;
        private System.Windows.Forms.Button getProperty;
        private System.Windows.Forms.ListBox listProperty;
        private System.Windows.Forms.TextBox textProperty;
        private System.Windows.Forms.Label lblTemperHum;
        private System.Windows.Forms.Label label1;
    }
}

