using System;
using FreeSql.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Admin.Core.Model.Admin
{
    /// <summary>
    /// 视图管理
    /// </summary>
	[Table(Name = "ad_view")]
    [Index("uk_view_path", "Path", true)]
    public class ViewEntity : EntityBase
    {
        /// <summary>
        /// 所属节点
        /// </summary>
		public long? ParentId { get; set; }

        /// <summary>
        /// 视图命名
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 视图名称
        /// </summary>
        [MaxLength(500)]
        public string Label { get; set; }

        /// <summary>
        /// 视图路径
        /// </summary>
        [MaxLength(500)]
        public string Path { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
