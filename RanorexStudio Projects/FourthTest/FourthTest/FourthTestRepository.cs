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

namespace FourthTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the FourthTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("51afa060-50f1-43ca-bea3-82737e97f17f")]
    public partial class FourthTestRepository : RepoGenBaseFolder
    {
        static FourthTestRepository instance = new FourthTestRepository();
        FourthTestRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the FourthTestRepository element repository.
        /// </summary>
        [RepositoryFolder("51afa060-50f1-43ca-bea3-82737e97f17f")]
        public static FourthTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public FourthTestRepository() 
            : base("FourthTestRepository", "/", null, 0, false, "51afa060-50f1-43ca-bea3-82737e97f17f", ".\\RepositoryImages\\FourthTestRepository51afa060.rximgres")
        {
            _applicationundertest = new FourthTestRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("51afa060-50f1-43ca-bea3-82737e97f17f")]
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
        [RepositoryFolder("ba317e24-d171-4bec-af53-685f51ae2603")]
        public virtual FourthTestRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class FourthTestRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("ba317e24-d171-4bec-af53-685f51ae2603")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _logoiconcontainerInfo;
            RepoItemInfo _searchInfo;
            RepoItemInfo _videotitleInfo;
            RepoItemInfo _urmacineiubestesilasaInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.youtube.com']", parentFolder, 30000, null, true, "ba317e24-d171-4bec-af53-685f51ae2603", "")
            {
                _logoiconcontainerInfo = new RepoItemInfo(this, "LogoIconContainer", ".//div[#'logo-icon-container']", 30000, null, "1fed5552-63a0-4336-a6cf-9c479d1b9a6e");
                _searchInfo = new RepoItemInfo(this, "Search", ".//div[#'search-input']/input[@id='search']", 30000, null, "7bdd3563-2a54-4380-a1a7-a402744a0bca");
                _videotitleInfo = new RepoItemInfo(this, "VideoTitle", ".//tag[#'page-manager']/?/?/div[@id='container']/?/?/div[@id='primary']/?/?/div[@id='contents']/?/?/div[@id='contents']/tag[3]/div[@id='dismissable']/?/?/div[@id='meta']/div[@id='title-wrapper']/?/?/a[@id='video-title']", 30000, null, "0d25ae5c-bf04-406c-99ed-d970c26adb09");
                _urmacineiubestesilasaInfo = new RepoItemInfo(this, "UrmaCineIubesteSiLasa", ".//div[#'info-contents']/?/?/div[@id='container']/?/?/tag[@innertext~'^Urma\\ -\\ Cine\\ iubeste\\ si\\ la']", 30000, null, "0e8275d7-e1ab-4f8f-98e7-61c7adacf825");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ba317e24-d171-4bec-af53-685f51ae2603")]
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
            [RepositoryItemInfo("ba317e24-d171-4bec-af53-685f51ae2603")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LogoIconContainer item.
            /// </summary>
            [RepositoryItem("1fed5552-63a0-4336-a6cf-9c479d1b9a6e")]
            public virtual Ranorex.DivTag LogoIconContainer
            {
                get
                {
                    return _logoiconcontainerInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The LogoIconContainer item info.
            /// </summary>
            [RepositoryItemInfo("1fed5552-63a0-4336-a6cf-9c479d1b9a6e")]
            public virtual RepoItemInfo LogoIconContainerInfo
            {
                get
                {
                    return _logoiconcontainerInfo;
                }
            }

            /// <summary>
            /// The Search item.
            /// </summary>
            [RepositoryItem("7bdd3563-2a54-4380-a1a7-a402744a0bca")]
            public virtual Ranorex.InputTag Search
            {
                get
                {
                    return _searchInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Search item info.
            /// </summary>
            [RepositoryItemInfo("7bdd3563-2a54-4380-a1a7-a402744a0bca")]
            public virtual RepoItemInfo SearchInfo
            {
                get
                {
                    return _searchInfo;
                }
            }

            /// <summary>
            /// The VideoTitle item.
            /// </summary>
            [RepositoryItem("0d25ae5c-bf04-406c-99ed-d970c26adb09")]
            public virtual Ranorex.ATag VideoTitle
            {
                get
                {
                    return _videotitleInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The VideoTitle item info.
            /// </summary>
            [RepositoryItemInfo("0d25ae5c-bf04-406c-99ed-d970c26adb09")]
            public virtual RepoItemInfo VideoTitleInfo
            {
                get
                {
                    return _videotitleInfo;
                }
            }

            /// <summary>
            /// The UrmaCineIubesteSiLasa item.
            /// </summary>
            [RepositoryItem("0e8275d7-e1ab-4f8f-98e7-61c7adacf825")]
            public virtual Ranorex.WebElement UrmaCineIubesteSiLasa
            {
                get
                {
                    return _urmacineiubestesilasaInfo.CreateAdapter<Ranorex.WebElement>(true);
                }
            }

            /// <summary>
            /// The UrmaCineIubesteSiLasa item info.
            /// </summary>
            [RepositoryItemInfo("0e8275d7-e1ab-4f8f-98e7-61c7adacf825")]
            public virtual RepoItemInfo UrmaCineIubesteSiLasaInfo
            {
                get
                {
                    return _urmacineiubestesilasaInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
