/*

  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.

  Copyright (C) 2012 Michael Möller <mmoeller@openhardwaremonitor.org>

*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenHardwareMonitor.GUI {

  // On .NET Framework this class re-implemented the notify icon with P/Invoke
  // and reflection into WinForms internals to work around limitations of the
  // old NotifyIcon (ContextMenu support, taskbar re-creation handling). The
  // .NET 8 NotifyIcon supports ContextMenuStrip, all mouse and balloon tip
  // events and handles the TaskbarCreated message itself, so this is now a
  // thin wrapper.
  public class NotifyIconAdv : IDisposable {

    private readonly NotifyIcon notifyIcon = new NotifyIcon();

    public event EventHandler BalloonTipClicked {
      add { notifyIcon.BalloonTipClicked += value; }
      remove { notifyIcon.BalloonTipClicked -= value; }
    }

    public event EventHandler BalloonTipClosed {
      add { notifyIcon.BalloonTipClosed += value; }
      remove { notifyIcon.BalloonTipClosed -= value; }
    }

    public event EventHandler BalloonTipShown {
      add { notifyIcon.BalloonTipShown += value; }
      remove { notifyIcon.BalloonTipShown -= value; }
    }

    public event EventHandler Click {
      add { notifyIcon.Click += value; }
      remove { notifyIcon.Click -= value; }
    }

    public event EventHandler DoubleClick {
      add { notifyIcon.DoubleClick += value; }
      remove { notifyIcon.DoubleClick -= value; }
    }

    public event MouseEventHandler MouseClick {
      add { notifyIcon.MouseClick += value; }
      remove { notifyIcon.MouseClick -= value; }
    }

    public event MouseEventHandler MouseDoubleClick {
      add { notifyIcon.MouseDoubleClick += value; }
      remove { notifyIcon.MouseDoubleClick -= value; }
    }

    public event MouseEventHandler MouseDown {
      add { notifyIcon.MouseDown += value; }
      remove { notifyIcon.MouseDown -= value; }
    }

    public event MouseEventHandler MouseMove {
      add { notifyIcon.MouseMove += value; }
      remove { notifyIcon.MouseMove -= value; }
    }

    public event MouseEventHandler MouseUp {
      add { notifyIcon.MouseUp += value; }
      remove { notifyIcon.MouseUp -= value; }
    }

    public string BalloonTipText {
      get { return notifyIcon.BalloonTipText; }
      set { notifyIcon.BalloonTipText = value; }
    }

    public ToolTipIcon BalloonTipIcon {
      get { return notifyIcon.BalloonTipIcon; }
      set { notifyIcon.BalloonTipIcon = value; }
    }

    public string BalloonTipTitle {
      get { return notifyIcon.BalloonTipTitle; }
      set { notifyIcon.BalloonTipTitle = value; }
    }

    public ContextMenuStrip ContextMenuStrip {
      get { return notifyIcon.ContextMenuStrip; }
      set { notifyIcon.ContextMenuStrip = value; }
    }

    public object Tag {
      get { return notifyIcon.Tag; }
      set { notifyIcon.Tag = value; }
    }

    public Icon Icon {
      get { return notifyIcon.Icon; }
      set { notifyIcon.Icon = value; }
    }

    public string Text {
      get { return notifyIcon.Text; }
      set { notifyIcon.Text = value; }
    }

    public bool Visible {
      get { return notifyIcon.Visible; }
      set { notifyIcon.Visible = value; }
    }

    public void Dispose() {
      notifyIcon.Dispose();
    }

    public void ShowBalloonTip(int timeout) {
      notifyIcon.ShowBalloonTip(timeout);
    }

    public void ShowBalloonTip(int timeout, string tipTitle, string tipText,
      ToolTipIcon tipIcon) {
      notifyIcon.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
    }
  }
}
