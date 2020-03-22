﻿namespace Admin.Core.Model.Input
{
    /// <summary>
    /// 通用分页信息输入类
    /// </summary>
    public class PageInput<T>
    {
        /// <summary>
        /// 当前页标
        /// </summary>
        public int CurrentPage { get; set; } = 1;

        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { set; get; } = 50;

        /// <summary>
        /// 查询条件
        /// </summary>
        public T Filter { get; set; }
    }
}
