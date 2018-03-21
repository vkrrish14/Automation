﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace my_sample_testsuite
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("ae1491c3-c2b6-4a02-9f66-5f0c626a94bc", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the my_sample_testsuiteRepository repository.
        /// </summary>
        public static my_sample_testsuiteRepository repo = my_sample_testsuiteRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            email = "";
            password = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _email;

        /// <summary>
        /// Gets or sets the value of variable email.
        /// </summary>
        [TestVariable("df12578b-45db-4c43-9d0e-2a94f502ad53")]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        string _password;

        /// <summary>
        /// Gets or sets the value of variable password.
        /// </summary>
        [TestVariable("44e0225b-6308-4592-8f6c-a12233a23ae3")]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://automationpractice.com/index.php' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://automationpractice.com/index.php", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyStore.LogInToYourCustomerAccount' at 39;11.", repo.MyStore.LogInToYourCustomerAccountInfo, new RecordItemIndex(1));
            repo.MyStore.LogInToYourCustomerAccount.Click("39;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(2));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyStore.Email' at 39;11.", repo.MyStore.EmailInfo, new RecordItemIndex(3));
            repo.MyStore.Email.Click("39;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$email' with focus on 'MyStore.Email'.", repo.MyStore.EmailInfo, new RecordItemIndex(4));
            repo.MyStore.Email.PressKeys(email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MyStore.Email'.", repo.MyStore.EmailInfo, new RecordItemIndex(5));
            repo.MyStore.Email.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyStore.Passwd' at 13;16.", repo.MyStore.PasswdInfo, new RecordItemIndex(6));
            repo.MyStore.Passwd.Click("13;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$password' with focus on 'MyStore.Passwd'.", repo.MyStore.PasswdInfo, new RecordItemIndex(7));
            repo.MyStore.Passwd.PressKeys(password);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyStore.SpanTagSignIn' at 55;20.", repo.MyStore.SpanTagSignInInfo, new RecordItemIndex(8));
            repo.MyStore.SpanTagSignIn.Click("55;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'MyStore.LogMeOut' at 31;18.", repo.MyStore.LogMeOutInfo, new RecordItemIndex(9));
            repo.MyStore.LogMeOut.MoveTo("31;18");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'MyStore.LogMeOut' at 31;18.", repo.MyStore.LogMeOutInfo, new RecordItemIndex(10));
            repo.MyStore.LogMeOut.MoveTo("31;18");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyStore.LogMeOut, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
