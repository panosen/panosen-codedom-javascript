﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.JavaScript.Engine
{
    /// <summary>
    /// GenerateOptions
    /// </summary>
    public class GenerateOptions
    {
        /// <summary>
        /// 用于缩进的字符
        /// </summary>
        public string TabString { get; set; } = "    ";

        private int indentSize = 0;

        /// <summary>
        /// 缩进个数
        /// </summary>
        public int IndentSize
        {
            get
            {
                return this.indentSize;
            }
            set
            {
                this.indentSize = value;
                BuildIndentString();
            }
        }

        /// <summary>
        /// 缩进字符
        /// </summary>
        public string IndentString { get; private set; } = string.Empty;

        /// <summary>
        /// 增加缩进
        /// </summary>
        public void PushIndent()
        {
            this.indentSize = this.indentSize + 1;

            BuildIndentString();
        }

        /// <summary>
        /// 减少缩进
        /// </summary>
        public void PopIndent()
        {
            if (this.indentSize > 0)
            {
                this.indentSize = this.indentSize - 1;
            }

            BuildIndentString();
        }

        /// <summary>
        /// 构建缩进
        /// </summary>
        /// <returns></returns>
        private void BuildIndentString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.indentSize; i++)
            {
                builder.Append(this.TabString);
            }
            this.IndentString = builder.ToString();
        }

        /// <summary>
        /// 数组里面的对象自动换行
        /// </summary>
        public bool DataArrayItemBreakLine { get; set; }

        /// <summary>
        /// DataObject Key 单引号 或者 双引号
        /// </summary>
        public string DataObjectKeyQuotation { get; set; }
    }
}
