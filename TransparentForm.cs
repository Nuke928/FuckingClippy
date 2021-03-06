﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuckingClippy
{
    public class TransparentForm : Form
    {
        public TransparentForm()
        {
            if (IsRunningOnMono)
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor |
                    ControlStyles.UserPaint, true);
                BackColor = Color.Transparent;
            }
            else
            {
                TransparencyKey = Color.Purple;
                BackColor = Color.Purple;
            }
        }

        public bool IsRunningOnMono
        {
            get
            {
                return Type.GetType("Mono.Runtime") != null;
            }
        }
    }
}
