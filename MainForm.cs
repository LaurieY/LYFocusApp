using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using ASCOM.
using ASCOM.Interface;
using ASCOM.Utilities;
using ASCOM.DriverAccess;

namespace LYFocusApp
{
    public partial class MainForm : Form
    {
        private Focuser _focuser;
        private string _progID;
        private Int32 newPosition;
        private string directionSetting = "Default";

        //private string _appID = "ASCOM.OpenFocuser.Focuser";
        //private Profile _profile = new Profile();

        public MainForm()
        {
            //_progID = _profile.GetValue(_appID, "ChosenFocuser");

            InitializeComponent();
            ChosenFocuser.Text = _progID;
            if (_progID == null || _progID == "")
                ConnectButton.Enabled = false;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            ASCOM.Utilities.Chooser _chooser = new Chooser();
            _chooser.DeviceType = "Focuser";
            _progID = _chooser.Choose(_progID);
            _chooser.Dispose();
            ChosenFocuser.Text = _progID;
            //_profile.WriteValue(_appID, "ChosenFocuser", _progID);
            if (_progID == "")
                return;
            if (_progID == "")
                ConnectButton.Enabled = false;
            else
                ConnectButton.Enabled = true;

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connect" && _progID != "")
            {
                if (_focuser == null)
                {
                    _focuser = new Focuser(_progID);
                }
                _focuser.Connected = true;
                ConnectButton.Text = "Disconnect";
                string _t = _focuser.Action("Focuser:Temper","DeviceName");
                lblTemperHum.Text = _t;
                   
            ////       .TEMPerHum.GlobalV.TEMPerHUMx.TEMPerHUMfw;
                 //VersionLabel.Text = _focuser.Version;
                this.PositionTimer.Enabled = true;   //LEY

            }
            else
            {
                _focuser.Link = false;
                ConnectButton.Text = "Connect";
                PositionTimer.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PositionTimer_Tick(object sender, EventArgs e)
        { 
            if (_focuser.Link)
                tBActualPosition.Text = _focuser.Position.ToString();

            else
                tBActualPosition.Text = "NC";
        }

        private void FocusControls_Enter(object sender, EventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (_focuser.Absolute)
                newPosition = _focuser.Position - Convert.ToInt32(nUDMove.Value);
  /*          if (newPosition < 1)
                newPosition = 0; // limit move to zero*/
            _focuser.Move(newPosition);

        }

        private void btOut_Click(object sender, EventArgs e)
        {
            if (_focuser.Absolute)
                newPosition = _focuser.Position + Convert.ToInt32(nUDMove.Value);
      /*      if (newPosition < 1)
                newPosition = 0; // limit move to zero */
            _focuser.Move(newPosition);
        }

        private void btHalt_Click(object sender, EventArgs e)
        {
            if (_focuser.Link)
                _focuser.Halt();
        }

        private void nUDMove_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (directionSetting == "Default")
            {
                _focuser.Action("Focuser:Swap", "Swap");

                directionSetting = "Swap";

            }
            else
            {
                _focuser.Action("Focuser:Swap", "Default");
                directionSetting = "Default";

            }

        }

        private void setPos_Click(object sender, EventArgs e)
        {
   //    Boolean _fred =  _focuser.IsMoving;
            PositionTimer.Enabled = false;
         newPosition =  Convert.ToInt32(setPosBox1.Text);
         string Cmd = "k " + newPosition.ToString();
             string resp = _focuser.CommandString(Cmd, false);
             tBActualPosition.Text = _focuser.Position.ToString();

             string[] in_parts = Cmd.Split(' ');
             string[] out_parts = resp.Split(' ');
             PositionTimer.Enabled = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getProperty_Click(object sender, EventArgs e)
        { string gPropItem= listProperty.SelectedItem.ToString();
        textProperty.Text = gPropItem;
        switch (gPropItem)
        {case "MaxStep":
                textProperty.Text = _focuser.MaxStep.ToString();

                break;

         case "MaxIncrement":
                textProperty.Text = _focuser.MaxIncrement.ToString();
                break;
         case "Absolute":
                textProperty.Text = _focuser.Absolute.ToString();
                break;
         case "Temperature":
                textProperty.Text = _focuser.Temperature.ToString("##.##");
                break;
         case "Humidity":
                textProperty.Text = _focuser.Action("Focuser:Temper", "Humidity");
                break;
         case "Calibration":
                textProperty.Text = _focuser.Action("Focuser:Temper", "Calibration");
                break;

        }

        }
        
      
        
        }

 
    
    
}
