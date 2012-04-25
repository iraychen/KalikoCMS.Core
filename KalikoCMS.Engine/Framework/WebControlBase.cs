﻿#region License and copyright notice
/* 
 * Kaliko Content Management System
 * 
 * Copyright (c) Fredrik Schultz and Contributors
 * 
 * This source is subject to the Microsoft Public License.
 * See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
 * All other rights reserved.
 * 
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
 * EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
 */
#endregion

namespace KalikoCMS.Framework {
    using KalikoCMS.Core;
    
    public class WebControlBase : System.Web.UI.UserControl {
        private CmsPage _currentPage;

        public CmsPage CurrentPage {
            get { return _currentPage ?? GetCurrentPage(); }
        }

        private CmsPage GetCurrentPage() {
            return (_currentPage = ((PageTemplate) Page).CurrentPage);
        }

        public static string Translate(string key) {
            return Language.Translate(key);
        }

    }
}
