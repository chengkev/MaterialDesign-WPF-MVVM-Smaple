﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZFS.Library.Helper
{

    /// <summary>
    /// 页面信息
    /// </summary>
    public class PageInfo 
    {
        private string headerName;
        private object body;

        /// <summary>
        /// 标题
        /// </summary>
        public string HeaderName
        {
            get { return headerName; }
            set { headerName = value;  }
        }

        /// <summary>
        /// 窗口内容
        /// </summary>
        public object Body
        {
            get { return body; }
            set { body = value;  }
        }
    }
}
