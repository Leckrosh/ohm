/*

  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.

  Copyright (C) 2009-2020 Michael Möller <mmoeller@openhardwaremonitor.org>

*/

using System;
using System.Threading;
using System.Windows.Forms;
using OpenHardwareMonitor.GUI;

namespace OpenHardwareMonitor {
  public static class Program {

    [STAThread]
    public static void Main() {
      #if !DEBUG
        Application.ThreadException +=
          new ThreadExceptionEventHandler(Application_ThreadException);
        Application.SetUnhandledExceptionMode(
          UnhandledExceptionMode.CatchException);

        AppDomain.CurrentDomain.UnhandledException +=
          new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
      #endif

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      using (GUI.MainForm form = new GUI.MainForm()) {
        form.FormClosed += delegate(Object sender, FormClosedEventArgs e) {
          Application.Exit();
        };
        Application.Run();
      }
    }

    private static void ReportException(Exception e) {
      CrashForm form = new CrashForm();
      form.Exception = e;
      form.ShowDialog();
    }

    public static void Application_ThreadException(object sender,
      ThreadExceptionEventArgs e)
    {
      try {
        ReportException(e.Exception);
      } catch {
      } finally {
        Application.Exit();
      }
    }

    public static void CurrentDomain_UnhandledException(object sender,
      UnhandledExceptionEventArgs args)
    {
      try {
        Exception e = args.ExceptionObject as Exception;
        if (e != null)
          ReportException(e);
      } catch {
      } finally {
        Environment.Exit(0);
      }
    }
  }
}
