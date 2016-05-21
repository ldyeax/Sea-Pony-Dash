﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqDev
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFrameEditor_Click(object sender, EventArgs e)
        {
            (new FrameSelector()).Show();
        }

        private void btnAnimationEdtior_Click(object sender, EventArgs e)
        {
            (new AnimationSelector()).Show();
        }

        private void btnAnimationGroupEditor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            SqEng.SqEng.Start();
        }

        private void btnStateEditor_Click(object sender, EventArgs e)
        {
            (new StateEditor()).Show();
        }
    }
}
