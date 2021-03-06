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

namespace SecondTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("773c3f37-da76-4e77-aa5d-66ef0eca3459", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SecondTestRepository repository.
        /// </summary>
        public static SecondTestRepository repo = SecondTestRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.Branding'.", repo.ApplicationUnderTest.BrandingInfo, new RecordItemIndex(0));
            Validate.Exists(repo.ApplicationUnderTest.BrandingInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ATagLogIn' at 42;30.", repo.ApplicationUnderTest.ATagLogInInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ATagLogIn.Click("42;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ATagLogInUsingFacebook' at 207;21.", repo.ApplicationUnderTest.ATagLogInUsingFacebookInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ATagLogInUsingFacebook.Click("207;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://dgalywyr863hv.cloudfront.net/pictures/athletes/20359837/8064397/1/medium.jpg') on item 'ApplicationUnderTest.AndreiSăvoiu'.", repo.ApplicationUnderTest.AndreiSăvoiuInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AndreiSăvoiuInfo, "Src", "https://dgalywyr863hv.cloudfront.net/pictures/athletes/20359837/8064397/1/medium.jpg");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
