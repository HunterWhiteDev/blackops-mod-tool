using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDevkit;
using XRPCLib;

namespace blackops_mod_tool
{
    public partial class Form1 : Form
    {

        XRPC XRPC = new XRPC();

        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            XRPC.Connect();
            if (XRPC.activeConnection)
            {
                XRPC.Notify(XRPC.XNotiyLogo.XBOX_LOGO, "Black Ops Mod Tool Connected");
            } else
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void noclip_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "noclip");
        }

        private void godmode_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "god");
        }

        private void thirdperson_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "toggle cg_thirdperson");

        }

        private void minTimeScale_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "timescale 0.2");

        }

        private void maxTimeScale_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "timescale 2.5");

        }

        private void resetTimeScale_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "reset timescale");

        }

        private void fov100_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "cg_fov 100");

        }

        private void giveAmmo_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "give ammo");

        }

        private void farKnife_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "player_meleeRange 999");

        }

        private void dropWeapon_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "dropweapon");

        }

        private void maxSpeed_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "g_speed 900");

        }

        private void normSpeed_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "reset g_speed");

        }

        private void unlimAmmo_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8230FD58, 0, "player_clipSizeMultiplier 999");

        }
    }
}
