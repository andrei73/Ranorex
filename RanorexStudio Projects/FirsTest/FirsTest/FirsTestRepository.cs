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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace FirsTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the FirsTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("b702c94c-c3f0-4a15-bf71-6c3e87cea769")]
    public partial class FirsTestRepository : RepoGenBaseFolder
    {
        static FirsTestRepository instance = new FirsTestRepository();
        FirsTestRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        FirsTestRepositoryFolders.RanorexStudioWebTestPageAppFolder _ranorexstudiowebtestpage;

        /// <summary>
        /// Gets the singleton class instance representing the FirsTestRepository element repository.
        /// </summary>
        [RepositoryFolder("b702c94c-c3f0-4a15-bf71-6c3e87cea769")]
        public static FirsTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public FirsTestRepository() 
            : base("FirsTestRepository", "/", null, 0, false, "b702c94c-c3f0-4a15-bf71-6c3e87cea769", ".\\RepositoryImages\\FirsTestRepositoryb702c94c.rximgres")
        {
            _applicationundertest = new FirsTestRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _ranorexstudiowebtestpage = new FirsTestRepositoryFolders.RanorexStudioWebTestPageAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b702c94c-c3f0-4a15-bf71-6c3e87cea769")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("7d049bab-a590-46df-a3ae-e74fe1acb123")]
        public virtual FirsTestRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The RanorexStudioWebTestPage folder.
        /// </summary>
        [RepositoryFolder("dd2f7ddf-c94c-47c4-b028-f62740d2e60d")]
        public virtual FirsTestRepositoryFolders.RanorexStudioWebTestPageAppFolder RanorexStudioWebTestPage
        {
            get { return _ranorexstudiowebtestpage; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class FirsTestRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("7d049bab-a590-46df-a3ae-e74fe1acb123")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, true, "7d049bab-a590-46df-a3ae-e74fe1acb123", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7d049bab-a590-46df-a3ae-e74fe1acb123")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7d049bab-a590-46df-a3ae-e74fe1acb123")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The RanorexStudioWebTestPageAppFolder folder.
        /// </summary>
        [RepositoryFolder("dd2f7ddf-c94c-47c4-b028-f62740d2e60d")]
        public partial class RanorexStudioWebTestPageAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _headertopInfo;
            RepoItemInfo _opendialogInfo;

            /// <summary>
            /// Creates a new RanorexStudioWebTestPage  folder.
            /// </summary>
            public RanorexStudioWebTestPageAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RanorexStudioWebTestPage", "/dom[@caption~'^Ranorex\\ Studio\\ -\\ Web\\ test']", parentFolder, 30000, null, false, "dd2f7ddf-c94c-47c4-b028-f62740d2e60d", "")
            {
                _headertopInfo = new RepoItemInfo(this, "HeaderTop", ".//div[#'header-top']", 30000, null, "99ef0aec-458d-46da-8845-4f6d12c4f91c");
                _opendialogInfo = new RepoItemInfo(this, "OpenDialog", ".//div[#'Content']//a[@innertext='Open dialog']", 30000, null, "2ae95645-345b-47ca-9740-e3b4ce9e3a59");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("dd2f7ddf-c94c-47c4-b028-f62740d2e60d")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("dd2f7ddf-c94c-47c4-b028-f62740d2e60d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HeaderTop item.
            /// </summary>
            [RepositoryItem("99ef0aec-458d-46da-8845-4f6d12c4f91c")]
            public virtual Ranorex.DivTag HeaderTop
            {
                get
                {
                    return _headertopInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The HeaderTop item info.
            /// </summary>
            [RepositoryItemInfo("99ef0aec-458d-46da-8845-4f6d12c4f91c")]
            public virtual RepoItemInfo HeaderTopInfo
            {
                get
                {
                    return _headertopInfo;
                }
            }

            /// <summary>
            /// The OpenDialog item.
            /// </summary>
            [RepositoryItem("2ae95645-345b-47ca-9740-e3b4ce9e3a59")]
            public virtual Ranorex.ATag OpenDialog
            {
                get
                {
                    return _opendialogInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The OpenDialog item info.
            /// </summary>
            [RepositoryItemInfo("2ae95645-345b-47ca-9740-e3b4ce9e3a59")]
            public virtual RepoItemInfo OpenDialogInfo
            {
                get
                {
                    return _opendialogInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
